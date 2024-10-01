using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.SuperAdmin
{
    public class DeleteUserDto
    {
        [Required]
        public string? UserEmail { get; set; }
    }
}