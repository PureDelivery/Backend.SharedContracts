using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity
{
    public class AuthDto
    {
        public Guid CustomerId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string SessionId { get; set; } = string.Empty;
        public DateTime AuthenticatedAt { get; set; } = DateTime.UtcNow;
        public CustomerProfileDto? Profile { get; set; }
    }
}
