using Library.Models;
using Library.Models.Identity;
using Library.Models.Roles;
using Library.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly IConfiguration _configuration;

        public LoginController(UserManager<UserModel> userManager, IConfiguration configuration)
            => (_userManager, _configuration) = (userManager, configuration);

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            UserModel user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                if (await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    List<Claim> claims = new List<Claim>();
                    IList<string> rolesNames = await _userManager.GetRolesAsync(user);
                    foreach (string role in rolesNames)
                    {
                        claims.Add(new Claim(role, "role"));
                    }
                    var handler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Jwt:Key"));
                    var token = handler.CreateJwtSecurityToken(
                        issuer: _configuration.GetValue<string>("Jwt:Issuer"),
                        audience: _configuration.GetValue<string>("Jwt:Issuer"),
                        subject: new ClaimsIdentity(claims),
                        expires: DateTime.Now.AddDays(30),
                        signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                        ); 
                    return Ok(new TokenModel(handler.WriteToken(token)));
                }
                return Unauthorized(new ErrorModel("Incorrect password."));
            }
            return NotFound(new ErrorModel($"User with email: {model.Email} does not exist"));
        }
    }
}
