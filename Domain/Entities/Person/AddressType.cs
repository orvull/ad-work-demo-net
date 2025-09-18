using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("AddressType", Schema = "Person")]
public class AddressType
{
    [Key]
    public int AddressTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
