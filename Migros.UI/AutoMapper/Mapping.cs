using AutoMapper;
using Migros.Service.DTOs.UserDTOs;
using Migros.UI.Models.VMs.UserVMs;

namespace Migros.UI.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            CreateMap<CreateUserVM, CreateUserDTO>().ReverseMap();
            CreateMap<LoginUserVM, LoginUserDTO>().ReverseMap();
        }

    }
}
