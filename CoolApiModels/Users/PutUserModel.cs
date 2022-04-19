using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    public class PutUserModel
    {
        [StringLength(Constants.LoginMaxLength, MinimumLength = Constants.LoginMinLength)]
        public string NewLogin { get; set; }

        [StringLength(Constants.PasswordMaxLength, MinimumLength = Constants.PasswordMinLength)]
        public string NewPassword { get; set; }

        [Compare(nameof(NewPassword))]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "Old Password is empty.")]
        public string OldPassword { get; set; }
    }
}
