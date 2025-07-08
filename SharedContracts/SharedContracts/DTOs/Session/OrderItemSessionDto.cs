namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class OrderItemSessionDto
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public List<MenuItemOptionDto> SelectedOptions { get; set; } = new();

    public string? SpecialInstructions { get; set; }
}