using System;
using Books.Catalog.Domain.Books;
using Shouldly;
using Xunit;

namespace Books.Catalog.Domain.UnitTests.Books
{
    public class BookTitleTests
    {
        [Fact]
        public void Ctor_WhenNull_ThenThrowsArgumentException()
        {
            string nullBookTitle = null;

            Should.Throw<ArgumentException>(() => new BookTitle(nullBookTitle!));
        }

        [Fact]
        public void Ctor_WhenWhiteSpace_ThenThrowsArgumentException()
        {
            var bookTitleWithOnlyWhiteSpace = " ";

            Should.Throw<ArgumentException>(() => new BookTitle(bookTitleWithOnlyWhiteSpace));
        }

        [Fact]
        public void Ctor_WhenExceeds250Characters_ThenThrowsArgumentException()
        {
            var bookTitleStringOf251Characters = new string('*', 251);

            Should.Throw<ArgumentException>(() => new BookTitle(bookTitleStringOf251Characters));
        }

        [Fact]
        public void Ctor_WhenTitleIsValid_ThenDoesNotThrowException()
        {
            var bookTitle = "Book Title";

            Should.NotThrow(() => new BookTitle(bookTitle));
        }
    }
}
