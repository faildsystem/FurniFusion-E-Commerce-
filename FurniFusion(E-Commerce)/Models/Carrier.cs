using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class Carrier
{
    public int CarrierId { get; set; }

    public string? CarrierName { get; set; }

    public string? CarrierContact { get; set; }

    public virtual ICollection<Shipping> Shippings { get; set; } = new List<Shipping>();
}
