using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Migros.Service.Abstract;
using Migros.Service.DTOs.UserDTOs;
using Migros.UI.Models.VMs.UserVMs;

namespace Migros.UI.Controllers
{
    public class AppUserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper mapper;
        public AppUserController(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(CreateUserVM userVM)
        {
            CreateUserDTO userDTO = mapper.Map<CreateUserDTO>(userVM);
            var result = await _appUserService.Register(userDTO);
            if (result)
            {
                return View("Home", "Index");
            }
            return View(userVM);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserVM userVM)
        {
            LoginUserDTO loginUserDTO = mapper.Map<LoginUserDTO>(userVM);

            var result = await _appUserService.Login(loginUserDTO); 
            
            if (result)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(loginUserDTO);
        }
    }
}
