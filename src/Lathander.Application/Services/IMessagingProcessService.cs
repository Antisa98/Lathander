using Lathander.Domain.Models;

namespace Lathander.Application.Services;

public interface IMessagingProcessService
{
    Task ProcessAsync(IBTTermSheet message, CancellationToken cancellationToken = default);
}
