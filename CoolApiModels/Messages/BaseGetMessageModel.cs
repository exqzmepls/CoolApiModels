using Newtonsoft.Json;
using System;

namespace CoolApiModels.Messages
{
    public abstract class BaseGetMessageModel
    {
        [JsonRequired]
        public Guid Id { get; set; }

        [JsonRequired]
        public Guid SenderId { get; set; }

        [JsonRequired]
        public DateTime SendingDateUtc { get; set; }

        [JsonRequired]
        public bool IsViewed { get; set; }

        [JsonRequired]
        public string Text { get; set; }
    }
}
