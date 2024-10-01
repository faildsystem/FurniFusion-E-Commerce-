namespace FurniFusion_E_Commerce_.Models;

public partial class Discount
{
    public int DiscountId { get; set; }

    public string? DiscountCode { get; set; }

    public decimal? DiscountValue { get; set; }

    public string? DiscountUnit { get; set; }

    public DateOnly? ValidFrom { get; set; }

    public DateOnly? ValidTo { get; set; }

    public bool? IsActive { get; set; }

    public decimal? MaxAmount { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? CreatorId { get; set; }

    public virtual User? Creator { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
