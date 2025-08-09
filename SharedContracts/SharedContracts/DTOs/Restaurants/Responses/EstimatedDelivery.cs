using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Restaurants.Responses
{
    public class EstimatedDelivery
    {
        public int MinMinutes { get; set; }
        public int MaxMinutes { get; set; }
    }
}
