using Lathander.Domain.Models;

namespace Lathander.Domain.Interfaces;

public interface IIbtEventRepository
{
    Task SaveAsync(IbtEvent ibtEvent, CancellationToken cancellationToken = default);
}
