using Library.Data;
using Library.Models;
using Library.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using Authors = Library.Data.Constants.Permissions.Authors;
using Books = Library.Data.Constants.Permissions.Books;

namespace Library.Infrastructure.Configuration.EF
{
    public class AspNetRolePermissionEntityTypeConfiguration : IEntityTypeConfiguration<AspNetRolePermission>
    {
        public void Configure(EntityTypeBuilder<AspNetRolePermission> builder)
        {
            builder.HasKey(x => new { x.RoleId, x.PermissionId });
            List<RoleModel> roles = SeedData.Roles();
            List<PermissionModel> permissions = SeedData.Permissions();

            RoleModel AdminRole = roles.FirstOrDefault(x => x.Name == Constants.Roles.Admin);
            RoleModel UserRole = roles.FirstOrDefault(x => x.Name == Constants.Roles.User);
            RoleModel GuestRole = roles.FirstOrDefault(x => x.Name == Constants.Roles.Guest);

            List<AspNetRolePermission> PermissionsForAdmin = permissions
                .Select(x => new AspNetRolePermission { PermissionId = x.Id, RoleId = AdminRole.Id }).ToList();
            List<AspNetRolePermission> PermissionsForUser = permissions
                .Where(x => x.Name == Authors.Search || x.Name == Books.Search || x.Name == Authors.Add || x.Name == Books.Add)
                .Select(x => new AspNetRolePermission { PermissionId = x.Id, RoleId = UserRole.Id }).ToList();
            List<AspNetRolePermission> PermissionsForGuest = permissions
                .Where(x => x.Name == Authors.Search || x.Name == Books.Search)
                .Select(x => new AspNetRolePermission { PermissionId = x.Id, RoleId = GuestRole.Id }).ToList();

            builder.HasData(PermissionsForAdmin);
            builder.HasData(PermissionsForUser);
            builder.HasData(PermissionsForGuest);
        }
    }
}
