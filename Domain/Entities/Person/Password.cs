using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.Person;

[Table("Password", Schema = "Person")]
public class Password
{
    [Key]
    public int BusinessEntityId { get; set; }

    [Required]
    [StringLength(128)]
    public string PasswordHash { get; set; } = null!;

    [Required]
    [StringLength(10)]
    public string PasswordSalt { get; set; } = null!;

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
