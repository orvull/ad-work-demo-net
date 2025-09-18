using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductDocument", Schema = "Production")]
[PrimaryKey(nameof(ProductId), nameof(DocumentNode))]
public class ProductDocument
{
    public int ProductId { get; set; }

    [Column(TypeName = "hierarchyid")]
    public HierarchyId DocumentNode { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
