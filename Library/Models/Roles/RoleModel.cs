using Microsoft.AspNetCore.Identity;
using System;

namespace Library.Models.Roles
{
    public class RoleModel : IdentityRole<Guid>
    {
        public string Description { get; set; }

        public RoleModel() { }

        public RoleModel(string name, string description = "") : base(name) => Description = description;
    }
}
