using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("TransactionHistoryArchive", Schema = "Production")]
public class TransactionHistoryArchive
{
    [Key]
    public int TransactionId { get; set; }

    public int ProductId { get; set; }

    public int ReferenceOrderId { get; set; }

    public int ReferenceOrderLineId { get; set; }

    public DateTime TransactionDate { get; set; }

    [Required]
    [StringLength(1)]
    public string TransactionType { get; set; } = null!;

    public int Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal ActualCost { get; set; }

    public DateTime ModifiedDate { get; set; }
}
