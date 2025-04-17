using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для отчета дохода
/// </summary>
public class ReportScore
{
    /// <summary>
    /// Ключ заказа
    /// </summary>
    [Browsable(false)]
    public int OrderId { get; set; }

    /// <summary>
    /// Ключ клиента
    /// </summary>
    [Browsable(false)]
    public int ClientId { get; set; }

    /// <summary>
    /// Это заказ с виндовс приложенеим
    /// </summary>
    [DisplayName("Приложение для компьютера")]
    public bool IsWin { get; set; }

    /// <summary>
    /// Это заказ с мобильным приложением
    /// </summary>
    [DisplayName("Приложение для мобильного устройства")]
    public bool IsMp { get; set; }

    /// <summary>
    /// Это заказ с сайтом
    /// </summary>
    [DisplayName("Приложение для сайта")]
    public bool IsSite { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    [DisplayName("Дата создания заявки")]
    public DateTime DateCreate { get; set; }

    /// <summary>
    /// Цена
    /// </summary>
    [DisplayName("Полученная сумма по заявке")]
    public decimal Price { get; set; }

    /// <summary>
    /// Оценка по заказ
    /// </summary>
    [DisplayName("Полученная оценка по заявке")]
    public int Score { get; set; }

    /// <summary>
    /// номер телефона клиента
    /// </summary>
    [DisplayName("Фамилия клиента")]
    public string FirstName { get; set; }

    /// <summary>
    /// номер телефона клиента
    /// </summary>
    [DisplayName("Имя клиента")]
    public string LastName { get; set; }

    /// <summary>
    /// номер телефона клиента
    /// </summary>
    [DisplayName("Телефон для связи")]
    public string Phone { get; set; }
}
