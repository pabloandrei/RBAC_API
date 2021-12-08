using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class RegisterRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Role  { get; set; }

        [Required]
        public string Permissions { get; set; }
    }
}