using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class Wishlist
{
    public int WishlistId { get; set; }

    public string? UserId { get; set; }

    public List<int>? ProductIds { get; set; }

    public virtual User? User { get; set; }
}
