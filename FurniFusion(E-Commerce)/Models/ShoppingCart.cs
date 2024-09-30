using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class ShoppingCart
{
    public int CartId { get; set; }

    public string? UserId { get; set; }

    public string? CartItems { get; set; }

    public virtual User? User { get; set; }
}
