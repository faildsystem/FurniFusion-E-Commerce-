using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public DateOnly? Date { get; set; }

    public int? PaymentMethod { get; set; }

    public string? TransactionId { get; set; }

    public string? UserId { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual User? User { get; set; }
}
