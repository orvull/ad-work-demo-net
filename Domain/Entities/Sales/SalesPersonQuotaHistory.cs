using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesPersonQuotaHistory", Schema = "Sales")]
[PrimaryKey(nameof(BusinessEntityId), nameof(QuotaDate))]
public class SalesPersonQuotaHistory
{
    public int BusinessEntityId { get; set; }

    public DateTime QuotaDate { get; set; }

    [Column(TypeName = "money")]
    public decimal SalesQuota { get; set; }

    public DateTime ModifiedDate { get; set; }
}
