namespace ItProject.UI.Domain.Models;

/// <summary>
/// ������ ��� ���������
/// </summary>
public class MessageFromOrder
{
    /// <summary>
    /// �� ���������
    /// </summary>
    public int IdMessage { get; set; }

    /// <summary>
    /// ����� ���������
    /// </summary>
    public string TextMessage { get; set; }

    /// <summary>
    /// ���� �������� ���������
    /// </summary>
    public DateTime DateSendMessage { get; set; }

    /// <summary>
    /// ��� �����������
    /// </summary>
    /// <remarks>
    /// ���� �����������, ������ ��� ��� ��� �������� ������
    /// </remarks>
    public string NameCompanion { get; set; }

    /// <summary>
    /// ������ �� ��������� ������ ���������
    /// </summary>
    public bool IsVisible { get; set; }
}
