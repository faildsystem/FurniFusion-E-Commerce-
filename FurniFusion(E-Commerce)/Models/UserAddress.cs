using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class UserAddress
{
    public int AddressId { get; set; }

    public string? UserId { get; set; }

    public string? Country { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Street { get; set; }

    public string? PostalCode { get; set; }

    public bool? IsPrimaryAddress { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User? User { get; set; }
}
