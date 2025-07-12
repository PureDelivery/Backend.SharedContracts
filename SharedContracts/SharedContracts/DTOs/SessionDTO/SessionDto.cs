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
        public CustomerSessionDto? CustomerSessionDto { get; set; }
    }
}
