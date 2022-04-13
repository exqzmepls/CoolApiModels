using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    public class PostUserModel
    {
        private const int PasswordMaxLength = 32;
        private const int PasswordMinLength = 8;

        [Required(ErrorMessage = "Login is empty.")]
        [StringLength(16, MinimumLength = 6)]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password is empty.")]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is empty.")]
        [Compare(nameof(Password))]
        public string PasswordConfirmation { get; set; }
    }
}
