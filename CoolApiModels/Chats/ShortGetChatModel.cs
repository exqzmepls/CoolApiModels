using Newtonsoft.Json;
using System;

namespace CoolApiModels.Chats
{
    public class ShortGetChatModel
    {
        [JsonRequired]
        public Guid Id { get; set; }

        [JsonRequired]
        public DateTime CreationTimeUtc { get; set; }
    }
}
