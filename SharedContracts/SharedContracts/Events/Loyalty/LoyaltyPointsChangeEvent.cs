using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.Events.Loyalty
{
    public class LoyaltyPointsChangeEvent
    {
        public Guid UserId { get; set; }
        public double PointsToChange { get; set; }
    }
}
