using ad_work_demo_net.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ad_work_demo_net.Infrastructure.Data.Configurations;

public class SalesOrderDetailConfiguration : IEntityTypeConfiguration<SalesOrderDetail>
{
    public void Configure(EntityTypeBuilder<SalesOrderDetail> builder)
    {
        builder.ToTable("SalesOrderDetail", "Sales");

        builder.HasKey(x => new { x.SalesOrderId, x.SalesOrderDetailId });

        builder.Property(x => x.SalesOrderId)
            .HasColumnName("SalesOrderID");

        builder.Property(x => x.SalesOrderDetailId)
            .HasColumnName("SalesOrderDetailID");

        builder.Property(x => x.CarrierTrackingNumber)
            .HasMaxLength(25);

        builder.Property(x => x.ProductId)
            .HasColumnName("ProductID");

        builder.Property(x => x.SpecialOfferId)
            .HasColumnName("SpecialOfferID");

        builder.Property(x => x.UnitPrice)
            .HasColumnType("money");

        builder.Property(x => x.UnitPriceDiscount)
            .HasColumnType("money");

        builder.Property(x => x.LineTotal)
            .HasColumnType("numeric(38, 6)");

        builder.Property(x => x.Rowguid)
            .HasColumnName("rowguid");

        builder.Property(x => x.ModifiedDate)
            .HasColumnType("datetime");

        builder.HasOne(x => x.SalesOrderHeader)
            .WithMany(h => h.SalesOrderDetails)
            .HasForeignKey(x => x.SalesOrderId);

        builder.HasOne(x => x.Product)
            .WithMany(p => p.SalesOrderDetails)
            .HasForeignKey(x => x.ProductId);
    }
}
