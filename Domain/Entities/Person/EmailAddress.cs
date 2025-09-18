using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("EmailAddress", Schema = "Person")]
[PrimaryKey(nameof(BusinessEntityId), nameof(EmailAddressId))]
public class EmailAddress
{
    public int BusinessEntityId { get; set; }

    public int EmailAddressId { get; set; }

    [StringLength(50)]
    [Column("EmailAddress")]
    public string? EmailAddressValue { get; set; }

    [Column("rowguid")]
    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
