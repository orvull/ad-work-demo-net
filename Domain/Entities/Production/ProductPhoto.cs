using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductPhoto", Schema = "Production")]
public class ProductPhoto
{
    [Key]
    public int ProductPhotoId { get; set; }

    [Column(TypeName = "varbinary(max)")]
    public byte[]? ThumbNailPhoto { get; set; }

    [StringLength(50)]
    public string? ThumbnailPhotoFileName { get; set; }

    [Column(TypeName = "varbinary(max)")]
    public byte[]? LargePhoto { get; set; }

    [StringLength(50)]
    public string? LargePhotoFileName { get; set; }

    public DateTime ModifiedDate { get; set; }
}
