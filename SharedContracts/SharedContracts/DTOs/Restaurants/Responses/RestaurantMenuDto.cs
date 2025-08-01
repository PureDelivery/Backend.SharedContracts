using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Responses
{
    public class RestaurantMenuDto
    {
        public Guid RestaurantId { get; set; }
        public string RestaurantName { get; set; } = string.Empty;
        public List<MenuCategoryDto> Categories { get; set; } = new();
    }

    public class MenuCategoryDto
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public List<MenuItemDto> Items { get; set; } = new();
    }

    public class MenuItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
        public int PreparationTimeMinutes { get; set; }
        public bool IsPopular { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsNew { get; set; }
    }
}
