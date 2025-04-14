using ItProject.UI.Domain.Models;

namespace ItProject.UI.Domain.Interface;

/// <summary>
/// ����������� ��� ������� ����������
/// </summary>
public interface IWorkerRepository
{
    /// <summary>
    /// ��������� ������� ��� �����������
    /// </summary>
    /// <param name="workerId">������ ����������</param>
    Task<List<Order>> GetListOrderWorkerAsync(int workerId);

    /// <summary>
    /// ��������� ���������� ������� ��� ���������� ��� ������������
    /// </summary>
    /// <param name="orderId">������ ������</param>
    Task<Order> GetOrderWorkerAsync(int orderId);

    /// <summary>
    /// �������� ��������� ������� �� ������
    /// </summary>
    /// <param name="orderId">������ ������</param>
    Task<List<MessageFromOrder>> GetListMessageWorkerAsync(int orderId);

    /// <summary>
    /// �������� ���������
    /// </summary>
    /// <param name="messageId">�����</param>
    Task<MessageFromOrder> GetMessageWorkerAsync(int messageId);

    /// <summary>
    /// ��������� ���������
    /// </summary>
    /// <param name="idClient">����</param>
    /// <param name="idOrder">�� ������ ������</param>
    /// <param name="message"></param>
    /// <returns></returns>
    Task SendMessageAsync(int idClient, int idOrder, string message);

    /// <summary>
    /// �������� �������� ����������
    /// </summary>
    /// <param name="orderId">����� �����</param>
    /// <param name="description">��������</param>
    Task<Order> SetNewDescriptionAsync(int orderId, string description);

    /// <summary>
    /// �������� ������ �� ��������� ���
    /// </summary>
    /// <param name="orderId">����� ������</param>
    Task<Order> SetNextStatusOrderAsync(int orderId);
} 