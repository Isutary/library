using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : Controller
    {
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(User?.Claims);
        }
    }
}
