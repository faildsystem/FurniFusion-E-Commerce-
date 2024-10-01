using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos
{
    public class SendResetPasswordDto
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        //[Required]
        //public string? ClientURI { get; set; }

    }
}
