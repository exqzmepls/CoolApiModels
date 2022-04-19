using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    /// <summary>
    /// Update user model.
    /// </summary>
    public class PutUserModel
    {
        /// <summary>
        /// User new login.
        /// </summary>
        [StringLength(Constants.LoginMaxLength, MinimumLength = Constants.LoginMinLength)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string NewLogin { get; set; }

        /// <summary>
        /// User new password.
        /// </summary>
        [StringLength(Constants.PasswordMaxLength, MinimumLength = Constants.PasswordMinLength)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string NewPassword { get; set; }

        /// <summary>
        /// New password confirmation.
        /// </summary>
        [Compare(nameof(NewPassword))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string PasswordConfirmation { get; set; }

        /// <summary>
        /// User old password.
        /// </summary>
        [Required(ErrorMessage = "Old Password is empty.")]
        public string OldPassword { get; set; }
    }
}
