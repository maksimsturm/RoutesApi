using Microsoft.AspNetCore.Mvc;
using RoutesApi.Enums;
using System.Web.Http;

namespace RoutesApi.Controllers
{
    public abstract class ProviderControllerBase : ApiController
    {
        protected readonly SearchingEngine _searchingEngine;

        public ProviderControllerBase(ProviderType providerType) 
        {
            _searchingEngine = new SearchingEngine(providerType);
        }
    }
}
