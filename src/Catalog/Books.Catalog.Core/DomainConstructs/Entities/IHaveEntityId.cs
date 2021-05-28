using System;

namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public interface IHaveEntityId
    {
        Guid Id { get; set; }
    }
}