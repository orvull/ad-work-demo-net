using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesPerson", Schema = "Sales")]
public class SalesPerson
{
    [Key]
    public int BusinessEntityId { get; set; }

    public int? TerritoryId { get; set; }

    [Column(TypeName = "money")]
    public decimal? SalesQuota { get; set; }

    [Column(TypeName = "money")]
    public decimal Bonus { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal CommissionPct { get; set; }

    [Column(TypeName = "money")]
    public decimal SalesYtd { get; set; }

    [Column(TypeName = "money")]
    public decimal SalesLastYear { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
