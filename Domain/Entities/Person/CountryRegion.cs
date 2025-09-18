using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("CountryRegion", Schema = "Person")]
public class CountryRegion
{
    [Key]
    [StringLength(3)]
    public string CountryRegionCode { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
