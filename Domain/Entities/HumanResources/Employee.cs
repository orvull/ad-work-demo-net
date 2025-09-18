using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ad_work_demo_net.Domain.Entities.HumanResources;

[Table("Employee", Schema = "HumanResources")]
public class Employee
{
    [Key]
    public int BusinessEntityId { get; set; }

    [Required]
    [StringLength(15)]
    public string NationalIdNumber { get; set; } = null!;

    [Required]
    [StringLength(256)]
    public string LoginId { get; set; } = null!;

    [Column(TypeName = "hierarchyid")]
    public Microsoft.EntityFrameworkCore.HierarchyId? OrganizationNode { get; set; }

    public short? OrganizationLevel { get; set; }

    [Required]
    [StringLength(50)]
    public string JobTitle { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    [Required]
    [StringLength(1)]
    public string MaritalStatus { get; set; } = null!;

    [Required]
    [StringLength(1)]
    public string Gender { get; set; } = null!;

    public DateTime HireDate { get; set; }

    public bool SalariedFlag { get; set; }

    public short VacationHours { get; set; }

    public short SickLeaveHours { get; set; }

    public bool CurrentFlag { get; set; }

    public Guid Rowguid { get; set; }

    public DateTime ModifiedDate { get; set; }
}
