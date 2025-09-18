using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("Culture", Schema = "Production")]
public class Culture
{
    [Key]
    [StringLength(6)]
    public string CultureId { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
