namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class RestaurantSessionDto
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public LocationDto Location { get; set; } = new();
}