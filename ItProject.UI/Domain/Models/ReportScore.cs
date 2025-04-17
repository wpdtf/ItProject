using System.ComponentModel;

namespace ItProject.UI.Domain.Models;

/// <summary>
/// ������ ��� ������ ������
/// </summary>
public class ReportScore
{
    /// <summary>
    /// ���� ������
    /// </summary>
    [Browsable(false)]
    public int OrderId { get; set; }

    /// <summary>
    /// ���� �������
    /// </summary>
    [Browsable(false)]
    public int ClientId { get; set; }

    /// <summary>
    /// ��� ����� � ������� �����������
    /// </summary>
    [DisplayName("���������� ��� ����������")]
    public bool IsWin { get; set; }

    /// <summary>
    /// ��� ����� � ��������� �����������
    /// </summary>
    [DisplayName("���������� ��� ���������� ����������")]
    public bool IsMp { get; set; }

    /// <summary>
    /// ��� ����� � ������
    /// </summary>
    [DisplayName("���������� ��� �����")]
    public bool IsSite { get; set; }

    /// <summary>
    /// ���� ��������
    /// </summary>
    [DisplayName("���� �������� ������")]
    public DateTime DateCreate { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    [DisplayName("���������� ����� �� ������")]
    public decimal Price { get; set; }

    /// <summary>
    /// ������ �� �����
    /// </summary>
    [DisplayName("���������� ������ �� ������")]
    public int Score { get; set; }

    /// <summary>
    /// ����� �������� �������
    /// </summary>
    [DisplayName("������� �������")]
    public string FirstName { get; set; }

    /// <summary>
    /// ����� �������� �������
    /// </summary>
    [DisplayName("��� �������")]
    public string LastName { get; set; }

    /// <summary>
    /// ����� �������� �������
    /// </summary>
    [DisplayName("������� ��� �����")]
    public string Phone { get; set; }
}
