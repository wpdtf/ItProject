namespace ItProject.UI.Domain.Models;

/// <summary>
/// ������ ��� �������
/// </summary>
public class Order
{
    /// <summary>
    /// ���� ������
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// �������� ������
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// ������ ������
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// ��� ����� � ������� �����������
    /// </summary>
    public bool IsWin { get; set; }

    /// <summary>
    /// ��� ����� � ��������� �����������
    /// </summary>
    public bool IsMp { get; set; }

    /// <summary>
    /// ��� ����� � ������
    /// </summary>
    public bool IsSite { get; set; }

    /// <summary>
    /// ���� ��������
    /// </summary>
    public DateTime DateCreate { get; set; }

    /// <summary>
    /// ����
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// ����� �� ����������� �����
    /// </summary>
    /// <remarks>
    /// ��������� ������ ���� ������� ��������� �� ������
    /// </remarks>
    public bool IsVisible { get; set; }

    /// <summary>
    /// ������ �� ������
    /// </summary>
    public int Score { get; set; }
}
