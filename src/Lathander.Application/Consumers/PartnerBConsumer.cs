using Lathander.Domain.Contracts;
using Lathander.Domain.Interfaces;
using MassTransit;

namespace Lathander.Application.Consumers;

public sealed class PartnerBConsumer(IPartnerBFileNotifier fileNotifier) : IConsumer<IbtEventReceived>
{
    private const ushort InterestedEventType = 9097;

    public async Task Consume(ConsumeContext<IbtEventReceived> context)
    {
        var evt = context.Message;

        if (evt.Message.EventType != InterestedEventType)
            return;

        if (string.IsNullOrWhiteSpace(evt.Message.ISIN))
            return;

        await fileNotifier.WriteAsync(evt.ReceivedAtUtc, evt.Message.ISIN, context.CancellationToken);
    }
}
