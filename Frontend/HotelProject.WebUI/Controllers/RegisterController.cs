using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.RegisterDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
                
            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Email = createNewUserDto.Mail,
                Surname = createNewUserDto.Surname,
                UserName = createNewUserDto.Username,
                WorkLocationID = 1
            };
            var result = await _userManager.CreateAsync(appUser,createNewUserDto.Password);
            foreach (var error in result.Errors)
            {
                if (error.Code.Contains("DuplicateUserName"))
                {
                    ModelState.AddModelError("Username", error.Description);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View();
        }
    }
}
