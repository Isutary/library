using Library.Data;
using Library.Models;
using Library.Models.Identity;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<UserModel> _userManager;
        public SeedController(LibraryDbContext context, SeedData seedData, UserManager<UserModel> userManager) 
            => (_context, _seedData, _userManager) = (context, seedData, userManager);

        [HttpPost("authors")]
        public async Task<IActionResult> SeedAuthors()
        {
            if (_context.Authors.Any()) return Ok(new ErrorModel { Message = "Authors already seeded." });
            try
            {
                List<AuthorModel> authors = _seedData.Authors();
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
            List<AuthorModel> authors = await _context.Authors.Include(x => x.Books).ToListAsync();
            _context.Authors.RemoveRange(authors);
            await _context.SaveChangesAsync();
            return Ok(authors);
        }

        [HttpPost("books")]
        public async Task<IActionResult> SeedBooks()
        {
            if (_context.Books.Any()) return Ok(new ErrorModel { Message = "Books already seeded." });
            try
            {
                List<BookModel> books = _seedData.Books();
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
            List<BookModel> books = await _context.Books.Include(x => x.Author).ToListAsync();
            _context.Books.RemoveRange(books);
            await _context.SaveChangesAsync();
            return Ok(books);
        }

        [HttpPost("users")]
        public async Task<IActionResult> SeedUsers()
        {
            if (_userManager.Users.Any()) return Ok(new ErrorModel { Message = "Users already seeded." });
            List<UserModel> users = _seedData.Users();
            foreach (UserModel user in users) await _userManager.CreateAsync(user, "bibili00");
            return Created("", users);
        }

        [HttpDelete("users")]
        public async Task<IActionResult> DeleteUsers()
        {
            List<UserModel> users = await _userManager.Users.ToListAsync();
            foreach (UserModel user in users) await _userManager.DeleteAsync(user);
            return Ok(users);
        }
    }
}
