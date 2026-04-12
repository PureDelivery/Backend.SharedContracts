namespace PureDelivery.Shared.Contracts.Events.Orders;

public class CourierAssignedEvent
{
    public string OrderId { get; set; } = string.Empty;
    public string CourierId { get; set; } = string.Empty;
    public string CourierUserId { get; set; } = string.Empty;
    public string CourierFirstName { get; set; } = string.Empty;
    public string CourierLastName { get; set; } = string.Empty;
    public string CourierPhone { get; set; } = string.Empty;
    public double? CourierLatitude { get; set; }
    public double? CourierLongitude { get; set; }
    public DateTime AssignedAt { get; set; }
}
