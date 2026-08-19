using Lathander.Domain.Contracts;
using Lathander.Domain.Interfaces;
using MassTransit;

namespace Lathander.Application.Consumers;

public sealed class PartnerAConsumer(IEmailSender emailSender) : IConsumer<IbtEventReceived>
{
    public async Task Consume(ConsumeContext<IbtEventReceived> context)
    {
        var message = context.Message.Message;

        var body = $"""
            ProductNameFull: {message.ProductNameFull}
            IBTTypeCode: {message.IBTTypeCode}
            EventType: {message.EventType}
            ISIN: {message.ISIN}
            """;

        await emailSender.SendAsync("New IBT event notification", body, context.CancellationToken);
    }
}
