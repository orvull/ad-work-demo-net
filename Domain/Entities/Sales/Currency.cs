using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("Currency", Schema = "Sales")]
public class Currency
{
    [Key]
    [StringLength(3)]
    public string CurrencyCode { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
