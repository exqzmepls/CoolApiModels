using Newtonsoft.Json;
using System;

namespace CoolApiModels.Users
{
    /// <summary>
    /// User description.
    /// </summary>
    public class GetUserModel
    {
        /// <summary>
        /// User ID.
        /// </summary>
        [JsonRequired]
        public Guid Id { get; set; }

        /// <summary>
        /// User login.
        /// </summary>
        [JsonRequired]
        public string Login { get; set; }
    }
}
