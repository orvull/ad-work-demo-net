using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.HumanResources;

[Table("Shift", Schema = "HumanResources")]
public class Shift
{
    [Key]
    public byte ShiftId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public DateTime ModifiedDate { get; set; }
}
