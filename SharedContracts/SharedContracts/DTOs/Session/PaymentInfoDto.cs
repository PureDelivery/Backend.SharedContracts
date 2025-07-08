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
}