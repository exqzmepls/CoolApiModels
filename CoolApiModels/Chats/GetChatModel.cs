using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoolApiModels.Chats
{
    /// <summary>
    /// Chat description.
    /// </summary>
    public class GetChatModel : ShortGetChatModel
    {
        /// <summary>
        /// Chat members ID collection.
        /// </summary>
        [JsonRequired]
        public List<Guid> ChatMembersIds { get; set; }
    }
}
