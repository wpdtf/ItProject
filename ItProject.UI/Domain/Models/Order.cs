namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для заказов
/// </summary>
public class Order
{
    /// <summary>
    /// Ключ заказа
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Описание заказа
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Описание сотрудника
    /// </summary>
    public string DescriptionWorker { get; set; }

    /// <summary>
    /// Статус заказа
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Это заказ с виндовс приложенеим
    /// </summary>
    public bool IsWin { get; set; }

    /// <summary>
    /// Это заказ с мобильным приложением
    /// </summary>
    public bool IsMp { get; set; }

    /// <summary>
    /// Это заказ с сайтом
    /// </summary>
    public bool IsSite { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime DateCreate { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Нужно ли просмотреть заказ
    /// </summary>
    /// <remarks>
    /// Актуально только если создано обращение по заказу
    /// </remarks>
    public bool IsVisible { get; set; }

    /// <summary>
    /// Оценка по заказ
    /// </summary>
    public int Score { get; set; }

    /// <summary>
    /// номер телефона клиента
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// приоритет заказа
    /// </summary>
    public int Prioritet { get; set; }
}
