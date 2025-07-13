using PureDelivery.Shared.Contracts.Domain.Enums;
using PureDelivery.Shared.Contracts.DTOs.Session;
using PureDelivery.Shared.Contracts.DTOs.SessionDTO;
using SessionDto = PureDelivery.Shared.Contracts.DTOs.SessionDTO.SessionDto;

namespace PureDelivery.Shared.Contracts.Common.Services
{
    public interface ISessionService
    {
        Task<SessionDto?> GetSessionAsync(string sessionId);
        Task<SessionDto> CreateSessionAsync(string userId);
        Task<bool> AddCustomerSessionDataAsync(string sessionId, CustomerSessionDto customerData);
        Task<bool> UpdateCustomerDataAsync(string sessionId, CustomerSessionDto customerData);
        Task<bool> SaveSessionAsync(SessionDto session);
    }
}
