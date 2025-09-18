using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Purchasing;

[Table("PurchaseOrderHeader", Schema = "Purchasing")]
public class PurchaseOrderHeader
{
    [Key]
    public int PurchaseOrderId { get; set; }

    public byte RevisionNumber { get; set; }

    public byte Status { get; set; }

    public int EmployeeId { get; set; }

    public int VendorId { get; set; }

    public int ShipMethodId { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? ShipDate { get; set; }

    [Column(TypeName = "money")]
    public decimal SubTotal { get; set; }

    [Column(TypeName = "money")]
    public decimal TaxAmt { get; set; }

    [Column(TypeName = "money")]
    public decimal Freight { get; set; }

    [Column(TypeName = "money")]
    public decimal TotalDue { get; set; }

    public DateTime ModifiedDate { get; set; }
}
