namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class DeliveryInfoDto
{
    public string Address { get; set; } = string.Empty;

    public LocationDto Coordinates { get; set; } = new();

    public string ContactName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Instructions { get; set; } = string.Empty;
}