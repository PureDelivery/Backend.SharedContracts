namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class CourierSessionDto
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Photo { get; set; } = string.Empty;

    public decimal Rating { get; set; }

    public string Vehicle { get; set; } = string.Empty;

    public CourierLocationDto Location { get; set; } = new();

    public DateTime? EstimatedArrival { get; set; }
}