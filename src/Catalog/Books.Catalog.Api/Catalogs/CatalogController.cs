using System.Collections.Generic;
using System.Threading.Tasks;
using Books.Catalog.Api.Catalogs.Queries;
using Books.Catalog.Api.Catalogs.Queries.GetCatalog;
using Books.Catalog.Api.Shared.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Books.Catalog.Api.Catalogs
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IQueryHandler _queryHandler;
        private readonly ICatalogQueryService _catalogQueryService;
        private readonly ILogger<CatalogController> _logger;

        public CatalogController(IQueryHandler queryHandler, ICatalogQueryService catalogQueryService, 
            ILogger<CatalogController> logger)
        {
            _queryHandler = queryHandler;
            _catalogQueryService = catalogQueryService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CatalogListItem>>> Get([FromQuery] GetCatalogQuery query)
            => await _queryHandler.ExecuteAsync(query, _catalogQueryService.Get, _logger);
    }
}
