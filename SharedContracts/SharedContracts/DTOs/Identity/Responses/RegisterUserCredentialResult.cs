using PureDelivery.Shared.Contracts.Domain.Enums;

namespace PureDelivery.Shared.Contracts.DTOs.Identity.Responses
{
    /// <summary>
    /// Результат регистрации учётных данных через внутренний endpoint IdentityService.
    /// </summary>
    public class RegisterUserCredentialResult
    {
        public Guid UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public UserRole Role { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
