using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Requests
{
    public class LocationRequestBase
    {
        [Required]
        [Range(-90, 90)]
        public decimal Latitude { get; set; }

        [Required]
        [Range(-180, 180)]
        public decimal Longitude { get; set; }
    }
}
