using CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.HttpClient.MessageHandlers;

public static class MessageHandlersInjection
{
    public static IServiceCollection RegisterMessageHandlers(this IServiceCollection services)
    {
        _ = services
            .AddTransient<ResponseLoggerHandler>();

        return services;
    }
}