using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.Events.Users
{
    public class RestaurantReviewLeftEvent
    {
        public Guid ReviewId { get; set; }
        public Guid UserId { get; set; }
        public Guid RestaurantId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}
