using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Infra.Databases;
using Books.Catalog.Infra.Databases.Providers;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;

namespace Books.Catalog.Infra.UnitTests.Database.Providers
{
    public class DbContextProviderTests
    {
        [Fact]
        public void GetDbContext_WhenCalled_ThenProvidesDbContext()
        {
            var dbContext = new CatalogDbContext(new DbContextOptions<CatalogDbContext>());
            var dbContextProvider = new DbContextProvider(dbContext);

            var providedDbContext = dbContextProvider.GetDbContext();

            providedDbContext.ShouldBe(dbContext);
        } 
        
        [Fact]
        public void GetDbContext_WhenCalledMultipleTimes_ThenProvidesSameDbContext()
        {
            var dbContext = new CatalogDbContext(new DbContextOptions<CatalogDbContext>());
            var dbContextProvider = new DbContextProvider(dbContext);

            var providedDbContext = dbContextProvider.GetDbContext();
            var providedDbContext2 = dbContextProvider.GetDbContext();

            providedDbContext.ShouldBe(dbContext);
            providedDbContext2.ShouldBe(dbContext);
        }
    }
}
