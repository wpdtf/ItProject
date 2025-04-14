using ItProject.Api.Domain.Models;

namespace ItProject.Api.Domain.Interface;

/// <summary>
/// Общий репозиторий для методов
/// </summary>
public interface IRepository
{
    /// <summary>
    /// Метод для возврата данных по авторизации
    /// </summary>
    /// <param name="login">Логин для авторизации</param>
    /// <param name="passwordHash">Пароль</param>
    Task<AuthResult> AuthenticateAsync(string login, string passwordHash);

    /// <summary>
    /// Регистрация клиента
    /// </summary>
    /// <param name="registration">Данные для регистрации</param>
    Task RegistrationAsync(RegistrationDTO registration);

    /// <summary>
    /// Создать код для восставноления пароля
    /// </summary>
    /// <param name="login">Для какой почты</param>
    Task<NewCode> CreateCodeAsync(string login);

    /// <summary>
    /// Проверить код
    /// </summary>
    /// <param name="login">Для какой почты</param>
    /// <param name="code">Какой код</param>
    Task<IsResult> CheckCodeAsync(string login, int code);

    /// <summary>
    /// Обновление пароля
    /// </summary>
    /// <param name="login">Для какого логина</param>
    /// <param name="passwordHash">На какой пароль</param>
    /// <returns></returns>
    Task UpdatePasswordAsync(string login, string passwordHash);

    /// <summary>
    /// Закрыть обращение
    /// </summary>
    /// <param name="idOrder">По какому заказу</param>
    Task<CloseTicket> CloseTicketAsync(int idOrder);
} 