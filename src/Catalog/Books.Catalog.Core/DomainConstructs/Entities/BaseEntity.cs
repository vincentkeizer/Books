namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public class BaseEntity<T> : IEntity where T:IEntityState
    {
        private readonly T _entityState;

        public BaseEntity(T entityState)
        {
            _entityState = entityState;
            SetEntityOnState();
        }

        protected void SetEntityOnState() => _entityState.Entity = this;

        public T InternalState => _entityState;
    }
}
