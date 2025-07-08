namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class SessionDto
{
    public string SessionId { get; set; } = string.Empty;

    public string UserId { get; set; } = string.Empty;

    public OrderStateDto OrderState { get; set; } = new();
}