using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SalesTerritoryHistory", Schema = "Sales")]
[PrimaryKey(nameof(BusinessEntityId), nameof(TerritoryId), nameof(StartDate))]
public class SalesTerritoryHistory
{
    public int BusinessEntityId { get; set; }

    public int TerritoryId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
