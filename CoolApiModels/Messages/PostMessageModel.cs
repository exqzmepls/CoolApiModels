using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// New message description.
    /// </summary>
    public class PostMessageModel
    {
        /// <summary>
        /// Chat ID to add message.
        /// </summary>
        [Required(ErrorMessage = "Chat Id is empty")]
        public Guid ChatId { get; set; }

        /// <summary>
        /// Message text.
        /// </summary>
        [StringLength(1024)]
        public string Text { get; set; }

        /// <summary>
        /// Collection of message attachments (photos, ...) in base64strings.
        /// </summary>
        [MaxLength(10)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Attachments { get; set; }
    }
}
