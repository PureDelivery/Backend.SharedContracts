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
        public CustomerSessionDto? SessionData { get; private set; }
        public string ErrorMessage { get; private set; } = string.Empty;

        private SessionValidationResult() { }

        public static SessionValidationResult Valid(string userId, CustomerSessionDto sessionData)
        {
            return new SessionValidationResult
            {
                IsValid = true,
                UserId = userId,
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
