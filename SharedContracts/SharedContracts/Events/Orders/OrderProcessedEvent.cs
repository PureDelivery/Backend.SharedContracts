namespace PureDelivery.Shared.Contracts.Events.Orders;

// Published by OrderService after it successfully saves the order
// that was created as a result of a successful payment (OrderPaidEvent).
// This is the single trigger for courier assignment and customer/restaurant notifications.
public class OrderProcessedEvent
{
    public string OrderId { get; set; } = string.Empty;
    public string OrderNumber { get; set; } = string.Empty;
    public string SessionId { get; set; } = string.Empty;

    public string CustomerId { get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public string CustomerName { get; set; } = string.Empty;

    public string RestaurantId { get; set; } = string.Empty;
    public string RestaurantName { get; set; } = string.Empty;

    public decimal TotalAmount { get; set; }
    public decimal DeliveryFee { get; set; }

    public decimal DeliveryLatitude { get; set; }
    public decimal DeliveryLongitude { get; set; }
    public string DeliveryAddress { get; set; } = string.Empty;
    public string DeliveryCity { get; set; } = string.Empty;

    public decimal RestaurantLatitude { get; set; }
    public decimal RestaurantLongitude { get; set; }
    public string RestaurantAddress { get; set; } = string.Empty;
    public string RestaurantCity { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}
