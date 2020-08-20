using AutoMapper;
using Library.Data;
using Library.Infrastructure;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Users;
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
    public class UsersController : BaseController
    {
        private readonly UserManager<UserModel> _userManager;

        public UsersController(UserManager<UserModel> userManager, IMapper mapper) : base(mapper) => _userManager = userManager;

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
            UserModel user = _mapper.Map<UserModel>(model);
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded) return Created("", user);
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpDelete("{id}")]
        [CustomAuthorize(Constants.Permissions.Users.Delete)]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {id} does not exist."));

            IdentityResult result = await _userManager.DeleteAsync(user);
            if (result.Succeeded) return Ok(user);
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpPut("{id}")]
        [CustomAuthorize(Constants.Permissions.Users.Edit)]
        public async Task<IActionResult> EditUser(Guid id, EditUserModel model)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {id} does not exist."));

            user = _mapper.Map(model, user);
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (result.Succeeded) return Ok(user);
            else return BadRequest(GetErrors(result.Errors));
        }
    }
}
