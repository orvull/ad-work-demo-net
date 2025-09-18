using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("ShoppingCartItem", Schema = "Sales")]
public class ShoppingCartItem
{
    [Key]
    public int ShoppingCartItemId { get; set; }

    [Required]
    [StringLength(50)]
    public string ShoppingCartId { get; set; } = null!;

    public int Quantity { get; set; }

    public int ProductId { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime ModifiedDate { get; set; }
}
