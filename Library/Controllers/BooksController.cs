using Library.Data;
using Library.Models;
using Library.Models.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
            List<BookModel> books = await _context.Books.Include(x => x.Author).ToListAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(Guid id)
        {
            BookModel book = await _context.Books.Where(x => x.Id == id).Include(x => x.Author).FirstOrDefaultAsync();
            if (book == null) return NotFound(new ErrorModel($"Book with id: {id} does not exist."));
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook([FromForm] AddBookModel model)
        {
            if (ModelState.IsValid)
            {
                AuthorModel author = await _context.Authors.Where(x => x.Id == model.AuthorId).Include(x => x.Books).FirstOrDefaultAsync();
                if (author != null)
                {
                    BookModel book = author.Books.Where(x => x.Name == model.Name).FirstOrDefault();
                    if (book != null) return BadRequest(new ErrorModel($"Book {model.Name}, written by {author.FirstName} {author.LastName}, already exists."));
                    book = new BookModel
                    {
                        Name = model.Name,
                        AuthorId = model.AuthorId,
                        Published = model.Published
                    };
                    await _context.Books.AddAsync(book);
                    await _context.SaveChangesAsync();
                    return Created("", book);
                }
                return BadRequest(new ErrorModel($"Author with id: {model.AuthorId} does not exist."));
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            BookModel book = await _context.Books.FindAsync(id);
            if (book == null) return NotFound(new ErrorModel($"Book with id: {id} does not exist."));
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return Ok(book);
        }
    }
}
