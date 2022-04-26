using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Base message details.
    /// </summary>
    [SwaggerSchema("Base message details")]
    public abstract class BaseMessageDetails
    {
        /// <summary>
        /// Message ID.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Message ID.")]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of user who sent message.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("ID of user who sent message.")]
        public Guid SenderId { get; set; }

        /// <summary>
        /// Message sending date (local).
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Message sending date.")]
        public DateTime SendingTimeLocal { get; set; }

        /// <summary>
        /// Is message viewed by other chat member.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Is message viewed by other chat member.")]
        public bool IsViewed { get; set; }

        /// <summary>
        /// Message text.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Message text.")]
        public string Text { get; set; }
    }
}
