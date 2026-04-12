namespace PureDelivery.Shared.Contracts.Events.Orders;

public class OrderDeliveredEvent
{
    public string OrderId { get; set; } = string.Empty;
    public string CourierId { get; set; } = string.Empty;
    public DateTime DeliveredAt { get; set; }
}
