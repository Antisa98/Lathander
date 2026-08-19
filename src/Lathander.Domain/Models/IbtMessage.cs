namespace Lathander.Domain.Models;

public sealed class IbtMessage
{
    public required ushort EventType { get; init; }

    public string? ProductNameFull { get; init; }

    public uint? IBTTypeCode { get; init; }

    public string? ISIN { get; init; }
}
