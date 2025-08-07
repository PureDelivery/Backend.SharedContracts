using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Location.Responses
{
    public class FilterRestaurantsByLocationResponse
    {
        public List<DeliverableRestaurant> DeliverableRestaurants { get; set; } = new();
        public List<Guid> NonDeliverableRestaurantIds { get; set; } = new();
    }

    public class DeliverableRestaurant
    {
        public Guid RestaurantId { get; set; }
        public decimal Distance { get; set; }
        public DeliveryZoneMatch BestDeliveryZone { get; set; } = null!;
    }

    public class DeliveryZoneMatch
    {
        public Guid ZoneId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal DeliveryFee { get; set; }
        public decimal MinOrderAmount { get; set; }
        public int EstimatedDeliveryMinutes { get; set; }
        public int Priority { get; set; }
    }
}
