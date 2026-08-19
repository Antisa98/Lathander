using Lathander.Configuration.Options;
using Lathander.Domain.Interfaces;
using Microsoft.Extensions.Options;

namespace Lathander.Infrastructure.Ingestion;

public sealed class FileSystemIbtMessageSource(IOptions<IngestionOptions> options) : IIbtMessageSource
{
    public async Task<string> ReadRawMessageAsync(CancellationToken cancellationToken = default)
    {
        var path = options.Value.SourceFilePath;

        if (!File.Exists(path))
            throw new FileNotFoundException($"No IBT message file found at '{path}'.", path);

        return await File.ReadAllTextAsync(path, cancellationToken);
    }
}
