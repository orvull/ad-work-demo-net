using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("PhoneNumberType", Schema = "Person")]
public class PhoneNumberType
{
    [Key]
    public int PhoneNumberTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
