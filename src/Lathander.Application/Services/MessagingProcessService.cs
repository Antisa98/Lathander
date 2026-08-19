using Lathander.Domain.Contracts;
using Lathander.Domain.Interfaces;
using Lathander.Domain.Models;
using MassTransit;

namespace Lathander.Application.Services;

public sealed class MessagingProcessService(IIbtEventRepository eventRepository, IPublishEndpoint publishEndpoint) : IMessagingProcessService
{
    public async Task ProcessAsync(IBTTermSheet message, CancellationToken cancellationToken = default)
    {
        var receivedAtUtc = DateTime.UtcNow;

        IbtMessage ibtMessage = new()
        {
            EventType = message.Events?.Event.EventType ?? 0,
            ProductNameFull = message.Instrument?.ProductNameFull,
            IBTTypeCode = message.Instrument?.IBTTypeCode,
            ISIN = message.Instrument?.InstrumentIds?.InstrumentId?.FirstOrDefault(x => x.IdSchemeCode == "I-")?.IdValue
        };

        await eventRepository.SaveAsync(new IbtEvent(ibtMessage.EventType, receivedAtUtc), cancellationToken);

        await publishEndpoint.Publish(new IbtEventReceived(ibtMessage, receivedAtUtc), cancellationToken);
    }
}