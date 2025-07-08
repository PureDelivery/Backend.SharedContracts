namespace PureDelivery.Shared.Contracts.Events.Orders;

public class OrderCreatedEvent
{
    public string OrderId { get; set; } = string.Empty;

    public string UserId { get; set; } = string.Empty;

    public string RestaurantId { get; set; } = string.Empty;

    public decimal TotalAmount { get; set; }

    public DateTime CreatedAt { get; set; }

    public string SessionId { get; set; } = string.Empty;
}