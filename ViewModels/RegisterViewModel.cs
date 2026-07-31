using System.ComponentModel.DataAnnotations;

namespace FureverHome.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }
        
        [Required(ErrorMessage = "Please enter your last name.")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Please enter your contact number.")]
        [Phone(ErrorMessage = "Please enter a valid phone number.")]
        public required string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
