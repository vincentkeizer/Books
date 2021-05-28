using System;
using System.Collections.Generic;

namespace Books.Catalog.Api.Catalogs.Queries.GetCatalog
{
    public record CatalogListItem(Guid BookId, 
                                  string Title,
                                  CatalogListItemAuthor Authors);
}
