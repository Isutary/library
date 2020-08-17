using Library.Data;
using Library.Models;
using Library.Models.Authors;
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
            List<AuthorModel> authors = await _context.Authors.Include(x => x.Books).ToListAsync();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(Guid id)
        {
            AuthorModel author = await _context.Authors.Where(x => x.Id == id).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new ErrorModel($"Author with id: {id} does not exist."));
            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthor(AddAuthorModel model)
        {
            AuthorModel author = await _context.Authors.Where(x => x.FirstName == model.FirstName && x.LastName == model.LastName).FirstOrDefaultAsync();
            if (author == null)
            {
                author = new AuthorModel
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Born = model.Born,
                    Died = model.Died
                };
                await _context.Authors.AddAsync(author);
                await _context.SaveChangesAsync();
                return Created("", author);
            }
            return BadRequest(new ErrorModel($"Author {author.FirstName} {author.LastName} already exists."));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(Guid id)
        {
            AuthorModel author = await _context.Authors.Where(x => x.Id == id).Include(x => x.Books).FirstOrDefaultAsync();
            if (author == null) return NotFound(new ErrorModel($"Author with id: {id} does not exist."));
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
            return Ok(author);
        }
    }
}
