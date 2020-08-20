using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;

namespace Library.Infrastructure
{
    public class BaseController : Controller
    {
        protected readonly IMapper _mapper;

        public BaseController(IMapper mapper) => (_mapper) = (mapper);

        protected ModelStateDictionary GetErrors(IEnumerable<IdentityError> errors)
        {
            foreach (IdentityError error in errors)
                ModelState.AddModelError("errors", error.Description);
            return ModelState;
        }
    }
}
