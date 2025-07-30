using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity
{
    public class CustomerSummaryDto
    {
        public Guid Id { get; set; }

        public decimal LoyaltyPoints { get; set; }

        public decimal UserGrade { get; set; }

        public int TotalRatings { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }
    }
}
