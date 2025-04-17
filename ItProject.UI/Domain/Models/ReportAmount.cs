using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для отчета дохода
/// </summary>
public class ReportAmount
{
    /// <summary>
    /// Дата
    /// </summary>
    [DisplayName("Дата")]
    public DateTime DateCheck { get; set; }

    /// <summary>
    /// Полученная сумма
    /// </summary>
    [DisplayName("Полученная сумма")]
    public decimal MaxSum { get; set; }
}
