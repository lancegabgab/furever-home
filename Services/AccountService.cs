using FureverHome.Models;
using FureverHome.Enums;
using FureverHome.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FureverHome.Services
{
    public class AccountService
    {
        private readonly UserManager<User> _userManager;

        public AccountService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Response> RegisterAsync(RegisterViewModel model)
        {
            var response = new Response();

            User user = new User
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Role = UserRole.Adopter
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                response.Success = true;
                response.Message = "Registration successful.";
            }
            else
            {
                response.Success = false;
                response.Message = string.Join(
                    Environment.NewLine,
                    result.Errors.Select(e => e.Description));
            }

            return response;
        }
    }
}