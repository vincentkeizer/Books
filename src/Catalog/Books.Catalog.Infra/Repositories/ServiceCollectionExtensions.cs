using Books.Catalog.Domain.Books;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Catalog.Infra.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
            => services.AddTransient<IBookRepository, BookRepository>();
    }
}
