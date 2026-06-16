using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FureverHome.Enums;

namespace FureverHome.Models
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public PetType PetType { get; set; }
        [Required]
        public PetGender Gender { get; set; }

        public int ShelterId { get; set; }

        [ForeignKey("ShelterId")]
        public Shelter Shelter { get; set; } = null!;

        [Required]
        public PetStatus Status { get; set; } = PetStatus.Available;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}