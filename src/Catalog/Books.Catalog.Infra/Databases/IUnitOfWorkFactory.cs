namespace Books.Catalog.Infra.Databases
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
        IUnitOfWork CreateSerializable();
    }
}