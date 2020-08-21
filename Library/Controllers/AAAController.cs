using FluentEmail.Core;
using Library.Infrastructure.Mail;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AAAController : Controller
    {
        private readonly IEmailService _emailService;

        public AAAController(IEmailService emailService) => (_emailService) = (emailService);

        [HttpGet]
        public async Task<IActionResult> Test()
        {
            var email = await Email
                .From("john@email.com")
                .To("bob@email.com")
                .Subject("hows it going")
                .Body("yo bob, long time no see!")
                .SendAsync();

            return Ok(email);
        }
    }
}
