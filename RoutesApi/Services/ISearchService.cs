using RoutesApi.Contracts;
using RoutesApi.Enums;

namespace RoutesApi.Services
{
    public interface ISearchService
    {
        public ProviderType providerType { get; }

        ISearchResponse Search(ISearchRequest request, bool isOnlyCached = false);

        bool Ping();
    }
}
