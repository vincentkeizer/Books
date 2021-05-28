using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Books.Catalog.Core.DomainConstructs.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Books.Catalog.Infra.Repositories.Factories
{
    internal static class EntityFactory
    {
        internal static TEntity? Create<TEntity, TEntityState>(TEntityState? state, Func<TEntityState, TEntity> factoryMethod)
        where TEntity : BaseEntity<TEntityState>
        where TEntityState : BaseWrappedEntityState
        {
            if (state == null)
            {
                return null;
            }

            if (state.Entity != null)
            {
                return (TEntity)state.Entity;
            }

            return factoryMethod(state!);
        }
    }
}
