using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.SessionDTO
{
    public class CustomerAddressSessionDto
    {
        public Guid Id { get; set; }
        public string Label { get; set; } = string.Empty;
        public string FullAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Building { get; set; } = string.Empty;
        public string Apartment { get; set; } = string.Empty;
        public string Floor { get; set; } = string.Empty;
    }
}
