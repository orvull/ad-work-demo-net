using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesTaxRate", Schema = "Sales")]
public class SalesTaxRate
{
    [Key]
    public int SalesTaxRateId { get; set; }

    public int StateProvinceId { get; set; }

    public byte TaxType { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    public decimal TaxRate { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
