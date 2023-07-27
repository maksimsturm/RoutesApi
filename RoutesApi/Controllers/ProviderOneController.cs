using RoutesApi.Contracts;
using RoutesApi.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RoutesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProviderOneController : ProviderControllerBase
    {
        private static ProviderType providerType = ProviderType.ProviderOne;

        public ProviderOneController() : base(providerType)
        {
        }

        [HttpGet]
        public async Task<ActionResult<ProviderOneSearchResponse>> SearchForRoutes([System.Web.Http.FromBody] ProviderOneSearchRequest request)
        {
            if (_searchingEngine == null || !_searchingEngine.CheckAvailability())
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            return new OkObjectResult(_searchingEngine.Search(request));
        }
    }
}
