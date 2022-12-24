using BussinesLayer.Dtos;
using BussinesLayer.Interfaces;
using Feeder.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Feeder.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> AddFeeder()
        {
            return View();
        }

        [HttpPost]
        public async Task<RedirectToRouteResult> AddFeeder(FeederViewModel feeder)
        {
            await _userService.AddFeeder(feeder.UserId, new FeederRequestDto
            {
                Model = feeder.Model,
                Capacity = feeder.Capacity,
                Size = feeder.Size,
                Type = feeder.Type
            });

            return RedirectToRoute("default");
        }
    }
}
