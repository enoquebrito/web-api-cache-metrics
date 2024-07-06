using CacheWebAPI.Infra.WebService.Address;
using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.WebService;

public static class WebServiceInjection
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        return services
            .AddAddressWebService();
    }
}