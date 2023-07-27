using RoutesApi.Contracts;
using RoutesApi.Enums;
using RoutesApi.TestData;
using System;

namespace RoutesApi.Services
{
    public class ProviderTwoSearchService : ISearchService
    {
        public ProviderType providerType => ProviderType.ProviderTwo;

        private RoutesBuilder routesBuilder = new RoutesBuilder();

        public ISearchResponse Search(ISearchRequest request, bool isOnlyCached)
        {
            // Search by this provider
            return new ProviderTwoSearchResponse()
            {
                Routes = isOnlyCached ? routesBuilder.RoutesByFilterFromCache().Build() : routesBuilder.RoutesByFilter().Build(),
                Provider = providerType.ToString(),
                IsFromCache = isOnlyCached
            };
        }

        public bool Ping()
        {
            // Availability check
            return Random.Shared.Next(2) == 1;
        }
    }
}
