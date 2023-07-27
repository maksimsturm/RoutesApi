using RoutesApi.Enums;
using RoutesApi.Models;

namespace RoutesApi.Contracts
{
    public class ProviderOneSearchResponse : ISearchResponse
    {
        public List<RouteEntity>? Routes { get; set; }

        public string Provider { get; set; }

        public bool IsFromCache { get; set; }
    }
}
