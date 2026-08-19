using Lathander.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace Lathander.Infrastructure.Notifications;

public sealed class LoggingEmailSender(ILogger<LoggingEmailSender> logger) : IEmailSender
{
    public Task SendAsync(string subject, string body, CancellationToken cancellationToken = default)
    {
        logger.LogInformation(
            "Sending email to Partner A. Subject: {Subject}{NewLine}Body:{NewLine}{Body}",
            subject,
            Environment.NewLine,
            Environment.NewLine,
            body);

        return Task.CompletedTask;
    }
}
