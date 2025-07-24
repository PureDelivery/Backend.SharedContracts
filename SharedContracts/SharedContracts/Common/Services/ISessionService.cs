using PureDelivery.Shared.Contracts.Domain.Enums;
using PureDelivery.Shared.Contracts.DTOs.Identity.Requests;
using PureDelivery.Shared.Contracts.DTOs.Session;
using PureDelivery.Shared.Contracts.DTOs.SessionDTO;
using SessionDto = PureDelivery.Shared.Contracts.DTOs.SessionDTO.SessionDto;

namespace PureDelivery.Shared.Contracts.Common.Services
{
    public interface ISessionService
    {
        Task<SessionDto?> GetSessionAsync(string sessionId);
        Task<SessionDto> CreateSessionAsync(string userId);
        Task<SessionDto> AddCustomerSessionDataAsync(string sessionId, CustomerSessionDto customerData);
        Task<SessionDto> UpdateCustomerDataAsync(string sessionId, CustomerSessionDto customerData);
        Task<bool> SaveSessionAsync(SessionDto session);

        Task<SessionDto?> GetUserActiveSessionAsync(string userId);
        Task<bool> DeleteAllUserSessionsAsync(string userId);
        Task<bool> DeleteSessionAsync(string sessionId);
        Task<SessionValidationResult> IsSessionValidAsync(string sessionId, string userIP, string userAgent);
        Task<SessionDto> CreateSessionWithDataAsync(string userId, CustomerSessionDto customerData, AuthenticateRequest authenticateRequest);
    }
}
