using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.Events.Restaurant
{
    public class NewMenuItemAddedEvent
    {
        public Guid MenuItemId { get; set; }
        public Guid RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Category { get; set; }
        public int CaloriesPer100g { get; set; }
        public decimal ProteinPer100g { get; set; }
        public decimal FatPer100g { get; set; }
        public decimal CarbsPer100g { get; set; }
        public int WeightGrams { get; set; }
        public int Allergens { get; set; }
        public int DietaryTags { get; set; }
        public bool IsPopular { get; set; }
        public bool IsRecommended { get; set; }
        public decimal Price { get; set; }
    }
}