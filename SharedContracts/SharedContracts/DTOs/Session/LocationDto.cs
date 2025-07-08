namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class LocationDto
{
    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime? LastUpdated { get; set; }
}