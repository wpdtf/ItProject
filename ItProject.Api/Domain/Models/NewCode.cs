namespace ItProject.Api.Domain.Models;

/// <summary>
/// Модель для работы с восстановлением пароля
/// </summary>
public class NewCode
{
    /// <summary>
    /// Код для клиента
    /// </summary>
    public int Code { get; set; }
}