using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("UnitMeasure", Schema = "Production")]
public class UnitMeasure
{
    [Key]
    [StringLength(3)]
    public string UnitMeasureCode { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
