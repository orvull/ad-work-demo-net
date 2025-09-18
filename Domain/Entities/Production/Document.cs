using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("Document", Schema = "Production")]
public class Document
{
    [Key]
    [Column(TypeName = "hierarchyid")]
    public HierarchyId DocumentNode { get; set; } = null!;

    public short? DocumentLevel { get; set; }

    [Required]
    [StringLength(50)]
    public string Title { get; set; } = null!;

    public int Owner { get; set; }

    public bool FolderFlag { get; set; }

    [Required]
    [StringLength(400)]
    public string FileName { get; set; } = null!;

    [Required]
    [StringLength(8)]
    public string FileExtension { get; set; } = null!;

    [Required]
    [StringLength(5)]
    public string Revision { get; set; } = null!;

    public int ChangeNumber { get; set; }

    public byte Status { get; set; }

    public string? DocumentSummary { get; set; }

    [Column("Document")]
    public byte[]? DocumentContent { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
