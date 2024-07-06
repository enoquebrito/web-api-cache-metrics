using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;

public static class MessageHandlersInjection
{
    public static IServiceCollection RegisterMessageHandlers(this IServiceCollection services)
    {
        _ = services
            .AddHttpClient<ResponseLoggerHandler>();

        return services;
    }
}