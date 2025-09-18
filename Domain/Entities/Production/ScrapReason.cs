using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ScrapReason", Schema = "Production")]
public class ScrapReason
{
    [Key]
    public short ScrapReasonId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
