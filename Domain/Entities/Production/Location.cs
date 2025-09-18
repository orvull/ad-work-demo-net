using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("Location", Schema = "Production")]
public class Location
{
    [Key]
    public short LocationId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(10, 4)")]
    public decimal CostRate { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal Availability { get; set; }

    public DateTime ModifiedDate { get; set; }
}
