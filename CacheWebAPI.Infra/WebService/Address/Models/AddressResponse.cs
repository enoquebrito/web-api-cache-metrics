using System.Text.Json.Serialization;
using CacheWebAPI.Infra.ExtensionMethods;

namespace CacheWebAPI.Infra.WebService.Address.Models;

public struct AddressResponse : ITransformable
{
    [JsonPropertyName("cep")]
    public string ZipCode { get; init; }

    [JsonPropertyName("logradouro")]
    public string Street { get; init; }

    [JsonPropertyName("complemento")]
    public string Complement { get; init; }

    [JsonPropertyName("bairro")]
    public string Neighborhood { get; init; }

    [JsonPropertyName("localidade")]
    public string City { get; init; }

    [JsonPropertyName("uf")]
    public string State { get; init; }
    
    [JsonPropertyName("ddd")]
    public string DDD { get; init; }
}
