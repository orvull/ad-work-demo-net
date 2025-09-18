using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductSubcategory", Schema = "Production")]
public class ProductSubcategory
{
    [Key]
    public int ProductSubcategoryId { get; set; }

    public int ProductCategoryId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
