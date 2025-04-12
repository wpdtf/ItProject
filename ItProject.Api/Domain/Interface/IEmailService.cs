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
}
