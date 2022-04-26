using Swashbuckle.AspNetCore.Annotations;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Messages portion.
    /// </summary>
    [SwaggerSchema("Messages portion.")]
    public class MessagesPortionDetails : PortionDetails<MessageShortDetails>
    {
    }
}
