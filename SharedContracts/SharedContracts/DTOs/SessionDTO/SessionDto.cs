using PureDelivery.Shared.Contracts.DTOs.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.SessionDTO
{
    public class SessionDto
    {
        public string SessionId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public CustomerSessionDto? CustomerSessionDto { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastAccessedAt { get; set; } = DateTime.UtcNow;
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
    }
}
