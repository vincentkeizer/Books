using System;

namespace Books.Catalog.Api.Catalogs.Queries.GetCatalog
{
    public record CatalogListItemAuthor(Guid AuthorId, 
                                        string FirstName, 
                                        string LastName, 
                                        string? MiddleName);
}
