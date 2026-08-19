namespace Lathander.Domain.Models;

public sealed record IbtEvent(ushort EventType, DateTimeOffset ReceivedAtUtc);
