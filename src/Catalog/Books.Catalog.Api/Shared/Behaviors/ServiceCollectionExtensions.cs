using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Catalog.Api.Shared.Behaviors
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommandBehaviors(this IServiceCollection services) 
            => services.AddTransient(typeof(LoggingBehavior<,>), typeof(IPipelineBehavior<,>))
                       .AddTransient(typeof(TransactionBehavior<,>), typeof(IPipelineBehavior<,>));
    }
}
