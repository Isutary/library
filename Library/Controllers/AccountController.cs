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
    [AllowAnonymous]
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
                subject: new ClaimsIdentity(new Claim[] { new Claim("prm", permissions.ToString<string>()) }),
                expires: DateTime.Now.AddDays(30),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                );

            return Ok(new TokenModel(handler.WriteToken(token)));
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAccount(RegisterUserModel model)
        {
            UserModel user = _mapper.Map<UserModel>(model);
            if (!model.ConfirmPassword.Equals(model.Password)) return BadRequest(new ErrorModel("Passwords must match."));

            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var EmailConfirmationUrl = Url.Page(
                    pageName: null,
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
        public async Task<IActionResult> VerifyToken(Guid userId, string token)
        {
            UserModel user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return NotFound(new ErrorModel($"User with id: {userId} does not exist."));

            IdentityResult result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded) return Accepted(user);
            else return BadRequest(GetErrors(result.Errors));
        }

        [HttpPut("password-request")]
        public async Task<IActionResult> ChangePasswordRequest(EmailWrapper model)
        {
            UserModel user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null) return NotFound(new ErrorModel($"User with email: {model.Email} does not exist."));

            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var PasswordResetUrl = Url.Page(
                pageName: null,
                pageHandler: null,
                values: new { userId = user.Id, token = code },
                protocol: Request.Scheme);

            EmailMessage emailMessage = new EmailMessage(user.Email, "Password reset", $"<a href='{PasswordResetUrl}'> Click here </a>");

            await _emailService.SendEmailAsync(emailMessage);

            return Ok(user);
        }

        [HttpGet("password-request")]
        public async Task<IActionResult> ExtractToken(Guid userId, string token)
        {
            return Ok(new { UserId = userId, Token = token });
        }

        [HttpPut("password-change")]
        public async Task<IActionResult> ChangePassword(PasswordResetModel model)
        {
            UserModel user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null) return NotFound(new ErrorModel($"User with id: {model.UserId} does not exist."));
            if (!model.ConfirmPassword.Equals(model.NewPassword)) return BadRequest(new ErrorModel("Passwords must match."));

            IdentityResult result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded) return Accepted(user);
            else return BadRequest(GetErrors(result.Errors));
        }
    }
}
