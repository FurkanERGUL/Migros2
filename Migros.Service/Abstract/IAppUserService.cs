using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Migros.DATA.Concrete;
using Migros.Service.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.Service.Abstract
{
    public interface IAppUserService //: IBaseService<AppUser>
    {
        //private readonly UserManager<AppUser> userManager;

        Task<bool> Register(CreateUserDTO userDTO);
        Task<bool> Login(LoginUserDTO userDTO);

    }
}
