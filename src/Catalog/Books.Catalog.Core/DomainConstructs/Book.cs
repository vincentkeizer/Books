using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Core.Assertions;

namespace Books.Catalog.Core.DomainConstructs
{
    public record Book
    {
        public Book(string title, string author)
        {
            Guard.IsNotNullOrWhitespace(title, nameof(title));

            Title = title;
        }

        public string Title { get; }
    }
}
