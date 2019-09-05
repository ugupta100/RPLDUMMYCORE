using System.ComponentModel.DataAnnotations;

namespace HSTPL.RPL.Models.UserModels
{
    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
