using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    public class UserConfirmationDetails
    {
        /// <summary>
        /// User current password.
        /// </summary>
        [Required(ErrorMessage = "Current password is empty.")]
        [SwaggerSchema("User current password.")]
        public string CurrentPassword { get; set; }
    }
}
