using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CoolApiModels.Chats
{
    public class GetChatModel : ShortGetChatModel
    {
        [JsonRequired]
        public List<Guid> ChatMembersIds { get; set; }
    }
}
