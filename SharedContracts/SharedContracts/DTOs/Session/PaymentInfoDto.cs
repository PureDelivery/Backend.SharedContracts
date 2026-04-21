using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class PaymentInfoDto
{
    public PaymentMethod Method { get; set; }

    public PaymentStatus Status { get; set; }

    public decimal Amount { get; set; }

    public decimal DeliveryFee { get; set; }

    public decimal Discount { get; set; }

    public decimal Total { get; set; }

    /// <summary>Minimum order amount for this restaurant (copied at cart-build time for frontend validation).</summary>
    public decimal MinOrderAmount { get; set; }

    /// <summary>Restaurant loyalty cashback rate in percent (e.g. 5 = 5%). Copied at cart-build time so frontend can show estimated points without extra calls.</summary>
    public decimal LoyaltyPointsRate { get; set; }

    /// <summary>Whether the restaurant participates in the loyalty program.</summary>
    public bool ParticipatesInLoyalty { get; set; }
}