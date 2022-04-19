using Newtonsoft.Json;
using System;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// Short descriptions for Chat.
    /// </summary>
    public class ShortGetChatModel
    {
        /// <summary>
        /// Chat ID.
        /// </summary>
        [JsonRequired]
        public Guid Id { get; set; }

        /// <summary>
        /// Chat creation date (UTC).
        /// </summary>
        [JsonRequired]
        public DateTime CreationTimeUtc { get; set; }
    }
}
