namespace Lathander.Domain.Interfaces;

public interface IPartnerBFileNotifier
{
    Task WriteAsync(DateTimeOffset timespan, string isin, CancellationToken cancellationToken = default);
}
