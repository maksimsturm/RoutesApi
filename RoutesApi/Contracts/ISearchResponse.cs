using RoutesApi.Enums;
using RoutesApi.Models;

namespace RoutesApi.Contracts
{
    public interface ISearchResponse
    {
        //Added for checking data
        public string Provider { get; set; }

        //Added for checking data
        public bool IsFromCache { get; set; }

        public List<RouteEntity>? Routes { get; set; }
    }
}
