using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.ProductManager
{
    public class UpdateCategoryDto 
    {
        [Required]
        public int? CategoryId { get; set; }

        [Required]
        public string? NewCategoryName { get; set; }
    }
}
