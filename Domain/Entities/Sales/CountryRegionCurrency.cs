using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("CountryRegionCurrency", Schema = "Sales")]
[PrimaryKey(nameof(CountryRegionCode), nameof(CurrencyCode))]
public class CountryRegionCurrency
{
    [StringLength(3)]
    public string CountryRegionCode { get; set; } = null!;

    [StringLength(3)]
    public string CurrencyCode { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }
}
