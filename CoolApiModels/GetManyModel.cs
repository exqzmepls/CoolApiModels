using System.Collections.Generic;

namespace CoolApiModels
{
    public abstract class GetManyModel<T>
    {
        public int Offset { get; set; }

        public int Portion { get; set; }

        public int TotalCount { get; set; }

        public List<T> Content { get; set; }
    }
}
