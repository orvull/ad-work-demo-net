using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("SpecialOfferProduct", Schema = "Sales")]
[PrimaryKey(nameof(SpecialOfferId), nameof(ProductId))]
public class SpecialOfferProduct
{
    public int SpecialOfferId { get; set; }

    public int ProductId { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
