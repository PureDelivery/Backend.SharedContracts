namespace PureDelivery.Shared.Contracts.Events.Orders;

/// <summary>
/// Published by CourierService when it detects OrderStatusChangedEvent with status=ReadyForPickup.
/// Targets the assigned courier so their app shows "Order is ready at the restaurant".
/// </summary>
public class CourierOrderReadyEvent
{
    public string OrderId { get; set; } = string.Empty;

    /// <summary>Courier's UserId (from IdentityService) — used to address SignalR group courier-{UserId}.</summary>
    public string CourierUserId { get; set; } = string.Empty;

    public string RestaurantName { get; set; } = string.Empty;

    public DateTime ReadyAt { get; set; }
}
