using Books.Catalog.Core.Assertions;

namespace Books.Catalog.Domain.Books
{
    public record BookTitle
    {
        public BookTitle(string title)
        {
            Guard.IsNotNullOrWhitespace(title, nameof(title));
            Guard.DoesNotExceedLength(250, title, nameof(title));

            Value = title;
        }

        public string Value { get; }
    }
}