namespace PureDelivery.Shared.Contracts.Events.Orders;

// Published by CourierService after receiving OrderProcessedEvent.
// NotificationService broadcasts this to all online couriers.
public class OrderAvailableEvent
{
    public Guid OrderId { get; set; }
    public Guid RestaurantId { get; set; }
    public string RestaurantName { get; set; } = string.Empty;

    public decimal DeliveryLatitude { get; set; }
    public decimal DeliveryLongitude { get; set; }
    public string DeliveryAddress { get; set; } = string.Empty;
    public string DeliveryCity { get; set; } = string.Empty;

    public decimal RestaurantLatitude { get; set; }
    public decimal RestaurantLongitude { get; set; }

    public decimal DeliveryFee { get; set; }
    public decimal TotalAmount { get; set; }

    public string CustomerName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
