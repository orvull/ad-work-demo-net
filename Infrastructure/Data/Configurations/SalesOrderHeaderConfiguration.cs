using ad_work_demo_net.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ad_work_demo_net.Infrastructure.Data.Configurations;

public class SalesOrderHeaderConfiguration : IEntityTypeConfiguration<SalesOrderHeader>
{
    public void Configure(EntityTypeBuilder<SalesOrderHeader> builder)
    {
        builder.ToTable("SalesOrderHeader", "Sales");

        builder.HasKey(x => x.SalesOrderId);

        builder.Property(x => x.SalesOrderId)
            .HasColumnName("SalesOrderID");

        builder.Property(x => x.RevisionNumber)
            .HasColumnType("tinyint");

        builder.Property(x => x.OrderDate)
            .HasColumnType("datetime");

        builder.Property(x => x.DueDate)
            .HasColumnType("datetime");

        builder.Property(x => x.ShipDate)
            .HasColumnType("datetime");

        builder.Property(x => x.Status)
            .HasColumnType("tinyint");

        builder.Property(x => x.SalesOrderNumber)
            .HasMaxLength(25);

        builder.Property(x => x.PurchaseOrderNumber)
            .HasMaxLength(25);

        builder.Property(x => x.AccountNumber)
            .HasMaxLength(15);

        builder.Property(x => x.CustomerId)
            .HasColumnName("CustomerID");

        builder.Property(x => x.SalesPersonId)
            .HasColumnName("SalesPersonID");

        builder.Property(x => x.TerritoryId)
            .HasColumnName("TerritoryID");

        builder.Property(x => x.BillToAddressId)
            .HasColumnName("BillToAddressID");

        builder.Property(x => x.ShipToAddressId)
            .HasColumnName("ShipToAddressID");

        builder.Property(x => x.ShipMethodId)
            .HasColumnName("ShipMethodID");

        builder.Property(x => x.CreditCardId)
            .HasColumnName("CreditCardID");

        builder.Property(x => x.CreditCardApprovalCode)
            .HasMaxLength(15)
            .IsUnicode(false);

        builder.Property(x => x.CurrencyRateId)
            .HasColumnName("CurrencyRateID");

        builder.Property(x => x.SubTotal)
            .HasColumnType("money");

        builder.Property(x => x.TaxAmt)
            .HasColumnType("money");

        builder.Property(x => x.Freight)
            .HasColumnType("money");

        builder.Property(x => x.TotalDue)
            .HasColumnType("money");

        builder.Property(x => x.Comment)
            .HasMaxLength(128);

        builder.Property(x => x.Rowguid)
            .HasColumnName("rowguid");

        builder.Property(x => x.ModifiedDate)
            .HasColumnType("datetime");

        builder.HasMany(x => x.SalesOrderDetails)
            .WithOne(d => d.SalesOrderHeader)
            .HasForeignKey(d => d.SalesOrderId);
    }
}
