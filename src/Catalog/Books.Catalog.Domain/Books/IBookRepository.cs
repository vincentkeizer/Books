using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Catalog.Domain.Books
{
    public interface IBookRepository
    {
        Task<Book?> Get(BookId bookId);

        Task Add(Book book);
    }
}
