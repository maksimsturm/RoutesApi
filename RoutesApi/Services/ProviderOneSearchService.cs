using RoutesApi.Contracts;
using RoutesApi.Enums;
using RoutesApi.TestData;

namespace RoutesApi.Services
{
    public class ProviderOneSearchService : ISearchService
    {
        public ProviderType providerType => ProviderType.ProviderOne;

        private RoutesBuilder routesBuilder = new RoutesBuilder();

        public ISearchResponse Search(ISearchRequest request, bool isOnlyCached)
        {
            // Search by this provider
            return new ProviderOneSearchResponse()
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
