using System.ComponentModel.DataAnnotations;

namespace furever_home.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string? MiddleInitial { get; set; }
        public string LastName { get; set; } = String.Empty;
        [Phone]
        public string ContactNo {  get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public bool IsAdmin { get; set; }
        public string Address { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
