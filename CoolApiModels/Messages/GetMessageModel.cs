using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolApiModels.Messages
{
    public class GetMessageModel : BaseGetMessageModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Attachments { get; set; }
    }
}
