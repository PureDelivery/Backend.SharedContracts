using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Responses
{
    public class RestaurantDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> CuisineTypes { get; set; }
        public List<string> Tags { get; set; }

        public decimal Distance { get; set; }
        public EstimatedDelivery EstimatedDeliveryMinutes { get; set; }

        public decimal AverageRating { get; set; }
        public int ReviewCount { get; set; }

        public decimal DeliveryFee { get; set; }
        public decimal MinOrderAmount { get; set; }
        public bool IsFeatured { get; set; }
        public bool ParticipatesInLoyalty { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

}
