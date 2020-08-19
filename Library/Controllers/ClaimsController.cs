using Library.Data;
using Library.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : Controller
    {
        [HttpGet]
        [CustomAuthorize(Constants.Permissions.Authors.Add)]
        public IActionResult Index()
        {
            return Ok("works");
        }
    }
}
