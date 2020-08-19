using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class PermissionModel
    {
        [Key]
        [BindNever]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public PermissionModel(Guid id, string name, string description = "") =>
            (Id, Name, Description) = (id, name, description);
    }
}
