using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.HumanResources;

[Table("JobCandidate", Schema = "HumanResources")]
public class JobCandidate
{
    [Key]
    public int JobCandidateId { get; set; }

    public int? BusinessEntityId { get; set; }

    [Column(TypeName = "xml")]
    public string? Resume { get; set; }

    public DateTime ModifiedDate { get; set; }
}
