using Newtonsoft.Json;
using System;

namespace CoolApiModels.Messages
{
    /// <summary>
    /// Base message description.
    /// </summary>
    public abstract class BaseMessageDetails
    {
        /// <summary>
        /// Message ID.
        /// </summary>
        [JsonRequired]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of user who sent message.
        /// </summary>
        [JsonRequired]
        public Guid SenderId { get; set; }

        /// <summary>
        /// Message sending date (UTC).
        /// </summary>
        [JsonRequired]
        public DateTime SendingTimeUtc { get; set; }

        /// <summary>
        /// Is message viewed by other chat member.
        /// </summary>
        [JsonRequired]
        public bool IsViewed { get; set; }

        /// <summary>
        /// Message text.
        /// </summary>
        [JsonRequired]
        public string Text { get; set; }
    }
}
