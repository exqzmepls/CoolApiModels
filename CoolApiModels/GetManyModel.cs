using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoolApiModels
{
    /// <summary>
    /// Generic model for data portion.
    /// </summary>
    /// <typeparam name="T">Type of data item.</typeparam>
    public abstract class GetManyModel<T>
    {
        /// <summary>
        /// Data portion offset.
        /// </summary>
        [JsonRequired]
        public int Offset { get; set; }

        /// <summary>
        /// Size of data portion.
        /// </summary>
        [JsonRequired]
        public int Portion { get; set; }

        /// <summary>
        /// Total count of data in storage. 
        /// </summary>
        [JsonRequired]
        public int TotalCount { get; set; }

        /// <summary>
        /// Data collection.
        /// </summary>
        [JsonRequired]
        public List<T> Content { get; set; }
    }
}
