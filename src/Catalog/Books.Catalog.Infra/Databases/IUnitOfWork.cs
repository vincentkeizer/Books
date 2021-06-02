using System;
using System.Threading.Tasks;

namespace Books.Catalog.Infra.Databases
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
    }
}