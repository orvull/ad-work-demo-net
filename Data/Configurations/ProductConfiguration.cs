using ad_work_demo_net.Domain.Entities.Production;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ad_work_demo_net.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Product", "Production");

        builder.HasKey(x => x.ProductId);

        builder.Property(x => x.ProductId)
            .HasColumnName("ProductID");

        builder.Property(x => x.Name)
            .HasMaxLength(50);

        builder.Property(x => x.ProductNumber)
            .HasMaxLength(25);

        builder.Property(x => x.MakeFlag)
            .HasColumnType("bit");

        builder.Property(x => x.FinishedGoodsFlag)
            .HasColumnType("bit");

        builder.Property(x => x.Color)
            .HasMaxLength(15);

        builder.Property(x => x.StandardCost)
            .HasColumnType("money");

        builder.Property(x => x.ListPrice)
            .HasColumnType("money");

        builder.Property(x => x.Size)
            .HasMaxLength(5);

        builder.Property(x => x.SizeUnitMeasureCode)
            .HasMaxLength(3)
            .IsFixedLength();

        builder.Property(x => x.WeightUnitMeasureCode)
            .HasMaxLength(3)
            .IsFixedLength();

        builder.Property(x => x.Weight)
            .HasColumnType("decimal(8, 2)");

        builder.Property(x => x.ProductLine)
            .HasMaxLength(2)
            .IsFixedLength();

        builder.Property(x => x.Class)
            .HasMaxLength(2)
            .IsFixedLength();

        builder.Property(x => x.Style)
            .HasMaxLength(2)
            .IsFixedLength();

        builder.Property(x => x.ProductSubcategoryId)
            .HasColumnName("ProductSubcategoryID");

        builder.Property(x => x.ProductModelId)
            .HasColumnName("ProductModelID");

        builder.Property(x => x.SellStartDate)
            .HasColumnType("datetime");

        builder.Property(x => x.SellEndDate)
            .HasColumnType("datetime");

        builder.Property(x => x.DiscontinuedDate)
            .HasColumnType("datetime");

        builder.Property(x => x.Rowguid)
            .HasColumnName("rowguid");

        builder.Property(x => x.ModifiedDate)
            .HasColumnType("datetime");

        builder.HasMany(x => x.SalesOrderDetails)
            .WithOne(d => d.Product)
            .HasForeignKey(d => d.ProductId);
    }
}
