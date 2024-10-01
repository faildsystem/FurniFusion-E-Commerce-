using System;
using System.Collections.Generic;

namespace FurniFusion_E_Commerce_.Models;

public partial class Inventory
{
    public int InventoryId { get; set; }

    public string? WarehouseLocation { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<InventoryProduct> InventoryProducts { get; set; } = new List<InventoryProduct>();
}
