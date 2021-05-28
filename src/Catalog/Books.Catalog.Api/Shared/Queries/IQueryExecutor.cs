using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Books.Catalog.Api.Shared.Queries
{
    public interface IQueryHandler
    {
        Task<ActionResult<TResult>> ExecuteAsync<TResult, TQuery, TController>(TQuery query, 
                                                                               Func<TQuery, Task<TResult>> queryHandler,
                                                                               ILogger<TController> logger);
    }
}
