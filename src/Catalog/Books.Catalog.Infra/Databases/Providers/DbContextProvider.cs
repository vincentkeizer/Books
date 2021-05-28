using System;

namespace Books.Catalog.Infra.Databases.Providers
{
    public class DbContextProvider : IDbContextProvider
    {
        private readonly CatalogDbContext _dbContext;

        public DbContextProvider(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public CatalogDbContext GetDbContext() => _dbContext;
    }
}