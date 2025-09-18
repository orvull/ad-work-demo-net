using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("BusinessEntityContact", Schema = "Person")]
[PrimaryKey(nameof(BusinessEntityId), nameof(PersonId), nameof(ContactTypeId))]
public class BusinessEntityContact
{
    public int BusinessEntityId { get; set; }

    public int PersonId { get; set; }

    public int ContactTypeId { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
