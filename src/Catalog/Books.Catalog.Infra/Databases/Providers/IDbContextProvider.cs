namespace Books.Catalog.Infra.Databases.Providers
{
    public interface IDbContextProvider
    {
        CatalogDbContext GetDbContext();
    }
}
