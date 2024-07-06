using CacheWebAPI.Domain.WebServices;
using CacheWebAPI.Infra.WebService.Address.Interfaces;
using CacheWebAPI.Infra.ExtensionMethods;

namespace CacheWebAPI.Infra.WebService.Address;

public class AddressWebService(IAddressApi api) : IAddressWebService
{
    public async Task<Domain.Entities.Address> GetAddressAsync(string zipCode)
    {
        var addressResult = await api.GetAdressAsync(zipCode);
        
        return addressResult.TransformTo<Domain.Entities.Address>();
    }
}