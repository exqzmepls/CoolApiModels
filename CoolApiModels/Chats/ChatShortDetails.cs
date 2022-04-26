using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// Chat short description.
    /// </summary>
    [SwaggerSchema("Chat short description.")]
    public class ChatShortDetails
    {
        /// <summary>
        /// Chat ID.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Chat ID.")]
        public Guid Id { get; set; }

        /// <summary>
        /// Chat creation time.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Chat creation time.")]
        public DateTime CreationTime { get; set; }
    }
}
