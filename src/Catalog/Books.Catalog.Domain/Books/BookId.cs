using System;
using Books.Catalog.Core.DomainConstructs.Entities;

namespace Books.Catalog.Domain.Books
{
    public record BookId : BaseId
    {
        public BookId(Guid value) : base(value) { }
    }
}