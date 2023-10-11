using AutoMapper;
using Migros.DATA.Concrete;
using Migros.Service.DTOs.UserDTOs;
namespace Migros.Service.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<CreateUserDTO, AppUser>().ReverseMap();
            CreateMap<LoginUserDTO, AppUser>().ReverseMap();
        }
        
    }
}
