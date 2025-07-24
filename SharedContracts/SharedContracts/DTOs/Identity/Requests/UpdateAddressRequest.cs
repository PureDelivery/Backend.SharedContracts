using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Identity.Requests
{
    public class UpdateAddressRequest
    {
        [Required(ErrorMessage = "Label is required")]
        [MaxLength(100, ErrorMessage = "Label cannot exceed 100 characters")]
        public string Label { get; set; }

        [Required(ErrorMessage = "Full address is required")]
        [MaxLength(500, ErrorMessage = "Full address cannot exceed 500 characters")]
        public string FullAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        [MaxLength(100, ErrorMessage = "City cannot exceed 100 characters")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postal code is required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Postal code must be between 3 and 10 characters")]
        public string PostalCode { get; set; }

        [MaxLength(100, ErrorMessage = "Building cannot exceed 100 characters")]
        public string Building { get; set; }

        [MaxLength(50, ErrorMessage = "Apartment cannot exceed 50 characters")]
        public string Apartment { get; set; }

        [Range(1, 200, ErrorMessage = "Floor must be between 1 and 200")]
        public int? Floor { get; set; }

        [MaxLength(500, ErrorMessage = "Delivery instructions cannot exceed 500 characters")]
        public string DeliveryInstructions { get; set; }

        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90")]
        public decimal? Latitude { get; set; }

        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180")]
        public decimal? Longitude { get; set; }
    }
}
