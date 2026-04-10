namespace PureDelivery.Shared.Contracts.Events.Payments;

/// <summary>
/// Published by PaymentService when a payment is successfully processed.
/// Consumed by OrderService, NotificationService, LoyaltyService, etc.
/// </summary>
public class OrderPaidEvent
{
    /// <summary>Unique payment record ID (from PaymentService DB)</summary>
    public Guid PaymentId { get; set; }

    /// <summary>The Redis session ID that was used to initiate the order</summary>
    public string SessionId { get; set; } = string.Empty;

    /// <summary>Restaurant whose order was paid</summary>
    public string RestaurantId { get; set; } = string.Empty;

    /// <summary>Customer who made the payment</summary>
    public string CustomerId { get; set; } = string.Empty;

    /// <summary>Total amount charged</summary>
    public decimal Amount { get; set; }

    /// <summary>0=CreditCard,1=DebitCard,2=PayPal,3=ApplePay,4=GooglePay,5=Cash,6=BankTransfer</summary>
    public int PaymentMethod { get; set; }

    /// <summary>UTC timestamp of payment completion</summary>
    public DateTime PaidAt { get; set; } = DateTime.UtcNow;
}
