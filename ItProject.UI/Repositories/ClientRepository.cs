using ItProject.UI.Domain.Interface;

namespace ItProject.UI.Infrastructure.Repositories;

public class ClientRepository(DataBaseContext dbContext) : IClientRepository
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    /// <inheritdoc/>
    public async Task<List<Order>> GetListOrderClientAsync(int clientId)
    {
        var sql = @$"exec dbo.ЗаказыКлиента @Ид = {clientId}";
        var result = await connection.QueryAsync<Order>(sql);
        return result.ToList();
    }

    /// <inheritdoc/>
    public async Task<Order> GetOrderClientAsync(int orderId)
    {
        var sql = @$"exec dbo.ПолучениеЗаказаКлиента @Ид = {orderId}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> SetNextStatusOrderAsync(int orderId)
    {
        var sql = @$"exec dbo.ТолкнутьЗаказКлиенту @Ид = {orderId}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> CreateNewMessageStatusAsync(int orderId)
    {
        var sql = @$"exec dbo.СоздатьОбращениеКлиенту @Ид = {orderId}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<List<MessageFromOrder>> GetListMessageClientAsync(int orderId)
    {
        var sql = @$"exec dbo.ПросмотретьСообщенияПоЗаказуКлиенту @Ид = {orderId}";
        var result = await connection.QueryAsync<MessageFromOrder>(sql);
        return result.ToList();
    }

    /// <inheritdoc/>
    public async Task<MessageFromOrder> GetMessageClientAsync(int messageId)
    {
        var sql = @$"exec dbo.ПолучитьСообщение @Ид = {messageId}";
        var result = (await connection.QueryAsync<MessageFromOrder>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task SendMessageAsync(int idClient, int idOrder, string message)
    {
        var sql = @$"exec dbo.ОтправитьСообщениеСотруднику @ИдКлиент = {idClient}, @ИдЗаказа = {idOrder}, @Текст = N'{message}'";
        await connection.ExecuteAsync(sql);
    }

    /// <inheritdoc/>
    public async Task CreateOrderAsync(int idClient, string message)
    {
        var sql = @$"exec dbo.СоздатьЗадание @ИдКлиента = {idClient}, @Текст = N'{message}'";
        await connection.ExecuteAsync(sql);
    }

    /// <inheritdoc/>
    public async Task<Order> SetScore(int orderId, int Score)
    {
        var sql = @$"exec dbo.ПоставитьОценкуЗаказу @Ид = {orderId}, @Оценка = {Score}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }
}