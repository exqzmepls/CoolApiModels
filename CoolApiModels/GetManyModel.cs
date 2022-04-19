using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolApiModels
{
    public abstract class GetManyModel<T>
    {
        [JsonRequired]
        public int Offset { get; set; }

        [JsonRequired]
        public int Portion { get; set; }

        [JsonRequired]
        public int TotalCount { get; set; }

        [JsonRequired]
        public List<T> Content { get; set; }
    }
}
