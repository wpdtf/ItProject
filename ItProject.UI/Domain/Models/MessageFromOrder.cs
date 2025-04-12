namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для сообщений
/// </summary>
public class MessageFromOrder
{
    /// <summary>
    /// Ид Сообщения
    /// </summary>
    public int IdMessage { get; set; }

    /// <summary>
    /// Текст сообщения
    /// </summary>
    public string TextMessage { get; set; }

    /// <summary>
    /// Дата отправки сообщения
    /// </summary>
    public DateTime DateSendMessage { get; set; }

    /// <summary>
    /// Имя отправителя
    /// </summary>
    /// <remarks>
    /// Если отсутствует, значит это тот кто получает список
    /// </remarks>
    public string NameCompanion { get; set; }

    /// <summary>
    /// Видели ли участники беседы сообщение
    /// </summary>
    public bool IsVisible { get; set; }
}
