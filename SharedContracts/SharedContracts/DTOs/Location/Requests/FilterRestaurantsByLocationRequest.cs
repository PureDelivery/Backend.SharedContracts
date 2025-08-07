using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Location.Requests
{
    public class FilterRestaurantsByLocationRequest
    {
        [Required]
        [Range(-90, 90)]
        public decimal UserLatitude { get; set; }

        [Required]
        [Range(-180, 180)]
        public decimal UserLongitude { get; set; }

        [Required]
        public List<RestaurantLocationData> Restaurants { get; set; } = new();
    }
}
