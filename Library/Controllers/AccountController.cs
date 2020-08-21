using AutoMapper;
using Library.Infrastructure;
using Library.Infrastructure.Context;
using Library.Infrastructure.Mail;
using Library.Models;
using Library.Models.Identity;
using Library.Models.Mail;
using Library.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
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
    public class AccountController : BaseController
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly IConfiguration _configuration;
        private readonly LibraryIdentityDbContext _identity;
        private readonly IEmailService _emailService;

        public AccountController(
            UserManager<UserModel> userManager,
            IConfiguration configuration,
            LibraryIdentityDbContext identity,
            IEmailService emailService,
            IMapper mapper
            ) : base(mapper)
            => (_userManager, _configuration, _identity, _emailService) = (userManager, configuration, identity, emailService);

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            UserModel user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null) return NotFound(new ErrorModel($"User with email: {model.Email} does not exist"));
            if (!await _userManager.CheckPasswordAsync(user, model.Password)) return Unauthorized(new ErrorModel("Incorrect password."));

            var rolesNames = await _userManager.GetRolesAsync(user);
            var permissions = await _identity.AspNetRolePermissions
                .Include(x => x.Role)
                .Include(x => x.Permission)
                .Where(x => rolesNames.Contains(x.Role.Name))
                .Select(x => x.Permission.Name)
                .Distinct()
                .ToListAsync();

            var handler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Jwt:Key"));
            var token = handler.CreateJwtSecurityToken(
                issuer: _configuration.GetValue<string>("Jwt:Issuer"),
                audience: _configuration.GetValue<string>("Jwt:Issuer"),
                subject: new ClaimsIdentity(new Claim[] { new Claim("prm", StringFromList(permissions)) }),
                expires: DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                );

            return Ok(new TokenModel(handler.WriteToken(token)));
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAccount(AddUserModel model)
        {
            UserModel user = _mapper.Map<UserModel>(model);
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var EmailConfirmationUrl = Url.Page(
                    "",
                    pageHandler: null,
                    values: new { userId = user.Id, token = code },
                    protocol: Request.Scheme);

                EmailMessage emailMessage = new EmailMessage(user.Email, "Confirm email", $"<a href='{EmailConfirmationUrl}'> Click here </a>");

                await _emailService.SendEmailAsync(emailMessage);

                return Created("", user);
            }
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpGet("register")]
        public async Task<IActionResult> VerifyToken(string userId, string token)
        {
            UserModel user = await _userManager.FindByIdAsync(userId);
            IdentityResult result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded) return Accepted(user);
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpPost("recovery")]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword(EmailWrapper model)
        {
            UserModel user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null) return NotFound(new ErrorModel($"User with email: {model.Email} does not exist."));

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var EmailConfirmationUrl = Url.Page(
                "/Account",
                pageHandler: null,
                values: new { code = code },
                protocol: Request.Scheme);

            var a = _userManager.GeneratePasswordResetTokenAsync(user);

            return Ok(EmailConfirmationUrl);
        }

        private string StringFromList(List<string> list)
        {
            string str = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1) str += list[i] + ",";
                else str += list[i];
            }

            return str;
        }
    }
}
