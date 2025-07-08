using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.Session
{
    public class MenuItemOptionDto
    {
        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public MenuOptionType Type { get; set; }

        public decimal AdditionalPrice { get; set; }
    }
}
