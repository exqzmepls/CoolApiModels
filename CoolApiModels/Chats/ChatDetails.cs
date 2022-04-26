using CoolApiModels.Users;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// Chat description.
    /// </summary>
    [SwaggerSchema("Chat description.")]
    public class ChatDetails : ChatShortDetails
    {
        /// <summary>
        /// Chat members ID collection.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Chat members collection.")]
        public List<UserDetails> ChatMembersIds { get; set; }
    }
}
