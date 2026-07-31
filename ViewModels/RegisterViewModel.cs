using System.ComponentModel.DataAnnotations;

namespace FureverHome.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }
        
        [Required]
        public required string LastName { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [Phone]
        public required string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
