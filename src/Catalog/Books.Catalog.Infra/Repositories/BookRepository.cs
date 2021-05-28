using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Core.Assertions;
using Books.Catalog.Domain.Books;
using Books.Catalog.Infra.Databases.Providers;
using Books.Catalog.Infra.Repositories.Factories;

namespace Books.Catalog.Infra.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDbContextProvider _dbContextProvider;

        public BookRepository(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public Book? Get(BookId bookId)
        {
            Guard.IsNotNull(bookId, nameof(bookId));

            var dbContext = _dbContextProvider.GetDbContext();
            var bookState = dbContext.Catalog.FirstOrDefault(c => c.Id == bookId.Value);
            return EntityFactory.Create(bookState, s => new Book(s));
        }
    }
}
