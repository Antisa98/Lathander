namespace Lathander.Domain.Interfaces;

public interface IIbtMessageSource
{
    Task<string> ReadRawMessageAsync(CancellationToken cancellationToken = default);
}
