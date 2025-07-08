namespace PureDelivery.Shared.Contracts.Domain.Enums;

public enum DeliveryStatus
{
    Pending = 0,
    CourierAssigned = 1,
    PickedUp = 2,
    InTransit = 3,
    Delivered = 4
}