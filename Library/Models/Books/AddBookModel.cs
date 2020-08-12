using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
