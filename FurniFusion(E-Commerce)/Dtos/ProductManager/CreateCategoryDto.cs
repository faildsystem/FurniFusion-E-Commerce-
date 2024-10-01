using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.ProductManager
{
    public class CreateCategoryDto
    {
        [Required]
        public string? CategoryName { get; set; }
    }
}