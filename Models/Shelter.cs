using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FureverHome.Models
{
    public class Shelter
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        public string? ImageUrl { get; set; }

		[Required]
		[MaxLength(20)]
		public string ContactNumber { get; set; } = null!;

		[Required]
		[EmailAddress]
		[MaxLength(255)]
		public string EmailAddress { get; set; } = null!;

		[Required]
		[MaxLength(255)]
		public string Address { get; set; } = null!;

		public string? About { get; set; }
	}
}