using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Responses
{
    public class RestaurantDetailDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public List<string> CuisineTypes { get; set; }
        public List<string> Tags { get; set; }
        public List<RestaurantReviewDto> RestaurantReviews { get; set; }

        public decimal AverageRating { get; set; }
        public int ReviewCount { get; set; }

        public int EstimatedDeliveryMinutes { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal MinOrderAmount { get; set; }
        public bool IsOpen { get; set; }
        public bool IsFeatured { get; set; }
        public bool ParticipatesInLoyalty { get; set; }
        public RestaurantAddressDto Address { get; set; } = new();
        public RestaurantSettingsDto Settings { get; set; } = new();
        public List<WorkingHoursDto> WorkingHours { get; set; } = new();
    }

    public class RestaurantReviewDto
    {
        public int Rating { get; set; }

        public string? Comment { get; set; }
    }

    public class RestaurantAddressDto
    {
        public string FullAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class RestaurantSettingsDto
    {
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;
        public int AveragePreparationMinutes { get; set; }
        public int MaxPreparationMinutes { get; set; }
        public bool AcceptPreOrders { get; set; }
        public int MaxPreOrderDays { get; set; }
    }

    public class WorkingHoursDto
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public bool IsClosed { get; set; }
    }

}
