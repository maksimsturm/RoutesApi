using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.DependencyInjection;
using RoutesApi.Services;

namespace RoutesApi.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddTransient<ISearchService, ProviderOneSearchService>()
                .AddTransient<ISearchService, ProviderTwoSearchService>()
                .AddTransient<ISearchServiceFactory, SearchServiceFactory>();
        }
    }
}
