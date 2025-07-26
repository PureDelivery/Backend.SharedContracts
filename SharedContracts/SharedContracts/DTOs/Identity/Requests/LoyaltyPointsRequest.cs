using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity.Requests
{
    public class LoyaltyPointsRequest
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Points must be greater than zero")]
        public decimal Points { get; set; }

        [Required]
        [MaxLength(200)]
        public string Reason { get; set; } = string.Empty;
    }
}
