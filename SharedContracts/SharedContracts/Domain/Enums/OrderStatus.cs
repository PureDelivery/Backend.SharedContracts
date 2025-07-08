namespace PureDelivery.Shared.Contracts.Domain.Enums;

public enum OrderStatus
{
    Cart = 0,
    Checkout = 1,
    Payment = 2,
    Confirmed = 3,
    InPreparation = 4,
    Delivery = 5,
    Completed = 6,
    Cancelled = 7
}