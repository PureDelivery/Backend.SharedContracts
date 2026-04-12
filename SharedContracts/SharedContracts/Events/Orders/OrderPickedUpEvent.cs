namespace PureDelivery.Shared.Contracts.Events.Orders;

public class OrderPickedUpEvent
{
    public string OrderId { get; set; } = string.Empty;
    public string CourierId { get; set; } = string.Empty;
    public DateTime PickedUpAt { get; set; }
}
