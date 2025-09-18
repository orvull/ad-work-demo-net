using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Purchasing;

[Table("PurchaseOrderDetail", Schema = "Purchasing")]
[PrimaryKey(nameof(PurchaseOrderId), nameof(PurchaseOrderDetailId))]
public class PurchaseOrderDetail
{
    public int PurchaseOrderId { get; set; }

    public int PurchaseOrderDetailId { get; set; }

    public DateTime DueDate { get; set; }

    public short OrderQty { get; set; }

    public int ProductId { get; set; }

    [Column(TypeName = "money")]
    public decimal UnitPrice { get; set; }

    [Column(TypeName = "money")]
    public decimal LineTotal { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal ReceivedQty { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal RejectedQty { get; set; }

    [Column(TypeName = "decimal(9, 2)")]
    public decimal StockedQty { get; set; }

    public DateTime ModifiedDate { get; set; }
}
