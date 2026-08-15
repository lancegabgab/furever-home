using FureverHome.Models;
using FureverHome.Services;
using FureverHome.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FureverHome.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly AccountService _accountService;

        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }
        public async Task<IActionResult> Index()
        {
            var account = await _accountService.GetAccountAsync();
            return View(account);
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            Response response = await _accountService.RegisterAsync(model);
            return Json(response);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new Response
                {
                    Success = false,
                    Message = "Please fill in all required fields."
                });
            }
            Response response = await _accountService.LoginAsync(model);
            return Json(response);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            var response = await _accountService.LogoutAsync();
            return Json(response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
