namespace Books.Catalog.Core.DomainConstructs.Entities
{
    public interface IEntityState : IHaveEntityId
    {
        IEntity? Entity { get; set; }
    }
}
