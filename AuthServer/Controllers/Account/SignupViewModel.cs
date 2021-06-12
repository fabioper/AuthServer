using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AuthServer.Controllers.Account
{
    public class SignupViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}