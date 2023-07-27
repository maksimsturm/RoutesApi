using RoutesApi.Contracts;
using RoutesApi.Enums;
using RoutesApi.Extentions;
using RoutesApi.Services;

namespace RoutesApi
{
    public class SearchingEngine
    {
        private readonly ISearchServiceFactory _searchServiceFactory;

        private readonly ISearchService _searchService;

        public SearchingEngine(ProviderType providerType)
        {
            var serviceCollection = new ServiceCollection().AddServices();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            _searchServiceFactory = serviceProvider.GetService<ISearchServiceFactory>();
            _searchService = _searchServiceFactory.GetSearchService(providerType);
        }

        public ISearchResponse Search(ISearchRequest request)
        {
            return _searchService.Search(request, request.Filters.OnlyCached);
        }

        public bool CheckAvailability()
        {
            return _searchService.Ping();
        }
    }
}
