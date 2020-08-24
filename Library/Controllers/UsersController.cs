using AutoMapper;
using Library.Data;
using Library.Infrastructure;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
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
        private readonly RoleManager<RoleModel> _roleManager;

        public UsersController(UserManager<UserModel> userManager, RoleManager<RoleModel> roleManager, IMapper mapper) : base(mapper)
            => (_userManager, _roleManager) = (userManager, roleManager);

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

        [HttpGet("{id}/roles")]
        [CustomAuthorize(Constants.Permissions.Users.Edit)]
        public async Task<IActionResult> GetRoles(Guid id)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {id} does not exist."));

            var roles = await _userManager.GetRolesAsync(user);

            return Ok(new { Roles = roles });
        }

        [HttpPost("{id}/roles")]
        [CustomAuthorize(Constants.Permissions.Users.Edit)]
        public async Task<IActionResult> AddRole(Guid id, IdWrapper model)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {id} does not exist."));

            RoleModel role = await _roleManager.FindByIdAsync(model.Id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {model.Id} does not exist."));

            IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
            if (result.Succeeded) return Ok(new { email = user.Email, userId = id, role = role.Name, roleId = model.Id });
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpDelete("{id}/roles")]
        [CustomAuthorize(Constants.Permissions.Users.Edit)]
        public async Task<IActionResult> RemoveRole(Guid id, IdWrapper model)
        {
            UserModel user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {id} does not exist."));

            RoleModel role = await _roleManager.FindByIdAsync(model.Id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {model.Id} does not exist."));

            IdentityResult result = await _userManager.RemoveFromRoleAsync(user, role.Name);
            if (result.Succeeded) return Ok(new { email = user.Email, userId = id, role = role.Name, roleId = model.Id });
            else return BadRequest(GetErrors(result.Errors));
        }
    }
}