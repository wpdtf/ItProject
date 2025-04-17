using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// ������ ��� ����������
/// </summary>
public class WorkerLogin : Worker
{
    /// <summary>
    /// ����� ����������
    /// </summary>
    [DisplayName("���������������")]
    public string Login { get; set; }

    /// <summary>
    /// ������ ����������
    /// </summary>
    [Browsable(false)]
    public string Password { get; set; }
}
