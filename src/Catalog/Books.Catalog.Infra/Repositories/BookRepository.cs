using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Core.Assertions;
using Books.Catalog.Domain.Books;
using Books.Catalog.Infra.Databases.Providers;
using Books.Catalog.Infra.Repositories.Factories;
using Microsoft.EntityFrameworkCore;

namespace Books.Catalog.Infra.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbContextProvider _dbContextProvider;

        public BookRepository(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public async Task<Book?> Get(BookId bookId)
        {
            Guard.IsNotNull(bookId, nameof(bookId));

            var dbContext = _dbContextProvider.GetDbContext();
            var bookState = await dbContext.Catalog.FirstOrDefaultAsync(c => c.Id == bookId.Value).ConfigureAwait(false);
            return EntityFactory.Create(bookState, s => new Book(s));
        }

        public async Task Add(Book book)
        {
            Guard.IsNotNull(book, nameof(book));

            var dbContext = _dbContextProvider.GetDbContext();

            await dbContext.Catalog.AddAsync(book.InternalState).ConfigureAwait(false);
        }
    }
}
