using System;

namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public abstract class BaseWrappedEntityState : IEntityState, IDateTracking
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public IEntity? Entity { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
