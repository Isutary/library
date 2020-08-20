using AutoMapper;
using Library.Models;
using Library.Models.Authors;

namespace Library.Infrastructure.Configuration.AutoMapper
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<AddAuthorModel, AuthorModel>();
        }
    }
}
