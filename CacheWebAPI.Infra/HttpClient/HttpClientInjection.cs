using CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.HttpClient;

public static class HttpClientInjection
{
    private static void RegisterHttpClientServices(this IServiceCollection services)
    {
        _ = services.AddMessageHandlers();
    }
}