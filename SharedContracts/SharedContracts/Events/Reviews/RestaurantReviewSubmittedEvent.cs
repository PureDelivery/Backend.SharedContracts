namespace PureDelivery.Shared.Contracts.Events.Reviews;

public class RestaurantReviewSubmittedEvent
{
    public Guid   ReviewId     { get; set; }
    public Guid   RestaurantId { get; set; }
    public Guid   CustomerId   { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public Guid   OrderId      { get; set; }
    public int    Rating       { get; set; }
    public string? Comment     { get; set; }
    public DateTime CreatedAt  { get; set; }
}
