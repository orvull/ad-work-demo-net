using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductModelIllustration", Schema = "Production")]
[PrimaryKey(nameof(ProductModelId), nameof(IllustrationId))]
public class ProductModelIllustration
{
    public int ProductModelId { get; set; }

    public int IllustrationId { get; set; }

    public DateTime ModifiedDate { get; set; }
}
