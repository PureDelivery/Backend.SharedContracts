using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.DTOs.Location.Requests;

public class CouriersInRangeRequest
{
    public decimal RestaurantLatitude { get; set; }
    public decimal RestaurantLongitude { get; set; }
    public decimal DeliveryLatitude { get; set; }
    public decimal DeliveryLongitude { get; set; }
    public List<CourierLocationData> Couriers { get; set; } = [];
}

public class CourierLocationData
{
    public string CourierUserId { get; set; } = string.Empty;
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public VehicleType VehicleType { get; set; }
}
