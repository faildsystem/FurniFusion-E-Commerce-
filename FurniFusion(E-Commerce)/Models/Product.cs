using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? CreatorId { get; set; }

    public string? ProductName { get; set; }

    public List<string>? ImageUrls { get; set; }

    public string? Dimensions { get; set; }

    public decimal? Weight { get; set; }

    public string? Color { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? StockQuantity { get; set; }

    public bool? IsAvailable { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? DiscountId { get; set; }

    public int? CategoryId { get; set; }

    public string? Reviews { get; set; }

    public virtual Category? Category { get; set; }

    public virtual User? Creator { get; set; }

    public virtual Discount? Discount { get; set; }

    public virtual ICollection<InventoryProduct> InventoryProducts { get; set; } = new List<InventoryProduct>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
