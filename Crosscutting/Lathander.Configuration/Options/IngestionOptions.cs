namespace Lathander.Configuration.Options;

public sealed class IngestionOptions
{
    public const string SectionName = "Ingestion";

    public required string SourceFilePath { get; set; }
}
