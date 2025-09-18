using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("CreditCard", Schema = "Sales")]
public class CreditCard
{
    [Key]
    public int CreditCardId { get; set; }

    [Required]
    [StringLength(50)]
    public string CardType { get; set; } = null!;

    [Required]
    [StringLength(25)]
    public string CardNumber { get; set; } = null!;

    public byte ExpMonth { get; set; }

    public short ExpYear { get; set; }

    public DateTime ModifiedDate { get; set; }
}
