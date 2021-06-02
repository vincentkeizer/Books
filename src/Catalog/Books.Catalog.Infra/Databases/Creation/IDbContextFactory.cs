namespace Books.Catalog.Infra.Databases.Creation
{
    public interface IDbContextFactory<out T> where T : CatalogDbContext
    {
        T CreateDbContext();

    }
}