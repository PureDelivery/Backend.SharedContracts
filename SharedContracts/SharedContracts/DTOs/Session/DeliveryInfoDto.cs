using PureDelivery.Shared.Contracts.DTOs.SessionDTO;

namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class DeliveryInfoDto
{
    public CustomerAddressSessionDto DeliveryAddress { get; set; }

    public string ContactName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Instructions { get; set; } = string.Empty;
}