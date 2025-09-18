using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("Illustration", Schema = "Production")]
public class Illustration
{
    [Key]
    public int IllustrationId { get; set; }

    [Column(TypeName = "xml")]
    public string? Diagram { get; set; }

    public DateTime ModifiedDate { get; set; }
}
