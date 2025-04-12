namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для регистрации клиента
/// </summary>
public class Registration
{
    /// <summary>
    /// Логин клиента
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль клиента
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string Phone { get; set; }
}
