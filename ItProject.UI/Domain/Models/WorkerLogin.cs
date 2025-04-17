using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// Модель для сотрудника
/// </summary>
public class WorkerLogin : Worker
{
    /// <summary>
    /// Логин сотрудника
    /// </summary>
    [DisplayName("ЛогинСотрудника")]
    public string Login { get; set; }

    /// <summary>
    /// Пароль сотрудника
    /// </summary>
    [Browsable(false)]
    public string Password { get; set; }
}
