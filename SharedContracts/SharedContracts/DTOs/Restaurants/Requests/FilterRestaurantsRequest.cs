using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Requests
{
    public class FilterRestaurantsRequest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<string>? CuisineTypes { get; set; }
        public List<string>? Tags { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
