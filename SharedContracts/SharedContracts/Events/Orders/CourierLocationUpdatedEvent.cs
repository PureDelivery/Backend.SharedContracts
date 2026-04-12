namespace PureDelivery.Shared.Contracts.Events.Orders;

/// <summary>
/// Published by CourierService on every location update while courier has an active delivery.
/// NotificationService pushes it to order-{OrderId} group so the customer sees live courier position.
/// </summary>
public class CourierLocationUpdatedEvent
{
    public string OrderId   { get; set; } = string.Empty;
    public double Latitude  { get; set; }
    public double Longitude { get; set; }
    public DateTime UpdatedAt { get; set; }
}
