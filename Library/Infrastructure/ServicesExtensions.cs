using FluentEmail.Core;
using FluentEmail.Smtp;
using Library.Infrastructure.Mail;
using Library.Models.Mail;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Net.Mail;
using System.Text;

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

        public static AuthenticationBuilder AddJwtBearerWithSettings(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration.GetValue<string>("Jwt:Issuer"),
                        ValidAudience = configuration.GetValue<string>("Jwt:Issuer"),
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration.GetValue<string>("Jwt:Key")))
                    };
                });
        }

        public static IServiceCollection AddEmailService(this IServiceCollection services, IConfiguration configuration)
        {
            EmailSettings emailSettings = configuration.GetSection("EmailSettings").Get<EmailSettings>();
            if (emailSettings == null) throw new Exception("Invalid EmailSettings.");

            //services.AddFluentEmail(emailSettings.Sender);
            Email.DefaultSender = new SmtpSender(new SmtpClient
            {
                Host = emailSettings.MailServer,
                Port = emailSettings.MailPort
            });

            services.AddScoped<IEmailService>(provider => new FluentEmailService(emailSettings));

            return services;
        }
    }
}
