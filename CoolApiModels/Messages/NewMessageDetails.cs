using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// New message details.
    /// </summary>
    [SwaggerSchema("New message details.")]
    public class NewMessageDetails
    {
        /// <summary>
        /// Chat ID to add message.
        /// </summary>
        [Required(ErrorMessage = "Chat Id is empty.")]
        [SwaggerSchema("Chat ID to add message.")]
        public Guid ChatId { get; set; }

        /// <summary>
        /// Message text.
        /// </summary>
        [StringLength(1024)]
        [SwaggerSchema("Message text (can be empty if attachments are added).")]
        public string Text { get; set; }

        /// <summary>
        /// Collection of message attachments (photos, ...) in strings (base64).
        /// </summary>
        [MaxLength(10)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("Collection of message attachments in strings (base64).")]
        public IEnumerable<string> Attachments { get; set; }
    }
}
