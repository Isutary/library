using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models.Books
{
    public class AddBookModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        public DateTime Published { get; set; }
    }
}