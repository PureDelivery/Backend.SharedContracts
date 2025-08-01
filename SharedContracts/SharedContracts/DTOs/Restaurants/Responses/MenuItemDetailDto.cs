using PureDelivery.Shared.Contracts.DTOs.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Responses
{
    public class MenuItemDetailDto
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string MenuCategory { get; set; }
        public bool IsAvailable { get; set; }
        public int PreparationTimeMinutes { get; set; }
        public bool IsPopular { get; set; }
        public bool IsRecommended { get; set; }
        public bool IsNew { get; set; }
        public NutritionInfoDto? Nutrition { get; set; }
        public List<MenuItemOptionDto> Options { get; set; } = new();
    }

    public class NutritionInfoDto
    {
        public int CaloriesPer100g { get; set; }
        public decimal ProteinPer100g { get; set; }
        public decimal FatPer100g { get; set; }
        public decimal CarbsPer100g { get; set; }
        public int WeightGrams { get; set; }
        public List<string> Allergens { get; set; }
        public List<string> DietaryTags { get; set; }
    }

    public class MenuItemOptionDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string OptionType { get; set; }
        public bool IsRequired { get; set; }
        public List<OptionChoiceDto> Choices { get; set; } = new();
    }

    public class OptionChoiceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal PriceModifier { get; set; }
        public bool IsDefault { get; set; }
        public bool IsAvailable { get; set; }
    }
}
