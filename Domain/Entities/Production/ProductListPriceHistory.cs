using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductListPriceHistory", Schema = "Production")]
[PrimaryKey(nameof(ProductId), nameof(StartDate))]
public class ProductListPriceHistory
{
    public int ProductId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    [Column(TypeName = "money")]
    public decimal ListPrice { get; set; }

    public DateTime ModifiedDate { get; set; }
}
