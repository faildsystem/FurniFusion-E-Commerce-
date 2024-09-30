using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class UserPaymentInfo
{
    public int PaymentInfoId { get; set; }

    public string? UserId { get; set; }

    public string? CardNumber { get; set; }

    public string? CardType { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? BillingAddress { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User? User { get; set; }
}
