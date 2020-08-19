using System.ComponentModel.DataAnnotations;

namespace Library.Models.Users
{
    public class EditUserModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
