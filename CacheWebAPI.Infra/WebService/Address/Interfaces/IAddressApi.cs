using Refit;

namespace CacheWebAPI.Infra.WebService.Address.Interfaces;

public interface IAddressApi
{
    [Get("/ws/{zip_code}/json")]
    Task<Models.AddressResponse> GetAdressAsync(
        [AliasAs("zip_code")] string zipCode
        );
}