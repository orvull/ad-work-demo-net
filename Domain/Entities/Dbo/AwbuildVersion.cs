using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Dbo;

[Table("AWBuildVersion", Schema = "dbo")]
public class AwbuildVersion
{
    [Key]
    public byte SystemInformationId { get; set; }

    [Required]
    [StringLength(25)]
    public string DatabaseVersion { get; set; } = null!;

    public DateTime VersionDate { get; set; }
}
