using Library.Data;
using Library.Infrastructure;
using Library.Models;
using Library.Models.Roles;
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
    public class RolesController : Controller
    {
        private readonly RoleManager<RoleModel> _roleManager;

        public RolesController(RoleManager<RoleModel> roleManager) => _roleManager = roleManager;

        [HttpGet]
        [CustomAuthorize(Constants.Permissions.Roles.Search)]
        public async Task<IActionResult> GetRoles()
        {
            List<RoleModel> roles = await _roleManager.Roles.ToListAsync();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        [CustomAuthorize(Constants.Permissions.Roles.Search)]
        public async Task<IActionResult> GetRole(Guid id)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));
            return Ok(role);
        }

        [HttpPost]
        [CustomAuthorize(Constants.Permissions.Roles.Add)]
        public async Task<IActionResult> AddRole(AddRoleModel model)
        {
            RoleModel role = await _roleManager.FindByNameAsync(model.Name);
            if (role == null)
            {
                role = new RoleModel(model.Name, model.Description);
                await _roleManager.CreateAsync(role);
                return Ok(role);
            }
            return BadRequest(new ErrorModel($"Role {role.Name} already exists."));
        }

        [HttpDelete("{id}")]
        [CustomAuthorize(Constants.Permissions.Roles.Delete)]
        public async Task<IActionResult> DeleteRole(Guid id)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));
            await _roleManager.DeleteAsync(role);
            return Ok(role);
        }
    }
}
