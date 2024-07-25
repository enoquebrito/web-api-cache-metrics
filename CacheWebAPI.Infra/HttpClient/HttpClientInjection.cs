using CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.HttpClient;

public static class HttpClientInjection
{
    public static IServiceCollection AddHttpHandlers(this IServiceCollection services)
    {
        return services.AddSingleton<ResponseLoggerHandler>();
    }
}