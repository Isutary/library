using System.ComponentModel.DataAnnotations;

namespace Library.Models.Users
{
    public class PasswordResetModel
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string NewPassword { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public string Token { get; set; }
    }
}
