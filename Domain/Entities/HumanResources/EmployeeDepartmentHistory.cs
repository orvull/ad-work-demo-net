using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.HumanResources;

[Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
[PrimaryKey(nameof(BusinessEntityId), nameof(DepartmentId), nameof(ShiftId), nameof(StartDate))]
public class EmployeeDepartmentHistory
{
    public int BusinessEntityId { get; set; }

    public short DepartmentId { get; set; }

    public byte ShiftId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
