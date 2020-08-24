using Library.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class JwtTokenProvider<TUser> : IUserTwoFactorTokenProvider<TUser> where TUser : IdentityUser<Guid>
    {
        private readonly byte[] _key;

        public JwtTokenProvider(IConfiguration configuration)
        {
            _key = Encoding.ASCII.GetBytes(configuration.GetValue<string>("Jwt:Key"));
        }

        public async Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<TUser> manager, TUser user)
        {
            return false;
        }

        public async Task<string> GenerateAsync(string purpose, UserManager<TUser> manager, TUser user)
        {
            var handler = new JwtSecurityTokenHandler();
            var token = handler.CreateJwtSecurityToken(
                issuer: nameof(JwtTokenProvider<UserModel>),
                audience: purpose,
                subject: new ClaimsIdentity(new Claim[] { new Claim("email", user.Email) }),
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(_key), SecurityAlgorithms.HmacSha256Signature)
                );

            return handler.WriteToken(token);
        }

        public async Task<bool> ValidateAsync(string purpose, string token, UserManager<TUser> manager, TUser user)
        {
            var handler = new JwtSecurityTokenHandler();
            var options = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = nameof(JwtTokenProvider<UserModel>),
                ValidAudience = purpose,
                IssuerSigningKey = new SymmetricSecurityKey(_key)
            };

            try
            {
                handler.ValidateToken(token, options, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }

            string userEmail = handler.ReadJwtToken(token).Claims.FirstOrDefault(x => x.Type == "email").Value;

            if (userEmail == user.Email) return true;
            else return false;
        }
    }
}
