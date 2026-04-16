using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.Events.Loyalty
{
    public record LoyaltyOrderCreatedEvent
    {
        public Guid OrderId { get; init; }
        public Guid UserId { get; init; }

        public decimal PointsToSpend { get; init; }
    }
}
