using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductCostHistory", Schema = "Production")]
[PrimaryKey(nameof(ProductId), nameof(StartDate))]
public class ProductCostHistory
{
    public int ProductId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [Column(TypeName = "money")]
    public decimal StandardCost { get; set; }

    public DateTime ModifiedDate { get; set; }
}
