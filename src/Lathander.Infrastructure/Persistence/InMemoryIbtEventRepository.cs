using System.Collections.Concurrent;
using Lathander.Domain.Interfaces;
using Lathander.Domain.Models;

namespace Lathander.Infrastructure.Persistence;

public sealed class InMemoryIbtEventRepository : IIbtEventRepository
{
    private static readonly ConcurrentBag<IbtEvent> Store = [];

    public Task SaveAsync(IbtEvent ibtEvent, CancellationToken cancellationToken = default)
    {
        Store.Add(ibtEvent);
        return Task.CompletedTask;
    }
}
