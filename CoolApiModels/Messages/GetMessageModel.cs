using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Message description.
    /// </summary>
    public class GetMessageModel : BaseMessageDetails
    {
        /// <summary>
        /// Collection of message attachments (photos, ...) in base64strings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Attachments { get; set; }
    }
}
