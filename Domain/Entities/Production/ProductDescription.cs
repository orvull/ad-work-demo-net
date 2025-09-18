using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductDescription", Schema = "Production")]
public class ProductDescription
{
    [Key]
    public int ProductDescriptionId { get; set; }

    [Required]
    [StringLength(400)]
    public string Description { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
