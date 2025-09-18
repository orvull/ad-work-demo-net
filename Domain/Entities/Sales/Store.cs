using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("Store", Schema = "Sales")]
public class Store
{
    [Key]
    public int BusinessEntityId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int? SalesPersonId { get; set; }

    [Column(TypeName = "xml")]
    public string? Demographics { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
