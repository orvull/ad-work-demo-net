using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.HumanResources;

[Table("Department", Schema = "HumanResources")]
public class Department
{
    [Key]
    public short DepartmentId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string GroupName { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
