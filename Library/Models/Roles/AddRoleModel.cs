using System.ComponentModel.DataAnnotations;

namespace Library.Models.Roles
{
    public class AddRoleModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
