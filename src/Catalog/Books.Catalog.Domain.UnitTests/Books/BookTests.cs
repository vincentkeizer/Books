using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Domain.Authors;
using Books.Catalog.Domain.Books;
using Shouldly;
using Xunit;

namespace Books.Catalog.Domain.UnitTests.Books
{
    public class BookTests
    {
        [Fact]
        public void Ctor_WhenTitleIsNull_ThenThrowsArgumentNullException() 
            => Should.Throw<ArgumentNullException>(() => new Book(null!, new AuthorId(Guid.NewGuid())));

        [Fact]
        public void Ctor_WhenAuthorIsNull_ThenThrowsArgumentNullException() 
            => Should.Throw<ArgumentNullException>(() => new Book(new BookTitle("Title"), null!));
    }
}
