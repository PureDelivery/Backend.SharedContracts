using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity
{
    public class CustomerProfileInfoDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string? AvatarUrl { get; set; }
        public string? PreferredPaymentMethod { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class CustomerLoyaltyDto
    {
        public Guid Id { get; set; }
        public decimal LoyaltyPoints { get; set; }
    }


}
