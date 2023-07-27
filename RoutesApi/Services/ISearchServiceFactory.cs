using RoutesApi.Enums;

namespace RoutesApi.Services
{
    public interface ISearchServiceFactory
    {
        ISearchService GetSearchService(ProviderType providerType);
    }
}
