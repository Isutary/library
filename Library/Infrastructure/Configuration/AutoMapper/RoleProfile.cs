using AutoMapper;
using Library.Models.Roles;

namespace Library.Infrastructure.Configuration.AutoMapper
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<AddRoleModel, RoleModel>();
        }
    }
}
