using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("StateProvince", Schema = "Person")]
public class StateProvince
{
    [Key]
    public int StateProvinceId { get; set; }

    [Required]
    [StringLength(3)]
    public string StateProvinceCode { get; set; } = null!;

    [Required]
    [StringLength(3)]
    public string CountryRegionCode { get; set; } = null!;

    public bool IsOnlyStateProvinceFlag { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int TerritoryId { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
