using ad_work_demo_net.Domain.Entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ad_work_demo_net.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("Person", "Person");

        builder.HasKey(p => p.BusinessEntityId);

        builder.Property(p => p.BusinessEntityId)
            .HasColumnName("BusinessEntityID");

        builder.Property(p => p.PersonType)
            .HasMaxLength(2)
            .IsFixedLength();

        builder.Property(p => p.Title)
            .HasMaxLength(8);

        builder.Property(p => p.FirstName)
            .HasMaxLength(50);

        builder.Property(p => p.MiddleName)
            .HasMaxLength(50);

        builder.Property(p => p.LastName)
            .HasMaxLength(50);

        builder.Property(p => p.Suffix)
            .HasMaxLength(10);

        builder.Property(p => p.AdditionalContactInfo)
            .HasColumnType("xml");

        builder.Property(p => p.Demographics)
            .HasColumnType("xml");

        builder.Property(p => p.Rowguid)
            .HasColumnName("rowguid");

        builder.Property(p => p.ModifiedDate)
            .HasColumnType("datetime");
    }
}
