using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductInventory", Schema = "Production")]
[PrimaryKey(nameof(ProductId), nameof(LocationId))]
public class ProductInventory
{
    public int ProductId { get; set; }

    public short LocationId { get; set; }

    [Required]
    [StringLength(10)]
    public string Shelf { get; set; } = null!;

    public byte Bin { get; set; }

    public short Quantity { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
