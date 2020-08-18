using Library.Models.Roles;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class AspNetRolePermission
    {
        [Required]
        public Guid RoleId { get; set; }
        public RoleModel Role { get; set; }
        [Required]
        public Guid PermissionId { get; set; }
        public PermissionModel Permission { get; set; }
    }
}
