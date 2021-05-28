using System;

namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public abstract record Identity
    {
        private readonly Guid _id;

        public Identity() => this._id = Guid.NewGuid();

        public Identity(Guid id) => this._id = id;

        public override string ToString() => this.GetType().Name + " [Id=" + _id + "]";

        public Guid ValueAsGuid => _id;
    }
}
