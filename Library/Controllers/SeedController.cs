using Library.Data;
using Library.Infrastructure;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
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
        private readonly RoleManager<RoleModel> _roleManager;

        public SeedController(LibraryDbContext context, SeedData seedData, UserManager<UserModel> userManager, RoleManager<RoleModel> roleManager)
            => (_context, _seedData, _userManager, _roleManager) = (context, seedData, userManager, roleManager);

        [HttpPost]
        public async Task<IActionResult> SeedAll()
        {
            await SeedRoles();
            await SeedUsers();
            await SeedAuthors();
            await SeedBooks();

            return Ok(new ErrorModel("Everything seeded."));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAll()
        {
            await DeleteRoles();
            await DeleteUsers();
            await DeleteAuthors();
            await DeleteBooks();

            return Ok(new ErrorModel("Everything deleted."));
        }

        [HttpPost("authors")]
        public async Task<IActionResult> SeedAuthors()
        {
            if (_context.Authors.Any()) return Ok(new ErrorModel("Authors already seeded."));
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
            if (_context.Books.Any()) return Ok(new ErrorModel("Books already seeded."));
            try
            {
                List<BookModel> books = _seedData.Books();
                _context.Books.AddRange(books);
                await _context.SaveChangesAsync();
                return Created("", books);
            }
            catch
            {
                return BadRequest(new ErrorModel("Authors not seeded."));
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
            if (_userManager.Users.Any()) return Ok(new ErrorModel("Users already seeded."));
            List<UserModel> users = _seedData.Users();
            try
            {
                foreach (UserModel user in users)
                {
                    await _userManager.CreateAsync(user, "bibili00");
                    if (user.UserName == "Salt") await _userManager.AddToRoleAsync(user, Constants.Roles.Admin);
                    else await _userManager.AddToRoleAsync(user, Constants.Roles.User);
                }
            }
            catch
            {
                foreach (UserModel user in users) await _userManager.DeleteAsync(user);
                return BadRequest(new ErrorModel("Roles not seeded."));
            }
            return Created("", users);
        }

        [HttpDelete("users")]
        public async Task<IActionResult> DeleteUsers()
        {
            List<UserModel> users = await _userManager.Users.ToListAsync();
            foreach (UserModel user in users) await _userManager.DeleteAsync(user);
            return Ok(users);
        }

        [HttpPost("roles")]
        public async Task<IActionResult> SeedRoles()
        {
            if (_roleManager.Roles.Any()) return Ok(new ErrorModel("Roles already seeded."));
            List<RoleModel> roles = _seedData.Roles();
            foreach (RoleModel role in roles) await _roleManager.CreateAsync(role);
            return Ok(roles);
        }

        [HttpDelete("roles")]
        public async Task<IActionResult> DeleteRoles()
        {
            List<RoleModel> roles = await _roleManager.Roles.ToListAsync();
            foreach (RoleModel role in roles) await _roleManager.DeleteAsync(role);
            return Ok(roles);
        }
    }
}
