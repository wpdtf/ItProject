using ItProject.Api.Domain.Models;

namespace ItProject.Api.Domain.Interface;

/// <summary>
/// ����� ����������� ��� �������
/// </summary>
public interface IRepository
{
    /// <summary>
    /// ����� ��� �������� ������ �� �����������
    /// </summary>
    /// <param name="login">����� ��� �����������</param>
    /// <param name="passwordHash">������</param>
    Task<AuthResult> AuthenticateAsync(string login, string passwordHash);

    /// <summary>
    /// ����������� �������
    /// </summary>
    /// <param name="registration">������ ��� �����������</param>
    Task RegistrationAsync(RegistrationDTO registration);

    /// <summary>
    /// ������� ��� ��� �������������� ������
    /// </summary>
    /// <param name="login">��� ����� �����</param>
    Task<NewCode> CreateCodeAsync(string login);

    /// <summary>
    /// ��������� ���
    /// </summary>
    /// <param name="login">��� ����� �����</param>
    /// <param name="code">����� ���</param>
    Task<IsResult> CheckCodeAsync(string login, int code);

    /// <summary>
    /// ���������� ������
    /// </summary>
    /// <param name="login">��� ������ ������</param>
    /// <param name="passwordHash">�� ����� ������</param>
    /// <returns></returns>
    Task UpdatePasswordAsync(string login, string passwordHash);

    /// <summary>
    /// ������� ���������
    /// </summary>
    /// <param name="idOrder">�� ������ ������</param>
    Task<CloseTicket> CloseTicketAsync(int idOrder);
} 