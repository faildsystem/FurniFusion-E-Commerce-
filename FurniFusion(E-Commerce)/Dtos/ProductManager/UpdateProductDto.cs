﻿using System.ComponentModel.DataAnnotations;

namespace FurniFusion_E_Commerce_.Dtos.ProductManager
{
    public class UpdateProductDto
    {
        [Required]
        public int? ProductId { get; set; }

        public string? ProductName { get; set; }

        public List<string>? ImageUrls { get; set; }

        public string? Dimensions { get; set; }

        public decimal? Weight { get; set; }

        public string? Color { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int? StockQuantity { get; set; }

        public bool? IsAvailable { get; set; }

        public int? CategoryId { get; set; }
    }
}
