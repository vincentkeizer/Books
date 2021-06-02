using System;
using Books.Catalog.Domain.Books;
using MediatR;

namespace Books.Catalog.Api.Books.Commands
{
    public record CreateBookCommand(string Title, Guid AuthorId) : IRequest<BookId>;
}
