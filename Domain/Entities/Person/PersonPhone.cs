using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("PersonPhone", Schema = "Person")]
[PrimaryKey(nameof(BusinessEntityId), nameof(PhoneNumber), nameof(PhoneNumberTypeId))]
public class PersonPhone
{
    public int BusinessEntityId { get; set; }

    [StringLength(25)]
    public string PhoneNumber { get; set; } = null!;

    public int PhoneNumberTypeId { get; set; }

    public DateTime ModifiedDate { get; set; }
}
