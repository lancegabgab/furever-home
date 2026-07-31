using System.ComponentModel.DataAnnotations;

namespace FureverHome.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
