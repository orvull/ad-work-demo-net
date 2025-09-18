using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesTerritory", Schema = "Sales")]
public class SalesTerritory
{
    [Key]
    public int TerritoryId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(3)]
    public string CountryRegionCode { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Group { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal SalesYtd { get; set; }

    [Column(TypeName = "money")]
    public decimal SalesLastYear { get; set; }

    [Column(TypeName = "money")]
    public decimal CostYtd { get; set; }

    [Column(TypeName = "money")]
    public decimal CostLastYear { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
