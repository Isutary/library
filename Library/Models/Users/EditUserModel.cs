using System.ComponentModel.DataAnnotations;

namespace Library.Models.Users
{
    public class EditUserModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}