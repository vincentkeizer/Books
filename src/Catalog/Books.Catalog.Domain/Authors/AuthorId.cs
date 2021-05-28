using System;
using Books.Catalog.Core.DomainConstructs.Entities;

namespace Books.Catalog.Domain.Authors
{
    public record AuthorId : BaseId
    {
        public AuthorId(Guid value) : base(value)
        {
        }
    }
}
