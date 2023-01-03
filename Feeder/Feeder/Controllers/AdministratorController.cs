using BussinesLayer.Dtos;
using BussinesLayer.Interfaces;
using Feeder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Feeder.Controllers
{
    public class AdministratorController : Controller
    {
        private readonly IAdministratorService _administratorService;

        public AdministratorController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }

        [HttpGet]
        public async Task<IActionResult> UserRegister()
        {
            return View();
        }

        [HttpPost]
        public async Task<RedirectToRouteResult> UserRegister(UserViewModel user)
        {
            await _administratorService.UserRegister(new UserRequestDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
            });

            return RedirectToRoute("default");
        }
    }
}
