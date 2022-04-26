using Swashbuckle.AspNetCore.Annotations;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// Chats portion.
    /// </summary>
    [SwaggerSchema("Chats portion details.")]
    public class ChatsPortionDetails : PortionDetails<ChatShortDetails>
    {
    }
}
