using ItProject.UI.Domain.Models;

namespace ItProject.UI.Domain.Interface;

/// <summary>
/// Общий репозиторий для методов
/// </summary>
public interface IClientRepository
{
    /// <summary>
    /// Получение заказов клиента
    /// </summary>
    /// <param name="clientId">Какого клиента</param>
    Task<List<Order>> GetListOrderClientAsync(int clientId);

    /// <summary>
    /// Получение точечного заказа для обновления статуса ассинхронно
    /// </summary>
    /// <param name="orderId">Ид заказа</param>
    Task<Order> GetOrderClientAsync(int orderId);

    /// <summary>
    /// Толкнуть на следующий статус заказ клиенту
    /// </summary>
    /// <param name="orderId">Ид заказа</param>
    Task<Order> SetNextStatusOrderAsync(int orderId);

    /// <summary>
    /// Получить сообщения для чата
    /// </summary>
    /// <param name="orderId">Ид заказа</param>
    Task<List<MessageFromOrder>> GetListMessageClientAsync(int orderId);

    /// <summary>
    /// Получить отдельно взятое сообщение
    /// </summary>
    /// <param name="messageId">Ид сообщения</param>
    Task<MessageFromOrder> GetMessageClientAsync(int messageId);

    /// <summary>
    /// Отправить сообщение сотруднику
    /// </summary>
    /// <param name="idClient">Какой клиент</param>
    /// <param name="idOrder">Какой заказ</param>
    /// <param name="message">Текст сообщения</param>
    Task SendMessageAsync(int idClient, int idOrder, string message);

    /// <summary>
    /// Создать заказ
    /// </summary>
    /// <param name="idClient">Какой клиент</param>
    /// <param name="message">Описание задания</param>
    Task CreateOrderAsync(int idClient, string message);

    /// <summary>
    /// Создать обращение для клиента
    /// </summary>
    /// <param name="orderId">Какой клиент</param>
    Task<Order> CreateNewMessageStatusAsync(int orderId);

    /// <summary>
    /// Поставить оценку заказу
    /// </summary>
    /// <param name="orderId">Какому заказу</param>
    /// <param name="Score">Какую оценку</param>
    /// <returns></returns>
    Task<Order> SetScore(int orderId, int Score);
} 