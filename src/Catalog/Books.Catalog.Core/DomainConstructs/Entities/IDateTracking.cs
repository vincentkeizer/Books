using System;

namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}
