namespace CacheWebAPI.Domain.Entities;

public record Address
{
    public string ZipCode { get; init; }

    public string Street { get; init; }

    public string Complement { get; init; }

    public string Neighborhood { get; init; }

    public string City { get; init; }

    public string State { get; init; }
    
    public string DDD { get; init; }
}