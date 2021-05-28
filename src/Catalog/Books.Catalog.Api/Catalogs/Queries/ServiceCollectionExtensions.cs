using Books.Catalog.Api.Shared.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Catalog.Api.Catalogs.Queries
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddQueries(this IServiceCollection services)
            => services.AddTransient<IQueryHandler, QueryHandler>()
                       .AddTransient<ICatalogQueryService, CatalogQueryService>();
    }
}
