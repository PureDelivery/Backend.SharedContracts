using PureDelivery.Common.Configuration.Interfaces;

namespace PureDelivery.Shared.Contracts.Configuration;

public class IdentityServiceConfiguration : IConfiguration<IdentityServiceConfiguration>
{
    public string BaseUrl { get; set; } = string.Empty;

    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(BaseUrl))
            throw new ArgumentException("IdentityService BaseUrl cannot be empty", nameof(BaseUrl));
    }
}
