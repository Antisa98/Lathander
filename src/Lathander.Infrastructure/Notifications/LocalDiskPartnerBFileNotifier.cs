using System.Globalization;
using System.Xml.Linq;
using Lathander.Configuration.Options;
using Lathander.Domain.Interfaces;
using Microsoft.Extensions.Options;

namespace Lathander.Infrastructure.Notifications;

public sealed class LocalDiskPartnerBFileNotifier(IOptions<PartnerBOptions> options) : IPartnerBFileNotifier
{
    public async Task WriteAsync(DateTimeOffset timespan, string isin, CancellationToken cancellationToken = default)
    {
        var xml = new XElement("InstrumentNotification",
            new XElement("Timespan", timespan.ToString("O", CultureInfo.InvariantCulture)),
            new XElement("ISIN", new XAttribute("IdSchemeCode", "I-"), isin));

        var directory = options.Value.OutputDirectory;
        Directory.CreateDirectory(directory);

        var fileName = $"InstrumentNotification_{timespan:yyyyMMddHHmmssfff}.xml";
        var path = Path.Combine(directory, fileName);

        await using var stream = File.Create(path);
        await xml.SaveAsync(stream, SaveOptions.None, cancellationToken);
    }
}
