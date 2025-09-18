using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("WorkOrderRouting", Schema = "Production")]
[PrimaryKey(nameof(WorkOrderId), nameof(ProductId), nameof(OperationSequence))]
public class WorkOrderRouting
{
    public int WorkOrderId { get; set; }

    public int ProductId { get; set; }

    public short OperationSequence { get; set; }

    public short LocationId { get; set; }

    public DateTime ScheduledStartDate { get; set; }

    public DateTime ScheduledEndDate { get; set; }

    public DateTime? ActualStartDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    [Column(TypeName = "decimal(9, 4)")]
    public decimal? ActualResourceHours { get; set; }

    [Column(TypeName = "money")]
    public decimal PlannedCost { get; set; }

    [Column(TypeName = "money")]
    public decimal ActualCost { get; set; }

    public DateTime ModifiedDate { get; set; }
}
