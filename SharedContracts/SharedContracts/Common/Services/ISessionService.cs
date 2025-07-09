using PureDelivery.Shared.Contracts.Domain.Enums;
using PureDelivery.Shared.Contracts.DTOs.Session;

namespace PureDelivery.Shared.Contracts.Common.Services
{
    public interface ISessionService
    {
        /// <summary>
        /// Получить полную сессию по ID
        /// </summary>
        Task<SessionDto?> GetSessionAsync(string sessionId);

        /// <summary>
        /// Создать новую сессию
        /// </summary>
        Task<SessionDto> CreateSessionAsync(string userId);

        /// <summary>
        /// Обновить состояние заказа в сессии
        /// </summary>
        Task<bool> UpdateOrderStateAsync(string sessionId, OrderStateDto orderState);

        /// <summary>
        /// Добавить/обновить информацию о ресторане в сессии
        /// </summary>
        Task<bool> UpdateRestaurantAsync(string sessionId, RestaurantSessionDto restaurant);

        /// <summary>
        /// Добавить товар в корзину
        /// </summary>
        Task<bool> AddItemToCartAsync(string sessionId, OrderItemSessionDto item);

        /// <summary>
        /// Удалить товар из корзины
        /// </summary>
        Task<bool> RemoveItemFromCartAsync(string sessionId, string itemId);

        /// <summary>
        /// Обновить количество товара в корзине
        /// </summary>
        Task<bool> UpdateItemQuantityAsync(string sessionId, string itemId, int quantity);

        /// <summary>
        /// Очистить корзину
        /// </summary>
        Task<bool> ClearCartAsync(string sessionId);

        /// <summary>
        /// Обновить информацию о доставке
        /// </summary>
        Task<bool> UpdateDeliveryInfoAsync(string sessionId, DeliveryInfoDto deliveryInfo);

        /// <summary>
        /// Обновить информацию о платеже
        /// </summary>
        Task<bool> UpdatePaymentInfoAsync(string sessionId, PaymentInfoDto paymentInfo);

        /// <summary>
        /// Обновить статус заказа
        /// </summary>
        Task<bool> UpdateOrderStatusAsync(string sessionId, OrderStatus status);

        /// <summary>
        /// Назначить курьера
        /// </summary>
        Task<bool> AssignCourierAsync(string sessionId, CourierSessionDto courier);

        /// <summary>
        /// Обновить местоположение курьера
        /// </summary>
        Task<bool> UpdateCourierLocationAsync(string sessionId, CourierLocationDto location);

        /// <summary>
        /// Обновить статус доставки
        /// </summary>
        Task<bool> UpdateDeliveryStatusAsync(string sessionId, DeliveryStatus status);

        /// <summary>
        /// Удалить сессию
        /// </summary>
        Task<bool> DeleteSessionAsync(string sessionId);

        /// <summary>
        /// Проверить существование сессии
        /// </summary>
        Task<bool> SessionExistsAsync(string sessionId);

        /// <summary>
        /// Обновить время последней активности
        /// </summary>
        Task<bool> UpdateLastActivityAsync(string sessionId);

        /// <summary>
        /// Получить все активные сессии пользователя
        /// </summary>
        Task<List<SessionDto>> GetUserSessionsAsync(string userId);
    }
}
