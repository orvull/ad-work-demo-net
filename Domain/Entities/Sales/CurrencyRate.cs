using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Sales;

[Table("CurrencyRate", Schema = "Sales")]
public class CurrencyRate
{
    [Key]
    public int CurrencyRateId { get; set; }

    public DateTime CurrencyRateDate { get; set; }

    [StringLength(3)]
    public string FromCurrencyCode { get; set; } = null!;

    [StringLength(3)]
    public string ToCurrencyCode { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal AverageRate { get; set; }

    [Column(TypeName = "money")]
    public decimal EndOfDayRate { get; set; }

    public DateTime ModifiedDate { get; set; }
}
