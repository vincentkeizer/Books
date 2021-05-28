using System.Collections.Generic;
using System.Threading.Tasks;
using Books.Catalog.Api.Catalogs.Queries.GetCatalog;

namespace Books.Catalog.Api.Catalogs.Queries
{
    public interface ICatalogQueryService
    {
        Task<IEnumerable<CatalogListItem>> Get(GetCatalogQuery query);
    }
}
