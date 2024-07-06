using System.Net;

namespace CacheWebAPI.Infra.HttpClient.MessageHandlers.Handlers;

public class ResponseLoggerHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Request: {request.Method} {request.RequestUri}");

        var response = await base.SendAsync(request, cancellationToken);

        Console.WriteLine($"Response: {response.StatusCode}");

        if (response.StatusCode is not HttpStatusCode.OK)
        {
            var message = $"Request {request.Method} {request.RequestUri} failed:\nReason: {response.ReasonPhrase}";
            throw new HttpRequestException(message, null, response.StatusCode);
        }

        var content = await response.Content.ReadAsStringAsync(cancellationToken);
        Console.WriteLine($"Response Content: {content}");

        return response;
    }
}
