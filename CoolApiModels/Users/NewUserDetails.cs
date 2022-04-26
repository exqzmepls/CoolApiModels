using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    /// <summary>
    /// New user details.
    /// </summary>
    [SwaggerSchema("New user details.")]
    public class NewUserDetails
    {
        /// <summary>
        /// User login.
        /// </summary>
        [Required(ErrorMessage = "Login is empty.")]
        [StringLength(Constants.LoginMaxLength, MinimumLength = Constants.LoginMinLength)]
        [SwaggerSchema("User login.")]
        public string Login { get; set; }

        /// <summary>
        /// User password.
        /// </summary>
        [Required(ErrorMessage = "Password is empty.")]
        [StringLength(Constants.PasswordMaxLength, MinimumLength = Constants.PasswordMinLength)]
        [SwaggerSchema("User password.")]
        public string Password { get; set; }
    }
}
