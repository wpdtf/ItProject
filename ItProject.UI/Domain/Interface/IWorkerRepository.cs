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

    /// <summary>
    /// �������� ����������� ���������� ����������
    /// </summary>
    /// <param name="orderId">�����</param>
    /// <param name="why">����� ��������</param>
    Task<Order> UpdateDirectionMPAsync(int orderId, bool why);

    /// <summary>
    /// �������� ����������� ������������� �����������
    /// </summary>
    /// <param name="orderId">�����</param>
    /// <param name="why">����� ��������</param>
    Task<Order> UpdateDirectionPCAsync(int orderId, bool why);

    /// <summary>
    /// �������� ����������� ��������� �����������
    /// </summary>
    /// <param name="orderId">�����</param>
    /// <param name="why">����� ��������</param>
    Task<Order> UpdateDirectionSiteAsync(int orderId, bool why);

    /// <summary>
    /// �������� ���� ������
    /// </summary>
    /// <param name="orderId">������ ������</param>
    /// <param name="price">����� ����</param>
    /// <returns></returns>
    Task<Order> SetNewPriceAsync(int orderId, decimal price);
} 