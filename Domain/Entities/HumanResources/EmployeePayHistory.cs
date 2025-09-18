using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.HumanResources;

[Table("EmployeePayHistory", Schema = "HumanResources")]
[PrimaryKey(nameof(BusinessEntityId), nameof(RateChangeDate))]
public class EmployeePayHistory
{
    public int BusinessEntityId { get; set; }

    public DateTime RateChangeDate { get; set; }

    [Column(TypeName = "money")]
    public decimal Rate { get; set; }

    public byte PayFrequency { get; set; }

    public DateTime ModifiedDate { get; set; }
}
