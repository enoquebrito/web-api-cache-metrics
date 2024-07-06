using CacheWebAPI.Domain.Entities;

namespace CacheWebAPI.Domain.WebServices;

public interface IAddressWebService
{
    Task<Address> GetAddressAsync(string zipCode);
}