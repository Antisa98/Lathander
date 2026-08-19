using Lathander.Domain.Models;

namespace Lathander.Domain.Contracts;

public sealed record IbtEventReceived(IbtMessage Message, DateTimeOffset ReceivedAtUtc);
