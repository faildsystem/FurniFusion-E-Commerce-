// Ignore Spelling: Username Furni Dtos Dto

using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string?  Password { get; set; }

        [Required]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
    }
}
