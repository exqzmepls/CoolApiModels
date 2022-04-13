using System.ComponentModel.DataAnnotations;

namespace CoolApiModels.Users
{
    public class PutUserModel
    {
        [StringLength(16, MinimumLength = 6)]
        public string NewLogin { get; set; }

        [StringLength(32, MinimumLength = 8)]
        public string NewPassword { get; set; }

        [Compare(nameof(NewPassword))]
        public string PasswordConfirmation { get; set; }

        [Required(ErrorMessage = "Old Password is empty.")]
        public string OldPassword { get; set; }
    }
}
