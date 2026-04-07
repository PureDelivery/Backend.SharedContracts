namespace PureDelivery.Shared.Contracts.DTOs.Session;

public class MenuItemOptionDto
{
    /// <summary>Ідентифікатор опції в меню (legacy / пошук).</summary>
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public MenuOptionType Type { get; set; }

    public decimal AdditionalPrice { get; set; }

    /// <summary>Група опцій (наприклад «Розмір»).</summary>
    public string OptionId { get; set; } = string.Empty;

    public string OptionName { get; set; } = string.Empty;

    /// <summary>Обраний варіант у групі.</summary>
    public string ChoiceId { get; set; } = string.Empty;

    public string ChoiceName { get; set; } = string.Empty;
}
