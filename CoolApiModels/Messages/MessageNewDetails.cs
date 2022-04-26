using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Message new details.
    /// </summary>
    [SwaggerSchema("Message new details.")]
    public class MessageNewDetails
    {
        /// <summary>
        /// Message new text.
        /// </summary>
        [StringLength(1024)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("Message new text.")]
        public string Text { get; set; }

        /// <summary>
        /// Is message viewed by other chat member (only can be set to 'true').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("Is message viewed by other chat member (only can be set to 'true' by receiver).")]
        public bool? IsViewed { get; set; }

        /// <summary>
        /// Collection of message new attachments (photos, ...) in strings (base64).
        /// </summary>
        [MaxLength(10)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("Collection of message new attachments in strings (base64).")]
        public IEnumerable<string> Attachments { get; set; }
    }
}
