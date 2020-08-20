using Library.Data;
using Library.Infrastructure.Configuration.EF;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Infrastructure.Context
{
    public class LibraryIdentityDbContext : IdentityDbContext<UserModel, RoleModel, Guid>
    {
        public LibraryIdentityDbContext(DbContextOptions<LibraryIdentityDbContext> options) : base(options) { }

        public DbSet<PermissionModel> Permissions { get; set; }
        public DbSet<AspNetRolePermission> AspNetRolePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserModel>().HasData(SeedData.Users());
            builder.Entity<RoleModel>().HasData(SeedData.Roles());
            builder.Entity<IdentityUserRole<Guid>>().HasData(SeedData.UserRole());
            builder.Entity<PermissionModel>().HasData(SeedData.Permissions());
            builder.ApplyConfiguration(new AspNetRolePermissionEntityTypeConfiguration());
        }
    }
}
