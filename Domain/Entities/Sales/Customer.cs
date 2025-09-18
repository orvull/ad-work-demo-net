using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("Customer", Schema = "Sales")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    public int? PersonId { get; set; }

    public int? StoreId { get; set; }

    public int? TerritoryId { get; set; }

    [Required]
    [StringLength(10)]
    public string AccountNumber { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
