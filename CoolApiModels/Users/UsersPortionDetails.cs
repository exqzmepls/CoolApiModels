using Swashbuckle.AspNetCore.Annotations;

namespace CoolApiModels.Users
{
    /// <summary>
    /// Users portion.
    /// </summary>
    [SwaggerSchema("Users portion details.")]
    public class UsersPortionDetails : PortionDetails<UserDetails>
    {
    }
}
