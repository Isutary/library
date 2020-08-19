using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Library.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAuthorize : AuthorizeAttribute, IAuthorizationFilter
    {
        private readonly string[] _permissions;
        private readonly string _authenticationSchemes = "Bearer";

        public CustomAuthorize(params string[] permissions) 
            => (_permissions, this.AuthenticationSchemes) = (permissions, _authenticationSchemes); 

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var clientClaim = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "prm");

            if (clientClaim != null && _permissions.Any(x => clientClaim.Value.Contains(x))) return;

            context.Result = new UnauthorizedResult();
        }
    }
}
