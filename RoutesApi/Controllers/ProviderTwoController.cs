using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutesApi.Contracts;
using RoutesApi.Enums;

namespace RoutesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProviderTwoController : ProviderControllerBase
    {
        private static ProviderType providerType = ProviderType.ProviderTwo;

        public ProviderTwoController() : base(providerType)
        {
        }

        [HttpGet]
        public async Task<ActionResult<ProviderTwoSearchResponse>> SearchForRoutes([System.Web.Http.FromBody] ProviderTwoSearchRequest request)
        {
            if (_searchingEngine == null || !_searchingEngine.CheckAvailability())
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            return new OkObjectResult(_searchingEngine.Search(request));
        }
    }
}
