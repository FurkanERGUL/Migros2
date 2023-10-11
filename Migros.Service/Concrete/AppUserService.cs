using Microsoft.AspNetCore.Identity;
using Migros.DAL.Abstract;
using Migros.DATA.Concrete;
using Migros.Service.Abstract;
using Migros.Service.DTOs.UserDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migros.Service.Concrete
{
    public class AppUserService : BaseService<AppUser>, IAppUserService
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        //private readonly RoleManager<IdentityRole> roleManager;
        public AppUserService(IBaseRepo<AppUser> repo) : base(repo)
        {
        }

        public async Task<bool> Login(LoginUserDTO userDTO)
        {
            AppUser appUser = await userManager.FindByNameAsync(userDTO.UserName);
            if (appUser != null)
            {
                var result = await signInManager.PasswordSignInAsync(appUser, userDTO.Password, true, false);
                if (result.Succeeded)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<bool> Register(CreateUserDTO userDTO)
        {
            AppUser appUser = new AppUser()
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                UserName = userDTO.UserName,

            };
            var result = await userManager.CreateAsync(appUser, userDTO.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
