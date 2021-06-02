using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books.Catalog.Api.Books.Commands;
using Books.Catalog.Domain.Books;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Books.Catalog.Api.Books.Handlers
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBooksCommandHandlers(this IServiceCollection services)
            => services.AddTransient<IRequestHandler<CreateBookCommand, BookId>, CreateBookCommandHandler>();
    }
}
