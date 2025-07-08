namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class CourierLocationDto : LocationDto
{
    public decimal? Heading { get; set; }

    public decimal? SpeedKmH { get; set; }
}