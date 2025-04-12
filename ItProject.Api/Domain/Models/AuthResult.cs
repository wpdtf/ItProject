namespace ItProject.Api.Domain.Models;

/// <summary>
/// Модель для работы с авторизацией
/// </summary>
public class AuthResult
{
    /// <summary>
    /// Должность сотрудника
    /// </summary>
    /// <remarks>У клиента будет пустота</remarks>
    public string Position { get; set; }

    /// <summary>
    /// Ключ пользователя
    /// </summary>
    public int IdUser { get; set; }
}