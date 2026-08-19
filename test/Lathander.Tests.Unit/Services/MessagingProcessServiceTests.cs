using Lathander.Application.Services;
using Lathander.Domain.Contracts;
using Lathander.Domain.Interfaces;
using Lathander.Domain.Models;
using MassTransit;
using Moq;

namespace Lathander.Tests.Unit.Services;

public sealed class MessagingProcessServiceTests
{
    [Fact]
    public async Task ProcessAsync_ReadsParsesSavesAndPublishes()
    {
        const string rawXml = "<IBTUpload />";

        var message = new IBTTermSheet
        {
            Events = new()
            {
                Event = new() { EventType = 9097 }
            },
            Instrument = new()
            {
                InstrumentIds = new()
                {
                    InstrumentId =
                    [
                        new()
                        {
                            IdSchemeCode = "I-",
                            IdValue = "DE0001234567"

                        }
                    ]

                }
            }

        };

        var parsedMessage = new IbtMessage { EventType = 9097, ISIN = "DE0001234567" };

        var source = new Mock<IIbtMessageSource>();
        source.Setup(s => s.ReadRawMessageAsync(It.IsAny<CancellationToken>())).ReturnsAsync(rawXml);

        var repository = new Mock<IIbtEventRepository>();

        var publishEndpoint = new Mock<IPublishEndpoint>();

        var sut = new MessagingProcessService(
            repository.Object,
            publishEndpoint.Object);

        await sut.ProcessAsync(message, It.IsAny<CancellationToken>());

        repository.Verify(r => r.SaveAsync(
            It.Is<IbtEvent>(e => e.EventType == 9097 && e.ReceivedAtUtc != default),
            It.IsAny<CancellationToken>()), Times.Once);

        publishEndpoint.Verify(p => p.Publish(
            It.Is<IbtEventReceived>(e => e.Message.EventType == 9097 && e.Message.ISIN == "DE0001234567" && e.ReceivedAtUtc != default),
            It.IsAny<CancellationToken>()), Times.Once);
    }
}
