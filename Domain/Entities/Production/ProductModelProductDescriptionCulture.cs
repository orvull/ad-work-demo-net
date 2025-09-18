using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductModelProductDescriptionCulture", Schema = "Production")]
[PrimaryKey(nameof(ProductModelId), nameof(ProductDescriptionId), nameof(CultureId))]
public class ProductModelProductDescriptionCulture
{
    public int ProductModelId { get; set; }

    public int ProductDescriptionId { get; set; }

    [StringLength(6)]
    public string CultureId { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
