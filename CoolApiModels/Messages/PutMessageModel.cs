using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Messages
{
    public class PutMessageModel
    {
        [StringLength(1024)]
        public string Text { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsViewed { get; set; }

        [MaxLength(10)]
        public List<string> Attachments { get; set; }
    }
}
