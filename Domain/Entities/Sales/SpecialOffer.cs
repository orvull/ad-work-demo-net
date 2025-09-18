using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SpecialOffer", Schema = "Sales")]
public class SpecialOffer
{
    [Key]
    public int SpecialOfferId { get; set; }

    [Required]
    [StringLength(255)]
    public string Description { get; set; } = null!;

    [Column(TypeName = "decimal(10, 4)")]
    public decimal DiscountPct { get; set; }

    [Required]
    [StringLength(50)]
    public string Type { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Category { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int MinQty { get; set; }

    public int? MaxQty { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
