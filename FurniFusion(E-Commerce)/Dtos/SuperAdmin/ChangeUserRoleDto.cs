using FurniFusion_E_Commerce_.Enums;
using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.SuperAdmin
{
    public class ChangeUserRoleDto
    {
        [Required]
        [EmailAddress]
        public string? UserEmail { get; set; }

        [Required]
        public string? RoleName { get; set; }
    }
}