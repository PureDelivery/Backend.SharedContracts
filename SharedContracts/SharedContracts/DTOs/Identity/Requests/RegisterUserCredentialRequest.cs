using PureDelivery.Shared.Contracts.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace PureDelivery.Shared.Contracts.DTOs.Identity.Requests
{
    /// <summary>
    /// Запрос на создание учётных данных пользователя (внутренний endpoint).
    /// Используется RestaurantService и CourierService при создании менеджера / курьера.
    /// </summary>
    public class RegisterUserCredentialRequest
    {
        [Required]
        [EmailAddress]
        [MaxLength(256)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public UserRole Role { get; set; }
    }
}
