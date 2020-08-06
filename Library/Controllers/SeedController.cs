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
    public class SeedController : Controller
    {
        private readonly LibraryDbContext _context;
        private readonly SeedData _seedData;
        public SeedController(LibraryDbContext context, SeedData seedData) => (_context, _seedData) = (context, seedData);

        [HttpPost("authors")]
        public async Task<IActionResult> SeedAuthors()
        {
            if (_context.Authors.Any()) return Ok(new Error { Message = "Authors already seeded." });
            try
            {
                List<Author> authors = _seedData.Authors();
                _context.Authors.AddRange(authors);
                await _context.SaveChangesAsync();
                return Created("", authors);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpDelete("authors")]
        public async Task<IActionResult> DeleteAuthors()
        {
            List<Author> authors = await _context.Authors.Include(x => x.Books).ToListAsync();
            _context.Authors.RemoveRange(authors);
            await _context.SaveChangesAsync();
            return Ok(authors);
        }

        [HttpPost("books")]
        public async Task<IActionResult> SeedBooks()
        {
            if (_context.Books.Any()) return Ok(new Error { Message = "Books already seeded." });
            try
            {
                List<Book> books = _seedData.Books();
                _context.Books.AddRange(books);
                await _context.SaveChangesAsync();
                return Created("", books);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        [HttpDelete("books")]
        public async Task<IActionResult> DeleteBooks()
        {
            List<Book> books = await _context.Books.Include(x => x.Author).ToListAsync();
            _context.Books.RemoveRange(books);
            await _context.SaveChangesAsync();
            return Ok(books);
        }
    }
}
