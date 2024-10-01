using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.Auth
{
    public class ConfirmEmailDto
    {
        [Required]
        public string? UserId { get; set; }

        [Required]
        public string? Token { get; set; }
    }
}
