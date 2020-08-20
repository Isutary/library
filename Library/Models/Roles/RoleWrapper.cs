using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models.Roles
{
    public class RoleWrapper
    {
        [Required]
        public Guid Id { get; set; }
    }
}
