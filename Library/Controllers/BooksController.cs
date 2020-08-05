using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private LibraryDbContext _context;

        public BooksController(LibraryDbContext context) => _context = context;
        
        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _context.Books.Where(x => true).Include(x => x.Author);
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            Book book = _context.Books.Where(x => x.Id == id).Include(x => x.Author).FirstOrDefault();
            return Ok(book);
        }

        [HttpPost]
        public IActionResult AddBook([FromForm] Book book)
        {
            book.Author = _context.Authors.Where(x => x.FirstName == book.Author.FirstName).FirstOrDefault();
            book.AuthorId = _context.Authors.Where(x => x.FirstName == book.Author.FirstName).Select(x => x.Id).FirstOrDefault();
            _context.Books.Add(book);
            _context.SaveChangesAsync();
            return Accepted(book);
        }
    }
}
