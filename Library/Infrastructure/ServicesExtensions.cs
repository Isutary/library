using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Infrastructure
{
    public static class ServicesExtensions
    {
        public static IdentityBuilder AddIdentityWithSettings<TUser, TRole, TContext>(this IServiceCollection services)
            where TUser : class
            where TRole : class
            where TContext : DbContext
        {
            return services.AddIdentity<TUser, TRole>(options =>
                {
                    options.User.RequireUniqueEmail = true;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireDigit = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                })
                .AddEntityFrameworkStores<TContext>()
                .AddDefaultTokenProviders();
        }
    }
}
