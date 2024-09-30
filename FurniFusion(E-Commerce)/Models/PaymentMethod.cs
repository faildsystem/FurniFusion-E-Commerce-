using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class PaymentMethod
{
    public int MethodId { get; set; }

    public string? MethodName { get; set; }

    public bool? IsActive { get; set; }
}
