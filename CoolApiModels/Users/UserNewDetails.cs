using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    /// <summary>
    /// User new details.
    /// </summary>
    [SwaggerSchema("User new details.")]
    public class UserNewDetails
    {
        /// <summary>
        /// User new login.
        /// </summary>
        [StringLength(Constants.LoginMaxLength, MinimumLength = Constants.LoginMinLength)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("User new login.")]
        public string NewLogin { get; set; }

        /// <summary>
        /// User new password.
        /// </summary>
        [StringLength(Constants.PasswordMaxLength, MinimumLength = Constants.PasswordMinLength)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [SwaggerSchema("User new password.")]
        public string NewPassword { get; set; }

        /// <summary>
        /// User old password.
        /// </summary>
        [Required(ErrorMessage = "Old Password is empty.")]
        [SwaggerSchema("User old password.")]
        public string OldPassword { get; set; }
    }
}
