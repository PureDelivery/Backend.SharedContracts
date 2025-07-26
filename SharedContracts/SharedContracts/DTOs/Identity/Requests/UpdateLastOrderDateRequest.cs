using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity.Requests
{

    public class UpdateLastOrderDateRequest
    {
        [Required]
        public DateTime OrderDate { get; set; }
    }
}
