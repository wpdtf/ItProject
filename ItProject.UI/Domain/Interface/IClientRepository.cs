using ItProject.UI.Domain.Models;

namespace ItProject.UI.Domain.Interface;

/// <summary>
/// ����� ����������� ��� �������
/// </summary>
public interface IClientRepository
{
    /// <summary>
    /// ��������� ������� �������
    /// </summary>
    /// <param name="clientId">������ �������</param>
    Task<List<Order>> GetListOrderClientAsync(int clientId);

    /// <summary>
    /// ��������� ��������� ������ ��� ���������� ������� �����������
    /// </summary>
    /// <param name="orderId">�� ������</param>
    Task<Order> GetOrderClientAsync(int orderId);

    /// <summary>
    /// �������� �� ��������� ������ ����� �������
    /// </summary>
    /// <param name="orderId">�� ������</param>
    Task<Order> SetNextStatusOrderAsync(int orderId);

    /// <summary>
    /// �������� ��������� ��� ����
    /// </summary>
    /// <param name="orderId">�� ������</param>
    Task<List<MessageFromOrder>> GetListMessageClientAsync(int orderId);

    /// <summary>
    /// �������� �������� ������ ���������
    /// </summary>
    /// <param name="messageId">�� ���������</param>
    Task<MessageFromOrder> GetMessageClientAsync(int messageId);

    /// <summary>
    /// ��������� ��������� ����������
    /// </summary>
    /// <param name="idClient">����� ������</param>
    /// <param name="idOrder">����� �����</param>
    /// <param name="message">����� ���������</param>
    Task SendMessageAsync(int idClient, int idOrder, string message);

    /// <summary>
    /// ������� �����
    /// </summary>
    /// <param name="idClient">����� ������</param>
    /// <param name="message">�������� �������</param>
    Task CreateOrderAsync(int idClient, string message);

    /// <summary>
    /// ������� ��������� ��� �������
    /// </summary>
    /// <param name="orderId">����� ������</param>
    Task<Order> CreateNewMessageStatusAsync(int orderId);

    /// <summary>
    /// ��������� ������ ������
    /// </summary>
    /// <param name="orderId">������ ������</param>
    /// <param name="Score">����� ������</param>
    /// <returns></returns>
    Task<Order> SetScore(int orderId, int Score);
} 