using System.Net;
using Microsoft.Extensions.Logging;

namespace CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;

public class ResponseLoggerHandler(ILogger<ResponseLoggerHandler> logger) : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Request: {Method} - {Uri}", request.Method, request.RequestUri);

        var response = await base.SendAsync(request, cancellationToken);

        logger.LogInformation("Response: {StatusCode}", response.StatusCode);

        if (response.StatusCode is not HttpStatusCode.OK)
        {
            var message = $"Request {request.Method} {request.RequestUri} failed:\nReason: {response.ReasonPhrase}";
            throw new HttpRequestException(message, null, response.StatusCode);
        }

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        logger.LogInformation("Response Content: {Content}", content);

        return response;
    }
}
