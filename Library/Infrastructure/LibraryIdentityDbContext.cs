using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Infrastructure
{
    public class LibraryIdentityDbContext : IdentityDbContext<UserModel, RoleModel, string>
    {
        public LibraryIdentityDbContext(DbContextOptions<LibraryIdentityDbContext> options) : base(options) { }

        public DbSet<PermissionModel> Permissions { get; set; }
        public DbSet<AspNetRolePermission> AspNetRolePermissions { get; set; }
    }
}
