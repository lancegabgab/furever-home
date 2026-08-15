namespace FureverHome.ViewModels
{
    public class AccountViewModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? ContactNumber { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}
