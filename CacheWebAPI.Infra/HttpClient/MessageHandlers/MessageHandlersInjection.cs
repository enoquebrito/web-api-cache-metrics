using Microsoft.Extensions.DependencyInjection;

namespace CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;

public static class MessageHandlersInjection
{
    public static IServiceCollection AddMessageHandlers(this IServiceCollection services)
    {
        return services
            .AddScoped<ResponseLoggerHandler>();
    }
}