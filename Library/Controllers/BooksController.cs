using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly LibraryDbContext _context;

        public BooksController(LibraryDbContext context) => _context = context;
        
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            List<Book> books = await _context.Books.Where(x => true).Include(x => x.Author).ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            Book book = await _context.Books.Where(x => x.Id == id).Include(x => x.Author).FirstOrDefaultAsync();
            if (book == null) return NotFound(new Error { Message = $"Book with id: {id} does not exist." });
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromForm] Book book)
        {
            book.Author = await _context.Authors.Where(x => x.FirstName == book.Author.FirstName).FirstOrDefaultAsync();
            book.AuthorId = await _context.Authors.Where(x => x.FirstName == book.Author.FirstName).Select(x => x.Id).FirstOrDefaultAsync();
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Created("", book);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            Book book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound(new Error { Message = $"Book with id: {id} does not exist." });
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
    }
}
