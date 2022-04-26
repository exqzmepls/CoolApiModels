using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace CoolApiModels
{
    /// <summary>
    /// Base generic class for data portion.
    /// </summary>
    /// <typeparam name="T">Type of data item.</typeparam>
    public abstract class PortionDetails<T>
    {
        /// <summary>
        /// Data portion offset.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Data portion offset.")]
        public int Offset { get; set; }

        /// <summary>
        /// Size of data portion.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Size of data portion.")]
        public int Portion { get; set; }

        /// <summary>
        /// Total count of data in storage.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Total count of data in storage.")]
        public int TotalCount { get; set; }

        /// <summary>
        /// Data collection.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("Data collection.")]
        public IEnumerable<T> Content { get; set; }
    }
}
