using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    public class PostUserModel
    {
        [Required(ErrorMessage = "Login is empty.")]
        [StringLength(Constants.LoginMaxLength, MinimumLength = Constants.LoginMinLength)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is empty.")]
        [StringLength(Constants.PasswordMaxLength, MinimumLength = Constants.PasswordMinLength)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is empty.")]
        [Compare(nameof(Password))]
        public string PasswordConfirmation { get; set; }
    }
}
