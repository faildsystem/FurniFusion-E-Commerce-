// Ignore Spelling: Wishlists

using Microsoft.AspNetCore.Identity;


namespace FurniFusion_E_Commerce_.Models;

public partial class User: IdentityUser
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Category> CategoryCreatedByNavigations { get; set; } = new List<Category>();

    public virtual ICollection<Category> CategoryUpdatedByNavigations { get; set; } = new List<Category>();

    public virtual ICollection<Discount> Discounts { get; set; } = new List<Discount>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    public virtual ICollection<UserAddress> UserAddresses { get; set; } = new List<UserAddress>();

    public virtual ICollection<UserPaymentInfo> UserPaymentInfos { get; set; } = new List<UserPaymentInfo>();

    public virtual ICollection<UserPhoneNumber> UserPhoneNumbers { get; set; } = new List<UserPhoneNumber>();

    public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
}
