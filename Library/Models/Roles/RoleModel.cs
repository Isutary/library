using Microsoft.AspNetCore.Identity;

namespace Library.Models.Roles
{
    public class RoleModel : IdentityRole
    {
        public string Description { get; set; }

        public RoleModel(string name, string description = "") : base(name) => Description = description;
    }
}
