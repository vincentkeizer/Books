using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Infra.Databases.Providers;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Catalog.Infra.Databases
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabases(this IServiceCollection services)
            => services.AddTransient<IDbContextProvider, DbContextProvider>();
    }
}
