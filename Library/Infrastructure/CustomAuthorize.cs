using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace Library.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAuthorize : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context) 
        {
            context.HttpContext.Response.Headers.Add("authToken", "ne radi");
            return;
            //var query = context.HttpContext.Request.Query["access_token"].ToString();
            //var handler = new JwtSecurityTokenHandler();
            //var token = handler.ReadJwtToken(query);
            //var id = token.Claims.Where(x => x.Type == "id").FirstOrDefault();
            //if (id.Value == "f96c9593-e3f2-4aa2-98dd-0f957930d089") return;
            //context.Result = new ForbidResult(AuthenticationScheme);
        }
        private string GetClaims(string token, string claimType)
        {
            var handler = new JwtSecurityTokenHandler();
            var securityToken = handler.ReadJwtToken(token);
            string stringClaimValue = securityToken.Claims.First(x => x.Type == claimType).Value;
            return stringClaimValue;
        }

        private bool Validate(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("3IEU8hFHCDyy7g9SN0KpMUqZxiPwgp0x"));
            try
            {
                handler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "https://localhost:44316/",
                    ValidAudience = "https://localhost:44316/",
                    IssuerSigningKey = key
                }, out SecurityToken validated);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
