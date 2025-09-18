using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Purchasing;

[Table("ProductVendor", Schema = "Purchasing")]
[PrimaryKey(nameof(ProductId), nameof(BusinessEntityId))]
public class ProductVendor
{
    public int ProductId { get; set; }

    public int BusinessEntityId { get; set; }

    public int AverageLeadTime { get; set; }

    [Column(TypeName = "money")]
    public decimal StandardPrice { get; set; }

    [Column(TypeName = "money")]
    public decimal? LastReceiptCost { get; set; }

    public DateTime? LastReceiptDate { get; set; }

    public int MinOrderQty { get; set; }

    public int MaxOrderQty { get; set; }

    public int? OnOrderQty { get; set; }

    [StringLength(3)]
    public string UnitMeasureCode { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
