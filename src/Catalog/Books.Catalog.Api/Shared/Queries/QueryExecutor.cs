using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Books.Catalog.Api.Shared.Queries
{
    public class QueryHandler : IQueryHandler
    {

        public async Task<ActionResult<TResult>> ExecuteAsync<TResult, TQuery, TController>(TQuery query, Func<TQuery, 
                                                                                            Task<TResult>> queryHandler, 
                                                                                            ILogger<TController> logger)
        {
            logger.LogInformation($"Executing query '{nameof(query)}'");
            try
            {
                return new OkObjectResult(await queryHandler(query));
            }
            catch (Exception exception)
            {
                logger.LogError(exception, $"Error executing query '{nameof(query)}'");
                return new BadRequestObjectResult(new { error = exception.Message });
            }
        }
    }
}