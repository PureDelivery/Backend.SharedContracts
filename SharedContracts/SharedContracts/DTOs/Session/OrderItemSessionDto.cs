namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class OrderItemSessionDto
{
    public string Id { get; set; } = string.Empty;

    /// <summary>Denormalized dish name — stored so the cart can display it without extra lookups</summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>Denormalized dish price at time of adding to cart</summary>
    public decimal Price { get; set; }

    /// <summary>Denormalized dish image URL — stored so the cart can display it without extra lookups</summary>
    public string? ImageUrl { get; set; }

    public int Quantity { get; set; }

    public List<MenuItemOptionDto> SelectedOptions { get; set; } = new();

    public string? SpecialInstructions { get; set; }
}