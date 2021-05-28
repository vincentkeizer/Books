using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Catalog.Api.Catalogs.Queries.GetCatalog;
using Books.Catalog.Domain.Authors;
using Books.Catalog.Infra.Databases.Providers;
using Microsoft.EntityFrameworkCore;

namespace Books.Catalog.Api.Catalogs.Queries
{
    public class CatalogQueryService : ICatalogQueryService
    {
        private readonly IDbContextProvider _dbContextProvider;

        public CatalogQueryService(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public async Task<IEnumerable<CatalogListItem>> Get(GetCatalogQuery query)
        {
            var dbContext = _dbContextProvider.GetDbContext();

            return await dbContext.Catalog.Select(c =>
                    new CatalogListItem(c.Id,
                        c.Title,
                        new CatalogListItemAuthor(c.Author.Id,
                            c.Author.FirstName,
                            c.Author.LastName,
                            c.Author.MiddleName)
                    )
                ).Skip(query.Page * query.PageSize)
                .Take(query.PageSize)
                .ToListAsync();
        }
    }
}