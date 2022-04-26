using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Message details.
    /// </summary>
    [SwaggerSchema("Message details.")]
    public class MessageDetails : BaseMessageDetails
    {
        /// <summary>
        /// Collection of message attachments (photos, ...) in strings (base64).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("Collection of message attachments in strings (base64).")]
        public List<string> Attachments { get; set; }
    }
}
