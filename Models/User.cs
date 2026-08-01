using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using FureverHome.Enums;

namespace FureverHome.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? MiddleName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;

        public UserRole Role { get; set; } = UserRole.Adopter;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}