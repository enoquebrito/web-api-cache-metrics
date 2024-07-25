using CacheWebAPI.Domain.WebServices;
using CacheWebAPI.Infra.HttpClient;
using CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;
using CacheWebAPI.Infra.WebService.Address.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace CacheWebAPI.Infra.WebService.Address;

public static class AddressWebServiceInjection
{
    public static IServiceCollection AddAddressWebService(this IServiceCollection services)
    {
        _ = services
            .AddScoped<IAddressWebService, AddressWebService>()
            .AddHttpHandlers()
            .AddRefitClient<IAddressApi>()
            .AddHttpMessageHandler<ResponseLoggerHandler>()
            .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://viacep.com.br"));

        return services;
    }
}