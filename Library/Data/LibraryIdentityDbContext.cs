using Library.Models.Identity;
using Library.Models.Roles;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
    public class LibraryIdentityDbContext : IdentityDbContext<UserModel, RoleModel, string>
    {
        public LibraryIdentityDbContext(DbContextOptions<LibraryIdentityDbContext> options) : base(options) { }
    }
}
