using Newtonsoft.Json;
using System;

namespace CoolApiModels.Users
{
    public class GetUserModel
    {
        [JsonRequired]
        public Guid Id { get; set; }

        [JsonRequired]
        public string Login { get; set; }
    }
}
