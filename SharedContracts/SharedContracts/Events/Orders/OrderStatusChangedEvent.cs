using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.Events.Orders;

public class OrderStatusChangedEvent
{
    public string OrderId { get; set; } = string.Empty;

    public string CustomerId { get; set; } = string.Empty;

    /// <summary>Customer email — carried in event so NotificationService needs no extra HTTP call</summary>
    public string CustomerEmail { get; set; } = string.Empty;

    public string CustomerName { get; set; } = string.Empty;

    public string RestaurantName { get; set; } = string.Empty;

    public OrderStatus OldStatus { get; set; }

    public OrderStatus NewStatus { get; set; }

    public DateTime ChangedAt { get; set; }

    public string ChangedBy { get; set; } = string.Empty;
}