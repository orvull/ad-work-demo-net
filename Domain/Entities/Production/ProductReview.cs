using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Production;

[Table("ProductReview", Schema = "Production")]
public class ProductReview
{
    [Key]
    public int ProductReviewId { get; set; }

    public int ProductId { get; set; }

    [Required]
    [StringLength(50)]
    public string ReviewerName { get; set; } = null!;

    public DateTime ReviewDate { get; set; }

    [Required]
    [StringLength(50)]
    public string EmailAddress { get; set; } = null!;

    public int Rating { get; set; }

    [StringLength(3850)]
    public string? Comments { get; set; }

    public DateTime ModifiedDate { get; set; }
}
