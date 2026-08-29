using System.ComponentModel.DataAnnotations;

namespace FureverHome.ViewModels
{
    public class RegisterShelterViewModel
    {
        [Required(ErrorMessage = "Please enter your shelter name.")]
        public required string Name { get; set; }

        public string? ImageUrl { get; set; }

		[Required(ErrorMessage = "Please enter your contact number.")]
		[MaxLength(20)]
		public required string ContactNumber { get; set; }

		[Required(ErrorMessage = "Please enter your email address.")]
		[EmailAddress(ErrorMessage = "Please enter a valid email address.")]
		[MaxLength(255)]
		public required string EmailAddress { get; set; }

		[Required(ErrorMessage = "Please enter your shelter address.")]
		[MaxLength(255)]
		public required string Address { get; set; }

		[MaxLength(2000)]
		public required string About { get; set; }
	}
}
