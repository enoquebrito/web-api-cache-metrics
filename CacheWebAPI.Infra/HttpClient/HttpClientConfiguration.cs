using CacheWebAPI.Infra.HttpClient.MessageHandlers;
using CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;
using CacheWebAPI.Infra.WebService.Address.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace CacheWebAPI.Infra.HttpClient;

public static class HttpClientConfiguration
{
    public static IServiceCollection AddCustomHttpClient(this IServiceCollection services)
    {
        _ = services
            .AddRefitClient<IAddressApi>()
            .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://viacep.com.br"));

        return services;
    }
}