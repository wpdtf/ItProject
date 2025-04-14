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

    /// <summary>
    /// Обновить направление мобильного приложения
    /// </summary>
    /// <param name="orderId">заказ</param>
    /// <param name="why">новое значение</param>
    Task<Order> UpdateDirectionMPAsync(int orderId, bool why);

    /// <summary>
    /// Обновить направление компьютерного направления
    /// </summary>
    /// <param name="orderId">заказ</param>
    /// <param name="why">новое значение</param>
    Task<Order> UpdateDirectionPCAsync(int orderId, bool why);

    /// <summary>
    /// Обновить направление сайтового направления
    /// </summary>
    /// <param name="orderId">заказ</param>
    /// <param name="why">новое значение</param>
    Task<Order> UpdateDirectionSiteAsync(int orderId, bool why);

    /// <summary>
    /// Обновить цену заказа
    /// </summary>
    /// <param name="orderId">какого заказа</param>
    /// <param name="price">Новая цена</param>
    /// <returns></returns>
    Task<Order> SetNewPriceAsync(int orderId, decimal price);
} 