using Library.Data;
using Library.Infrastructure;
using Library.Models;
using Library.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserManager<UserModel> _userManager;

        public UsersController(UserManager<UserModel> userManager) => _userManager = userManager;

        [HttpGet]
        [CustomAuthorize(Constants.Permissions.Users.Search)]
        public async Task<IActionResult> GetUsers()
        {
            List<UserModel> users = await _userManager.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        [CustomAuthorize(Constants.Permissions.Users.Search)]
        public async Task<IActionResult> GetUser(Guid id)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {id} does not exist."));
            return Ok(user);
        }

        [HttpPost]
        [CustomAuthorize(Constants.Permissions.Users.Add)]
        public async Task<IActionResult> AddUser(AddUserModel model)
        {
            UserModel user = new UserModel
            {
                UserName = model.Name,
                Email = model.Email
            };

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded) return Created("", user);
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("errors", error.Description);
                }

                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        [CustomAuthorize(Constants.Permissions.Users.Delete)]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return Ok(user);
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("errors", error.Description);
                    }
                }
                return BadRequest(ModelState);
            }
            return NotFound(new ErrorModel($"User with id: {id} does not exist."));
        }
    }
}
