using System;

namespace CoolApiModels.Users
{
    public class AuthenticatedResult
    {
        public Guid UserId { get; set; }

        public string Token { get; set; }
    }
}
