using System;
using System.Collections.Generic;

namespace CoolApiModels.Chats
{
    public class GetChatModel : ShortGetChatModel
    {
        public List<Guid> ChatMembersIds { get; set; }
    }
}
