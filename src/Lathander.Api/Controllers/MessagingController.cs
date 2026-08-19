using Lathander.Application.Services;
using Lathander.Domain.Interfaces;
using Lathander.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

namespace Lathander.Api.Controllers;

[ApiController]
[Route("")]
public sealed class MessagingController(IIbtMessageSource messageSource, IMessagingProcessService messagingProcessService) : ControllerBase
{
    [HttpPost("processMessage")]
    public async Task<IActionResult> PostProcessMessage([FromBody] IBTTermSheet message, CancellationToken cancellationToken)
    {
        message ??= await ParseMessage(cancellationToken);
        if (message == null) return NotFound();

        await messagingProcessService.ProcessAsync(message, cancellationToken);

        return Accepted();
    }


    [HttpGet("testProcessMessage")]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var message = await ParseMessage(cancellationToken);
        if (message == null) return NotFound();

        await messagingProcessService.ProcessAsync(message, cancellationToken);
        return Accepted();
    }


    // This method and IIbtMessageSource are not needed if the messages are sent in the body of the request, but they are useful for testing and development purposes
    private async Task<IBTTermSheet?> ParseMessage(CancellationToken cancellationToken)
    {
        IBTTermSheet? message;

        var rawXml = await messageSource.ReadRawMessageAsync(cancellationToken);
        var serializer = new XmlSerializer(typeof(IBTTermSheet));

        using var reader = new StringReader(rawXml);
        try
        {
            message = (IBTTermSheet)serializer.Deserialize(reader);
        }
        catch (Exception)
        {
            // Handle deserialization errors
            throw;
        }

        return message;
    }
}
