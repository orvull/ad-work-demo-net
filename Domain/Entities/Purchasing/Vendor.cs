using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Purchasing;

[Table("Vendor", Schema = "Purchasing")]
public class Vendor
{
    [Key]
    public int BusinessEntityId { get; set; }

    [Required]
    [StringLength(15)]
    public string AccountNumber { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public byte CreditRating { get; set; }

    public bool PreferredVendorStatus { get; set; }

    public bool ActiveFlag { get; set; }

    [StringLength(1024)]
    public string? PurchasingWebServiceUrl { get; set; }

    public DateTime ModifiedDate { get; set; }
}
