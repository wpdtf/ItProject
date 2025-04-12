namespace ItProject.Api.Domain.DTO;

/// <summary>
/// Модель для авторизации клиента
/// </summary>
public class AuthDTO
{
    /// <summary>
    /// Логин клиента
    /// </summary>
    public string Login { get; set; }

    /// <summary>
    /// Пароль клиента
    /// </summary>
    public string Password { get; set; }
}
