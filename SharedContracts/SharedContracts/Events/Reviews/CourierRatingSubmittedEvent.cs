namespace PureDelivery.Shared.Contracts.Events.Reviews;

public class CourierRatingSubmittedEvent
{
    public Guid   RatingId          { get; set; }
    public Guid   CourierId         { get; set; }
    public Guid   RatedByCustomerId { get; set; }
    public string CustomerName      { get; set; } = string.Empty;
    public Guid   OrderId           { get; set; }
    public int    Score             { get; set; }
    public string Comment           { get; set; } = string.Empty;
    public DateTime CreatedAt       { get; set; }
}
