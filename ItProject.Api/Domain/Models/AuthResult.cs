namespace ItProject.Api.Domain.Models;

/// <summary>
/// ������ ��� ������ � ������������
/// </summary>
public class AuthResult
{
    /// <summary>
    /// ��������� ����������
    /// </summary>
    /// <remarks>� ������� ����� �������</remarks>
    public string Position { get; set; }

    /// <summary>
    /// ���� ������������
    /// </summary>
    public int IdUser { get; set; }
}