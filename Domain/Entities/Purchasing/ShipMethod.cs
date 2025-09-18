using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Purchasing;

[Table("ShipMethod", Schema = "Purchasing")]
public class ShipMethod
{
    [Key]
    public int ShipMethodId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal ShipBase { get; set; }

    [Column(TypeName = "money")]
    public decimal ShipRate { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
