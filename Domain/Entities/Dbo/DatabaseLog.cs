using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Dbo;

[Table("DatabaseLog", Schema = "dbo")]
public class DatabaseLog
{
    [Key]
    public int DatabaseLogId { get; set; }

    public DateTime PostTime { get; set; }

    [Required]
    [StringLength(128)]
    public string DatabaseUser { get; set; } = null!;

    [Required]
    [StringLength(128)]
    public string Event { get; set; } = null!;

    [Column("Schema")]
    [StringLength(128)]
    public string? SchemaName { get; set; }

    [Column("Object")]
    [StringLength(128)]
    public string? ObjectName { get; set; }

    public string? Tsql { get; set; }

    public string? XmlEvent { get; set; }
}
