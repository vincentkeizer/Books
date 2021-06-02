using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Books.Catalog.Api.Books.Commands;
using Books.Catalog.Domain.Authors;
using Books.Catalog.Domain.Books;
using MediatR;

namespace Books.Catalog.Api.Books.Handlers
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, BookId>
    {
        private readonly IBookRepository _bookRepository;

        public CreateBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookId> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var bookTitle = new BookTitle(request.Title);
            var authorId = new AuthorId(request.AuthorId);

            var book = new Book(bookTitle, authorId);

            await _bookRepository.Add(book).ConfigureAwait(false);

            return book.Id;
        }
    }
}
