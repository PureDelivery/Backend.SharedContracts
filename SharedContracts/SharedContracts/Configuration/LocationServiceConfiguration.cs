using PureDelivery.Common.Configuration.Interfaces;

namespace PureDelivery.Shared.Contracts.Configuration;

public class LocationServiceConfiguration : IConfiguration<LocationServiceConfiguration>
{
    public string BaseUrl { get; set; } = string.Empty;

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(BaseUrl))
            throw new ArgumentException("LocationService BaseUrl cannot be empty", nameof(BaseUrl));
    }
}
