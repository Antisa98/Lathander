namespace Lathander.Domain.Interfaces;

public interface IEmailSender
{
    Task SendAsync(string subject, string body, CancellationToken cancellationToken = default);
}
