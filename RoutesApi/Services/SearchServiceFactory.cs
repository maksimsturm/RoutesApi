using RoutesApi.Enums;

namespace RoutesApi.Services
{
    public class SearchServiceFactory : ISearchServiceFactory
    {
        private readonly IEnumerable<ISearchService> _services;

        public SearchServiceFactory(IEnumerable<ISearchService> services)
        {
            _services = services;
        }

        public ISearchService GetSearchService(ProviderType providerType)
        {
            return _services.First(s => s.providerType == providerType);
        }
    }
}
