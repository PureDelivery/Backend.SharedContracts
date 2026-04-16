using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.Events.Users
{
    public class AchievementCompletedEvent
    {
        public Guid AchievementDefinitionId { get; set; }
        public Guid UserId { get; set; }
        public string AchievementName { get; set; }
        public string AchievementDescription { get; set; }
        public double LoyaltyPointsBonus { get; set; }
    }
}
