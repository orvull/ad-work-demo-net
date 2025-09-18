using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("BusinessEntityAddress", Schema = "Person")]
[PrimaryKey(nameof(BusinessEntityId), nameof(AddressId), nameof(AddressTypeId))]
public class BusinessEntityAddress
{
    public int BusinessEntityId { get; set; }

    public int AddressId { get; set; }

    public int AddressTypeId { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
