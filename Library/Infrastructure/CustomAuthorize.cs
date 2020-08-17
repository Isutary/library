using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Text;
using IdentityModel.AspNetCore.OAuth2Introspection;
using Library.Data;
using Library.Models.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace Library.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAuthorize : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string[] _permissions;

        public CustomAuthorize(string authenticationSchemes = "Bearer", params string[] permissions) 
            => (_permissions, this.AuthenticationSchemes) = (permissions, authenticationSchemes); 

        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            //context.Result = new UnauthorizedResult();
            var a = await context.HttpContext.GetTokenAsync("Authorization");
            context.HttpContext.Response.Headers.Add("auth", a);
        }
    }
}
