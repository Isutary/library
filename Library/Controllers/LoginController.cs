using Library.Models;
using Library.Models.Identity;
using Library.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
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
        private readonly SignInManager<UserModel> _signInManager;
        private readonly IConfiguration _configuration;

        public LoginController(UserManager<UserModel> userManager, SignInManager<UserModel> signInManager, IConfiguration configuration)
            => (_userManager, _configuration, _signInManager) = (userManager, configuration, signInManager);

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    if (await _userManager.CheckPasswordAsync(user, model.Password))
                    {
                        var handler = new JwtSecurityTokenHandler();
                        var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Jwt:Key"));
                        var descriptor = new SecurityTokenDescriptor
                        {
                            Issuer = _configuration.GetValue<string>("Jwt:Issuer"),
                            Audience = _configuration.GetValue<string>("Jwt:Issuer"),
                            Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                            Expires = DateTime.UtcNow.AddDays(30),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                        };
                        var token = handler.CreateJwtSecurityToken(descriptor);
                        return Ok(handler.WriteToken(token));
                    }
                    return Unauthorized(new ErrorModel("Incorrect password."));
                }
                return NotFound(new ErrorModel($"User with email: {model.Email} does not exist"));
            }
            return BadRequest(ModelState);
        }
    }
}
