using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesReason", Schema = "Sales")]
public class SalesReason
{
    [Key]
    public int SalesReasonId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string ReasonType { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
