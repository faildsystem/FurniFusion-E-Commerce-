using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_
{
    public class LoginDto
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
