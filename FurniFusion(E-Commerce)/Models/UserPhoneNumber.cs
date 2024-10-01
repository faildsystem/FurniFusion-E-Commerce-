using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class UserPhoneNumber
{
    public int PhoneId { get; set; }

    public string UserId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; } = null!;
}
