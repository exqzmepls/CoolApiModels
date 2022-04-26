using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Short message details (without attachments collection).
    /// </summary>
    [SwaggerSchema("Short message details.")]
    public class MessageShortDetails : BaseMessageDetails
    {
        /// <summary>
        /// Count of message attachments.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Count of message attachments.")]
        public int AttachmentsCount { get; set; }
    }
}
