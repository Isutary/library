using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    public class BookModel
    {
        [Key]
        [BindNever]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey(nameof(Author))]
        public Guid AuthorId { get; set; }
        [BindNever]
        public AuthorModel Author { get; set; } 
        public DateTime Published { get; set; }
    }
}