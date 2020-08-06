using Library.Data;
using Library.Models;
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
    public class AuthorsController : Controller
    {
        private readonly LibraryDbContext _context;

        public AuthorsController(LibraryDbContext context) => _context = context;

        [HttpGet]
        public async Task<IActionResult> GetAuthors()
        {
            List<Author> authors = await _context.Authors.Include(x => x.Books).ToListAsync();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            Author author = await _context.Authors.Where(x => x.Id == id).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new Error { Message = $"Author with id: {id} does not exist." });
            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthor([FromForm] Author author)
        {
            if (await _context.Authors.Where(x => x.FirstName == author.FirstName && x.LastName == author.LastName).FirstOrDefaultAsync() != null)
                return BadRequest(new Error { Message = $"Author {author.FirstName} {author.LastName} already exists." });
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return Created("", author);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            Author author = await _context.Authors.Where(x => x.Id == id).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new Error { Message = $"Author with id: {id} does not exist." });
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }
    }
}
