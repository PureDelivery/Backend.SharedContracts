namespace PureDelivery.Shared.Contracts.Events.Orders;

/// <summary>
/// Published by CourierService when courier confirms pickup (MarkPickedUpAsync).
/// Contains courier details so the customer can see who is delivering their order.
/// Sent to order-{OrderId} SignalR group.
/// </summary>
public class OrderInDeliveryEvent
{
    public string OrderId { get; set; } = string.Empty;

    public string CourierFirstName { get; set; } = string.Empty;
    public string CourierLastName  { get; set; } = string.Empty;
    public string CourierPhone     { get; set; } = string.Empty;

    public double? CourierLatitude  { get; set; }
    public double? CourierLongitude { get; set; }

    public DateTime PickedUpAt { get; set; }
}
