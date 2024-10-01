using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.SuperAdmin
{
    public class CreateOrDeleteRoleDto
    {
        [Required]
        public string? RoleName { get; set; }
    }
}