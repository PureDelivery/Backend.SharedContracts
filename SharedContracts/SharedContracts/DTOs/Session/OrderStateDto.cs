using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class OrderStateDto
{
    public RestaurantSessionDto? Restaurant { get; set; }

    public List<OrderItemSessionDto> Items { get; set; } = new();

    public DeliveryInfoDto? Delivery { get; set; }

    public PaymentInfoDto? Payment { get; set; }

    public OrderStatus Status { get; set; } = OrderStatus.Cart;

    public DateTime CreatedAt { get; set; }

    public DateTime LastUpdated { get; set; }

    public CourierSessionDto? Courier { get; set; }

    public DeliveryStatus DeliveryStatus { get; set; } = DeliveryStatus.Pending;
}