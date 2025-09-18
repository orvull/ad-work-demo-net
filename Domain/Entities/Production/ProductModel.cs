using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductModel", Schema = "Production")]
public class ProductModel
{
    [Key]
    public int ProductModelId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string? CatalogDescription { get; set; }

    [Column(TypeName = "xml")]
    public string? Instructions { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
