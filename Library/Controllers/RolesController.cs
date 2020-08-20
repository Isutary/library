using AutoMapper;
using Library.Data;
using Library.Infrastructure;
using Library.Infrastructure.Context;
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
    public class RolesController : BaseController
    {
        private readonly RoleManager<RoleModel> _roleManager;
        private readonly LibraryIdentityDbContext _identity;

        public RolesController(RoleManager<RoleModel> roleManager, LibraryIdentityDbContext identity, IMapper mapper) : base(mapper) 
            => (_roleManager, _identity) = (roleManager, identity);

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
            RoleModel role = _mapper.Map<RoleModel>(model);
            IdentityResult result = await _roleManager.CreateAsync(role);
            if (result.Succeeded) return Created("", role);
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpDelete("{id}")]
        [CustomAuthorize(Constants.Permissions.Roles.Delete)]
        public async Task<IActionResult> DeleteRole(Guid id)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));

            IdentityResult result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded) return Ok(role);
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpPut("{id}")]
        [CustomAuthorize(Constants.Permissions.Roles.Edit)]
        public async Task<IActionResult> EditRole(Guid id, AddRoleModel model)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));

            role = _mapper.Map(model, role);
            IdentityResult result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded) return Ok(role);
            else return BadRequest(GetErrors(result.Errors));
        }
    }
}
