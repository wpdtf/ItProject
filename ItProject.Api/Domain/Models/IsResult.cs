namespace ItProject.Api.Domain.Models;

/// <summary>
/// Модель для работы с восстановлением пароля
/// </summary>
public class IsResult
{
    /// <summary>
    /// Правильный ли код
    /// </summary>
    public bool IsSuccess { get; set; }
}