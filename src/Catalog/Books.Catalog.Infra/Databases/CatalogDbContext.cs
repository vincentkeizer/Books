using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Domain.Authors;
using Books.Catalog.Domain.Books;
using Books.Catalog.Infra.Databases.TypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Books.Catalog.Infra.Databases
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new BookStateTypeConfiguration().Configure(modelBuilder.Entity<BookState>());
            new AuthorStateTypeConfiguration().Configure(modelBuilder.Entity<AuthorState>());
        }

#nullable disable
        public DbSet<BookState> Catalog { get; set; }
#nullable enable
    }
}
