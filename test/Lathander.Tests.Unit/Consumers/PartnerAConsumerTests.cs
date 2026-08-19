using Lathander.Application.Consumers;
using Lathander.Domain.Contracts;
using Lathander.Domain.Interfaces;
using Lathander.Domain.Models;
using MassTransit;
using Moq;

namespace Lathander.Tests.Unit.Consumers;

public sealed class PartnerAConsumerTests
{
    [Fact]
    public async Task Consume_AlwaysSendsEmailWithExpectedFields()
    {
        var emailSender = new Mock<IEmailSender>();
        var sut = new PartnerAConsumer(emailSender.Object);

        var message = new IbtEventReceived(
            new IbtMessage
            {
                EventType = 1234,
                ProductNameFull = "Sample Product ABC",
                IBTTypeCode = 123,
                ISIN = "DE0001234567",
            },
            DateTimeOffset.UtcNow);

        var context = new Mock<ConsumeContext<IbtEventReceived>>();
        context.Setup(c => c.Message).Returns(message);
        context.Setup(c => c.CancellationToken).Returns(CancellationToken.None);

        await sut.Consume(context.Object);

        emailSender.Verify(e => e.SendAsync(
            It.IsAny<string>(),
            It.Is<string>(body =>
                body.Contains("Sample Product ABC") &&
                body.Contains("123") &&
                body.Contains("1234") &&
                body.Contains("DE0001234567")),
            CancellationToken.None), Times.Once);
    }
}
