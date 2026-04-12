namespace PureDelivery.Shared.Contracts.Domain.Enums;

public enum OrderStatus
{
    Cart = 0,
    Checkout = 1,
    Payment = 2,
    Confirmed = 3,
    InPreparation = 4,
    ReadyForPickup = 5,
    Delivery = 6,
    Completed = 7,
    Cancelled = 8
}