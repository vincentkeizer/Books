using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Core.DomainConstructs.Entities;
using Books.Catalog.Domain.Authors;

namespace Books.Catalog.Domain.Books
{
    public class BookState : BaseWrappedEntityState
    {
#nullable disable
        public string Title { get; set; }
        public AuthorState Author { get; set; }
        public Guid AuthorId { get; set; }
#nullable enable
    }
}
