namespace ItProject.Api.Domain.Interface;

public interface IEmailService
{
    /// <summary>
    /// Отправка почта по адресу
    /// </summary>
    /// <param name="emailAddres">Почта для отправки</param>
    /// <param name="name">ФИО получателя</param>
    /// <param name="code">Код для отправки</param>
    Task PasswordRecoveryAsync(string emailAddres, string name, int code);

    /// <summary>
    /// Закрыть обращение
    /// </summary>
    /// <param name="emailAddres">Почта для отправки</param>
    /// <param name="name">ФИО получателя</param>
    /// <param name="nameTicket">Обращение которое закрыли</param>
    /// <param name="lastMessage">Сообщение для отправки</param>
    /// <returns></returns>
    Task CloseTicketAsync(string emailAddres, string name, string nameTicket, string lastMessage);

    /// <summary>
    /// Согласовали проект
    /// </summary>
    /// <param name="emailAddres">Почта для отправки</param>
    /// <param name="name">ФИО получателя</param>
    /// <param name="nameTicket">Обращение которое закрыли</param>
    /// <param name="price">Стоимость проекта</param>
    Task SetAgreementOrderAsync(string emailAddres, string name, string nameTicket, decimal price);

    /// <summary>
    /// Заказ разработан
    /// </summary>
    /// <param name="emailAddres">Почта для отправки</param>
    /// <param name="name">ФИО получателя</param>
    /// <param name="nameTicket">Обращение которое закрыли</param>
    Task SetAcceptanceOrderAsync(string emailAddres, string name, string nameTicket);

    /// <summary>
    /// Заказ запустили
    /// </summary>
    /// <param name="emailAddres">Почта для отправки</param>
    /// <param name="name">ФИО получателя</param>
    /// <param name="nameTicket">Обращение которое закрыли</param>
    Task SetSuccessAsync(string emailAddres, string name, string nameTicket);
}
