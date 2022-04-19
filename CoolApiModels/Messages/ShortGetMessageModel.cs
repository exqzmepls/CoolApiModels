using Newtonsoft.Json;

namespace CoolApiModels.Messages
{
    public class ShortGetMessageModel : BaseGetMessageModel
    {
        [JsonRequired]
        public int AttachmentsCount { get; set; }
    }
}
