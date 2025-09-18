using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductProductPhoto", Schema = "Production")]
[PrimaryKey(nameof(ProductId), nameof(ProductPhotoId))]
public class ProductProductPhoto
{
    public int ProductId { get; set; }

    public int ProductPhotoId { get; set; }

    [Column("Primary")]
    public bool IsPrimary { get; set; }

    public DateTime ModifiedDate { get; set; }
}
