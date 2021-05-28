using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Core.DomainConstructs.Entities;
using Books.Catalog.Domain.Books;

namespace Books.Catalog.Domain.Authors
{
    public class AuthorState : BaseWrappedEntityState
    {
        
#nullable disable
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<BookState> Books { get; set; }
#nullable enable
        public string? MiddleName { get; set; }
    }
}
