using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity.Requests
{
    public class GradeCustomerRequest
    {
        [Required]
        [Range(1, 5, ErrorMessage = "Grade must be between 1 and 5")]
        public int Grade { get; set; }
    }
}
