using ad_work_demo_net.Domain.Entities.Dbo;
using ad_work_demo_net.Domain.Entities.HumanResources;
using ad_work_demo_net.Domain.Entities.Person;
using ad_work_demo_net.Domain.Entities.Production;
using ad_work_demo_net.Domain.Entities.Purchasing;
using ad_work_demo_net.Domain.Entities.Sales;
using Microsoft.EntityFrameworkCore;

namespace ad_work_demo_net.Data;

public class AdventureWorksDbContext : DbContext
{
    public AdventureWorksDbContext(DbContextOptions<AdventureWorksDbContext> options)
        : base(options)
    {
    }

    // dbo schema
    public DbSet<AwbuildVersion> AwbuildVersions => Set<AwbuildVersion>();

    public DbSet<DatabaseLog> DatabaseLogs => Set<DatabaseLog>();

    // HumanResources schema
    public DbSet<Department> Departments => Set<Department>();

    public DbSet<Employee> Employees => Set<Employee>();

    public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories => Set<EmployeeDepartmentHistory>();

    public DbSet<EmployeePayHistory> EmployeePayHistories => Set<EmployeePayHistory>();

    public DbSet<JobCandidate> JobCandidates => Set<JobCandidate>();

    public DbSet<Shift> Shifts => Set<Shift>();

    // Person schema
    public DbSet<Address> Addresses => Set<Address>();

    public DbSet<AddressType> AddressTypes => Set<AddressType>();

    public DbSet<BusinessEntity> BusinessEntities => Set<BusinessEntity>();

    public DbSet<BusinessEntityAddress> BusinessEntityAddresses => Set<BusinessEntityAddress>();

    public DbSet<BusinessEntityContact> BusinessEntityContacts => Set<BusinessEntityContact>();

    public DbSet<ContactType> ContactTypes => Set<ContactType>();

    public DbSet<CountryRegion> CountryRegions => Set<CountryRegion>();

    public DbSet<EmailAddress> EmailAddresses => Set<EmailAddress>();

    public DbSet<Password> Passwords => Set<Password>();

    public DbSet<Person> Persons => Set<Person>();

    public DbSet<PersonPhone> PersonPhones => Set<PersonPhone>();

    public DbSet<PhoneNumberType> PhoneNumberTypes => Set<PhoneNumberType>();

    public DbSet<StateProvince> StateProvinces => Set<StateProvince>();

    // Production schema
    public DbSet<BillOfMaterial> BillOfMaterials => Set<BillOfMaterial>();

    public DbSet<Culture> Cultures => Set<Culture>();

    public DbSet<Document> Documents => Set<Document>();

    public DbSet<Illustration> Illustrations => Set<Illustration>();

    public DbSet<Location> Locations => Set<Location>();

    public DbSet<Product> Products => Set<Product>();

    public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

    public DbSet<ProductCostHistory> ProductCostHistories => Set<ProductCostHistory>();

    public DbSet<ProductDescription> ProductDescriptions => Set<ProductDescription>();

    public DbSet<ProductDocument> ProductDocuments => Set<ProductDocument>();

    public DbSet<ProductInventory> ProductInventories => Set<ProductInventory>();

    public DbSet<ProductListPriceHistory> ProductListPriceHistories => Set<ProductListPriceHistory>();

    public DbSet<ProductModel> ProductModels => Set<ProductModel>();

    public DbSet<ProductModelIllustration> ProductModelIllustrations => Set<ProductModelIllustration>();

    public DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures => Set<ProductModelProductDescriptionCulture>();

    public DbSet<ProductPhoto> ProductPhotos => Set<ProductPhoto>();

    public DbSet<ProductProductPhoto> ProductProductPhotos => Set<ProductProductPhoto>();

    public DbSet<ProductReview> ProductReviews => Set<ProductReview>();

    public DbSet<ProductSubcategory> ProductSubcategories => Set<ProductSubcategory>();

    public DbSet<ScrapReason> ScrapReasons => Set<ScrapReason>();

    public DbSet<TransactionHistory> TransactionHistories => Set<TransactionHistory>();

    public DbSet<TransactionHistoryArchive> TransactionHistoryArchives => Set<TransactionHistoryArchive>();

    public DbSet<UnitMeasure> UnitMeasures => Set<UnitMeasure>();

    public DbSet<WorkOrder> WorkOrders => Set<WorkOrder>();

    public DbSet<WorkOrderRouting> WorkOrderRoutings => Set<WorkOrderRouting>();

    // Purchasing schema
    public DbSet<ProductVendor> ProductVendors => Set<ProductVendor>();

    public DbSet<PurchaseOrderDetail> PurchaseOrderDetails => Set<PurchaseOrderDetail>();

    public DbSet<PurchaseOrderHeader> PurchaseOrderHeaders => Set<PurchaseOrderHeader>();

    public DbSet<ShipMethod> ShipMethods => Set<ShipMethod>();

    public DbSet<Vendor> Vendors => Set<Vendor>();

    // Sales schema
    public DbSet<CountryRegionCurrency> CountryRegionCurrencies => Set<CountryRegionCurrency>();

    public DbSet<CreditCard> CreditCards => Set<CreditCard>();

    public DbSet<Currency> Currencies => Set<Currency>();

    public DbSet<CurrencyRate> CurrencyRates => Set<CurrencyRate>();

    public DbSet<Customer> Customers => Set<Customer>();

    public DbSet<PersonCreditCard> PersonCreditCards => Set<PersonCreditCard>();

    public DbSet<SalesOrderHeader> SalesOrderHeaders => Set<SalesOrderHeader>();

    public DbSet<SalesOrderDetail> SalesOrderDetails => Set<SalesOrderDetail>();

    public DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons => Set<SalesOrderHeaderSalesReason>();

    public DbSet<SalesPerson> SalesPeople => Set<SalesPerson>();

    public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories => Set<SalesPersonQuotaHistory>();

    public DbSet<SalesReason> SalesReasons => Set<SalesReason>();

    public DbSet<SalesTaxRate> SalesTaxRates => Set<SalesTaxRate>();

    public DbSet<SalesTerritory> SalesTerritories => Set<SalesTerritory>();

    public DbSet<SalesTerritoryHistory> SalesTerritoryHistories => Set<SalesTerritoryHistory>();

    public DbSet<ShoppingCartItem> ShoppingCartItems => Set<ShoppingCartItem>();

    public DbSet<SpecialOffer> SpecialOffers => Set<SpecialOffer>();

    public DbSet<SpecialOfferProduct> SpecialOfferProducts => Set<SpecialOfferProduct>();

    public DbSet<Store> Stores => Set<Store>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdventureWorksDbContext).Assembly);
    }
}
