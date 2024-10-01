using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.Auth
{
    public class SendEmailVerificationDto
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

    }
}
