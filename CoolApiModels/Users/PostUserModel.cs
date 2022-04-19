using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    /// <summary>
    /// New user description.
    /// </summary>
    public class PostUserModel
    {
        /// <summary>
        /// User login.
        /// </summary>
        [Required(ErrorMessage = "Login is empty.")]
        [StringLength(Constants.LoginMaxLength, MinimumLength = Constants.LoginMinLength)]
        public string Login { get; set; }

        /// <summary>
        /// User password.
        /// </summary>
        [Required(ErrorMessage = "Password is empty.")]
        [StringLength(Constants.PasswordMaxLength, MinimumLength = Constants.PasswordMinLength)]
        public string Password { get; set; }

        /// <summary>
        /// Password confirmation.
        /// </summary>
        [Required(ErrorMessage = "Password confirmation is empty.")]
        [Compare(nameof(Password))]
        public string PasswordConfirmation { get; set; }
    }
}
