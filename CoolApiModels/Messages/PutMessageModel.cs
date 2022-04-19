using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Update message model.
    /// </summary>
    public class PutMessageModel
    {
        /// <summary>
        /// Message new text.
        /// </summary>
        [StringLength(1024)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Is message viewed by other chat member (only can be set to 'true').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsViewed { get; set; }

        /// <summary>
        /// Collection of message new attachments (photos, ...) in base64strings.
        /// </summary>
        [MaxLength(10)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Attachments { get; set; }
    }
}
