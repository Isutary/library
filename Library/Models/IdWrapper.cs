using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class IdWrapper
    {
        [Required]
        public Guid Id { get; set; }
    }
}
