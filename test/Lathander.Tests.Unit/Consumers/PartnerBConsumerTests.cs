using Lathander.Application.Consumers;
using Lathander.Domain.Contracts;
using Lathander.Domain.Interfaces;
using Lathander.Domain.Models;
using MassTransit;
using Moq;

namespace Lathander.Tests.Unit.Consumers;

public sealed class PartnerBConsumerTests
{
    private static Mock<ConsumeContext<IbtEventReceived>> CreateContext(IbtEventReceived message)
    {
        var context = new Mock<ConsumeContext<IbtEventReceived>>();
        context.Setup(c => c.Message).Returns(message);
        context.Setup(c => c.CancellationToken).Returns(CancellationToken.None);
        return context;
    }

    [Fact]
    public async Task Consume_WhenEventTypeIsNot9097_DoesNotWriteFile()
    {
        var notifier = new Mock<IPartnerBFileNotifier>();
        var sut = new PartnerBConsumer(notifier.Object);
        var message = new IbtEventReceived(
            new IbtMessage { EventType = 1234, ISIN = "DE0001234567" },
            DateTimeOffset.UtcNow);

        await sut.Consume(CreateContext(message).Object);

        notifier.Verify(n => n.WriteAsync(It.IsAny<DateTimeOffset>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task Consume_WhenEventTypeIs9097ButIsinMissing_DoesNotWriteFile()
    {
        var notifier = new Mock<IPartnerBFileNotifier>();
        var sut = new PartnerBConsumer(notifier.Object);
        var message = new IbtEventReceived(
            new IbtMessage { EventType = 9097, ISIN = null },
            DateTimeOffset.UtcNow);

        await sut.Consume(CreateContext(message).Object);

        notifier.Verify(n => n.WriteAsync(It.IsAny<DateTimeOffset>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task Consume_WhenEventTypeIs9097AndIsinPresent_WritesFile()
    {
        var notifier = new Mock<IPartnerBFileNotifier>();
        var sut = new PartnerBConsumer(notifier.Object);
        var receivedAt = DateTimeOffset.UtcNow;
        var message = new IbtEventReceived(
            new IbtMessage { EventType = 9097, ISIN = "DE0001234567" },
            receivedAt);

        await sut.Consume(CreateContext(message).Object);

        notifier.Verify(n => n.WriteAsync(receivedAt, "DE0001234567", CancellationToken.None), Times.Once);
    }
}
