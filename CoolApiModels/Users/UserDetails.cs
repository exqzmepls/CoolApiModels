using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace CoolApiModels.Users
{
    /// <summary>
    /// User profile info.
    /// </summary>
    [SwaggerSchema("User profile info.")]
    public class UserDetails
    {
        /// <summary>
        /// User ID.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("User ID.")]
        public Guid Id { get; set; }

        /// <summary>
        /// User login.
        /// </summary>
        [JsonRequired]
        [SwaggerSchema("User login.")]
        public string Login { get; set; }
    }
}
