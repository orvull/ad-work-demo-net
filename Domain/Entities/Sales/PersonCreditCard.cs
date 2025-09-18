using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("PersonCreditCard", Schema = "Sales")]
[PrimaryKey(nameof(BusinessEntityId), nameof(CreditCardId))]
public class PersonCreditCard
{
    public int BusinessEntityId { get; set; }

    public int CreditCardId { get; set; }

    public DateTime ModifiedDate { get; set; }
}
