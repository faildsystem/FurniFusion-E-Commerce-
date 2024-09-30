using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class Shipping
{
    public int ShippingId { get; set; }

    public string? ShippingMethod { get; set; }

    public decimal? ShippingCost { get; set; }

    public DateOnly? ShippingDate { get; set; }

    public DateOnly? EstimatedDeliveryDate { get; set; }

    public string? ShippingStatus { get; set; }

    public int? CarrierId { get; set; }

    public virtual Carrier? Carrier { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
