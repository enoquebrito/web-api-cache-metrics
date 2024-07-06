using CacheWebAPI.Domain.WebServices;
using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.WebService.Address;

public static class AddressWebServiceInjection
{
    public static IServiceCollection AddAddressWebService(this IServiceCollection service)
    {
        return service.AddScoped<IAddressWebService, AddressWebService>();
    }
}