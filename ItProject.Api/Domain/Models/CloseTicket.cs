namespace ItProject.Api.Domain.Models;

/// <summary>
/// Модель для работы с закрытием обращения
/// </summary>
public class CloseTicket
{
    /// <summary>
    /// Почта клиента
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Имя клиента
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Последнее сообщение клиента
    /// </summary>
    public string LastMessage { get; set; }
}