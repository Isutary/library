using AutoMapper;
using Library.Models.Identity;
using Library.Models.Users;

namespace Library.Infrastructure.Configuration.AutoMapper
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<EditUserModel, UserModel>()
                .ForMember(x => x.UserName, x => x.MapFrom(y => y.Name));
            CreateMap<AddUserModel, UserModel>()
                .ForMember(x => x.UserName, x => x.MapFrom(y => y.Name));
        }
    }
}