using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("WorkOrder", Schema = "Production")]
public class WorkOrder
{
    [Key]
    public int WorkOrderId { get; set; }

    public int ProductId { get; set; }

    public int OrderQty { get; set; }

    public int StockedQty { get; set; }

    public short ScrappedQty { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime DueDate { get; set; }

    public short? ScrapReasonId { get; set; }

    public DateTime ModifiedDate { get; set; }
}
