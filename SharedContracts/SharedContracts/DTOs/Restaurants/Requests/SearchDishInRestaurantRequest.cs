using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Requests
{
    public class SearchDishInRestaurantRequest
    {
        [Required]
        [MinLength(2)]
        public string Query { get; set; } = string.Empty;

        public int Page { get; set; } = 1;

        public int PageSize { get; set; } = 20;
    }
}
