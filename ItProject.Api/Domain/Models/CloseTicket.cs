namespace ItProject.Api.Domain.Models;

/// <summary>
/// ������ ��� ������ � ��������� ���������
/// </summary>
public class CloseTicket
{
    /// <summary>
    /// ����� �������
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// ��� �������
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// ��������� ��������� �������
    /// </summary>
    public string LastMessage { get; set; }
}