using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.Events.Orders;

public class OrderStatusChangedEvent
{
    public string OrderId { get; set; } = string.Empty;

    public OrderStatus OldStatus { get; set; }

    public OrderStatus NewStatus { get; set; }

    public DateTime ChangedAt { get; set; }

    public string ChangedBy { get; set; } = string.Empty; // Type?
}