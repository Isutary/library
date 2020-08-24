using System.ComponentModel.DataAnnotations;

namespace Library.Models.Users
{
    public class EmailWrapper
    {
        [Required]
        public string Email { get; set; }
    }
}
