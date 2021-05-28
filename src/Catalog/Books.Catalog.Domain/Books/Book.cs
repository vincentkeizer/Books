using Books.Catalog.Core.Assertions;
using Books.Catalog.Core.DomainConstructs.Entities;
using Books.Catalog.Domain.Authors;

namespace Books.Catalog.Domain.Books
{
    public class Book : BaseEntity<BookState>
    {
        public Book(BookTitle bookTitle, AuthorId authorId) : base(new BookState())
        {
            SetTitle(bookTitle);
            SetAuthor(authorId);
        }

        public Book(BookState state) : base(state) => Guard.IsNotNull(state, nameof(state));

        public BookId Id => new(InternalState.Id);
        public BookTitle BookTitle => new(InternalState.Title);
        public AuthorId AuthorId => new(InternalState.AuthorId);

        private void SetAuthor(AuthorId authorId)
        {
            Guard.IsNotNull(authorId, nameof(authorId));
            InternalState.AuthorId = InternalState.AuthorId;
        }

        private void SetTitle(BookTitle bookTitle)
        {
            Guard.IsNotNull(bookTitle, nameof(bookTitle));
            InternalState.Title = bookTitle.Value;
        }
    }
}
