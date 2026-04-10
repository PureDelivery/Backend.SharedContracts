using PureDelivery.Shared.Contracts.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureDelivery.Shared.Contracts.DTOs.SessionDTO
{
    public class SessionValidationResult
    {
        public bool IsValid { get; private set; }
        public string? UserId { get; private set; }
        public UserRole Role { get; private set; } = UserRole.Customer;
        public CustomerSessionDto? SessionData { get; private set; }
        public string ErrorMessage { get; private set; } = string.Empty;

        private SessionValidationResult() { }

        public static SessionValidationResult Valid(string userId, CustomerSessionDto? sessionData, UserRole role = UserRole.Customer)
        {
            return new SessionValidationResult
            {
                IsValid = true,
                UserId = userId,
                Role = role,
                SessionData = sessionData
            };
        }

        public static SessionValidationResult Invalid(string errorMessage)
        {
            return new SessionValidationResult
            {
                IsValid = false,
                ErrorMessage = errorMessage
            };
        }
    }

}
