using FureverHome.Models;
using FureverHome.Enums;
using FureverHome.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace FureverHome.Services
{
    public class AccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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

        public async Task<Response> LoginAsync(LoginViewModel model)
        {
            Response response = new();

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                response.Success = false;
                response.Message = "Invalid email or password.";
                return response;
            }

            var result = await _signInManager.PasswordSignInAsync(
                user,
                model.Password,
                isPersistent: false,
                lockoutOnFailure: false);

            if (!result.Succeeded)
            {
                response.Success = false;
                response.Message = "Invalid email or password.";
                return response;
            }

            response.Success = true;
            response.Message = "Login successful!";

            return response;
        }

        public async Task<Response> LogoutAsync()
        {
            await _signInManager.SignOutAsync();

            return new Response
            {
                Success = true,
                Message = "Logout successful."
            };
        }
    }
}