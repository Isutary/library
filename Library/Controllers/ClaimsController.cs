using Library.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : Controller
    {
        [HttpGet]
        [CustomAuthorize]
        public IActionResult Index()
        {
            return Ok("test");
        }
    }
}
