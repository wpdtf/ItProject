using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// ������ ��� ������ ������
/// </summary>
public class ReportAmount
{
    /// <summary>
    /// ����
    /// </summary>
    [DisplayName("����")]
    public DateTime DateCheck { get; set; }

    /// <summary>
    /// ���������� �����
    /// </summary>
    [DisplayName("���������� �����")]
    public decimal MaxSum { get; set; }
}
