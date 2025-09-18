using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
[PrimaryKey(nameof(SalesOrderId), nameof(SalesReasonId))]
public class SalesOrderHeaderSalesReason
{
    public int SalesOrderId { get; set; }

    public int SalesReasonId { get; set; }

    public DateTime ModifiedDate { get; set; }
}
