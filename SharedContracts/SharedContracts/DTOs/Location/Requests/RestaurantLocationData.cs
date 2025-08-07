using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Location.Requests
{
    public class RestaurantLocationData
    {
        public Guid RestaurantId { get; set; }
        public List<DeliveryZoneData> DeliveryZones { get; set; } = new();
    }

    public class DeliveryZoneData
    {
        public Guid ZoneId { get; set; }
        public bool IsActive { get; set; }
        public List<ZonePointData> Points { get; set; } = new();
    }

    public class ZonePointData
    {
        public int Order { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}