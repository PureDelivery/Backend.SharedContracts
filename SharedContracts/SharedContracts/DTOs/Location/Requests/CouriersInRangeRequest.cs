using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.DTOs.Location.Requests;

public class CouriersInRangeRequest
{
    public double RestaurantLatitude { get; set; }
    public double RestaurantLongitude { get; set; }
    public double DeliveryLatitude { get; set; }
    public double DeliveryLongitude { get; set; }
    public List<CourierLocationData> Couriers { get; set; } = [];
}

public class CourierLocationData
{
    public string CourierUserId { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public VehicleType VehicleType { get; set; }
}
