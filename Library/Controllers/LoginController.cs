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
        private readonly IConfiguration _configuration;

        public LoginController(UserManager<UserModel> userManager, IConfiguration configuration)
            => (_userManager, _configuration) = (userManager, configuration);

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var handler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Jwt:Key"));
                    var descriptor = new SecurityTokenDescriptor
                    { 
                        Issuer = _configuration.GetValue<string>("Jwt:Issuer"),
                        Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                        Expires = DateTime.UtcNow.AddMinutes(30),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = handler.CreateToken(descriptor);
                    return Ok(handler.WriteToken(token));
                }
                return NotFound(new ErrorModel($"User with email: {model.Email} does not exist"));
            }
            return BadRequest(ModelState);
        }
    }
}
