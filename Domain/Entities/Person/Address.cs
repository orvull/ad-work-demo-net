using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("Address", Schema = "Person")]
public class Address
{
    [Key]
    public int AddressId { get; set; }

    [Required]
    [StringLength(60)]
    public string AddressLine1 { get; set; } = null!;

    [StringLength(60)]
    public string? AddressLine2 { get; set; }

    [Required]
    [StringLength(30)]
    public string City { get; set; } = null!;

    public int StateProvinceId { get; set; }

    [Required]
    [StringLength(15)]
    public string PostalCode { get; set; } = null!;

    [Column(TypeName = "geography")]
    public Geometry? SpatialLocation { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
