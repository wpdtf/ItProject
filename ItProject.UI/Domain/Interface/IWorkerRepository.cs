using ItProject.UI.Domain.Models;

namespace ItProject.UI.Domain.Interface;

/// <summary>
/// Репозиторий для методов сотрудника
/// </summary>
public interface IWorkerRepository
{
    /// <summary>
    /// Получение заданий для сотрудников
    /// </summary>
    /// <param name="workerId">Какого сотрудника</param>
    Task<List<Order>> GetListOrderWorkerAsync(int workerId);

    /// <summary>
    /// Получение отдельного задания для сотрудника для актуализации
    /// </summary>
    /// <param name="orderId">Какого заказа</param>
    Task<Order> GetOrderWorkerAsync(int orderId);

    /// <summary>
    /// Получить сообщения клиента по заказу
    /// </summary>
    /// <param name="orderId">Какому заказу</param>
    Task<List<MessageFromOrder>> GetListMessageWorkerAsync(int orderId);

    /// <summary>
    /// Получить сообщение
    /// </summary>
    /// <param name="messageId">Какое</param>
    Task<MessageFromOrder> GetMessageWorkerAsync(int messageId);

    /// <summary>
    /// Отправить сообщение
    /// </summary>
    /// <param name="idClient">Кому</param>
    /// <param name="idOrder">По какому заказу</param>
    /// <param name="message"></param>
    /// <returns></returns>
    Task SendMessageAsync(int idClient, int idOrder, string message);

    /// <summary>
    /// Обновить описание сотрудника
    /// </summary>
    /// <param name="orderId">Какой заказ</param>
    /// <param name="description">Описание</param>
    Task<Order> SetNewDescriptionAsync(int orderId, string description);

    /// <summary>
    /// Толкнуть заявку на следующий шаг
    /// </summary>
    /// <param name="orderId">Какую заявку</param>
    Task<Order> SetNextStatusOrderAsync(int orderId);
} 