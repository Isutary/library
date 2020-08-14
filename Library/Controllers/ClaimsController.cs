using Library.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var token = Request.Query["access_token"].ToString();
            if (Validate(token))
            {
                return Ok(GetClaims(token, "id"));
            }
            return NotFound("no such claim");
        }

        


    }
}
