using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для сотрудника
/// </summary>
public class Worker
{
    /// <summary>
    /// Ключ сотрудника
    /// </summary>
    [DisplayName("ИдСотрудника")]
    [Browsable(false)]
    public int WorkerId { get; set; }

    /// <summary>
    /// Фамилия сотрудника
    /// </summary>
    [DisplayName("Фамилия сотрудника")]
    public string FirstName { get; set; }

    /// <summary>
    /// Имя сотрудника
    /// </summary>
    [DisplayName("Имя сотрудника")]
    public string LastName { get; set; }

    /// <summary>
    /// Позиция сотрудника
    /// </summary>
    [DisplayName("Позиция сотрудника")]
    public string Position { get; set; }

    /// <summary>
    /// Телефон сотрудника
    /// </summary>
    [DisplayName("Телефон сотрудника")]
    public string Phone { get; set; }

    /// <summary>
    /// Дата начала работы сотрудника
    /// </summary>
    [DisplayName("Дата начала работы сотрудника")]
    public DateTime DateStart { get; set; }
}
