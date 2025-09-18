using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("BillOfMaterials", Schema = "Production")]
public class BillOfMaterial
{
    [Key]
    public int BillOfMaterialsId { get; set; }

    public int? ProductAssemblyId { get; set; }

    public int ComponentId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [StringLength(3)]
    public string UnitMeasureCode { get; set; } = null!;

    public short BomLevel { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal PerAssemblyQty { get; set; }

    public DateTime ModifiedDate { get; set; }
}
