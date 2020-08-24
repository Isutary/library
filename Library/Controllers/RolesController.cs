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
using System.Linq;
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

        [HttpGet("{id}/permissions")]
        [CustomAuthorize(Constants.Permissions.Roles.Edit)]
        public async Task<IActionResult> GetPermissions(Guid id)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));

            List<PermissionModel> permissions = await _identity.AspNetRolePermissions
                .Where(x => x.RoleId == id)
                .Select(x => x.Permission)
                .ToListAsync();

            return Ok(new { Permissions = permissions });
        }

        [HttpPost("{id}/permissions")]
        [CustomAuthorize(Constants.Permissions.Roles.Edit)]
        public async Task<IActionResult> AddPermission(Guid id, IdWrapper model)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));

            PermissionModel permission = await _identity.Permissions.FindAsync(model.Id);
            if (permission == null) return NotFound(new ErrorModel($"Permission with id: {model.Id} does not exist."));

            AspNetRolePermission rolePermission = await _identity.AspNetRolePermissions.FindAsync(id, model.Id);
            if (rolePermission != null) return BadRequest(new ErrorModel($"Role with id: {id} already has permission with id: {model.Id}."));
            
            await _identity.AspNetRolePermissions.AddAsync(new AspNetRolePermission { RoleId = id, PermissionId = model.Id});
            await _identity.SaveChangesAsync();

            rolePermission = await _identity.AspNetRolePermissions.FindAsync(id, model.Id);
            return Ok(rolePermission);
        }

        [HttpDelete("{id}/permissions")]
        [CustomAuthorize(Constants.Permissions.Roles.Edit)]
        public async Task<IActionResult> RemovePermission(Guid id, IdWrapper model)
        {
            RoleModel role = await _roleManager.FindByIdAsync(id.ToString());
            if (role == null) return NotFound(new ErrorModel($"Role with id: {id} does not exist."));

            PermissionModel permission = await _identity.Permissions.FindAsync(model.Id);
            if (permission == null) return NotFound(new ErrorModel($"Permission with id: {model.Id} does not exist."));

            AspNetRolePermission rolePermission = await _identity.AspNetRolePermissions.FindAsync(id, model.Id);
            if (rolePermission == null) return BadRequest(new ErrorModel($"Role with id: {id} does not have permission with id: {model.Id}."));

            rolePermission = await _identity.AspNetRolePermissions.FindAsync(id, model.Id);
            _identity.AspNetRolePermissions.Remove(rolePermission);
            await _identity.SaveChangesAsync();

            return Ok(rolePermission);
        }
    }
}