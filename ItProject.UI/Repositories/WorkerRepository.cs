using ItProject.UI.Domain.Interface;

namespace ItProject.UI.Infrastructure.Repositories;

public class WorkerRepository(DataBaseContext dbContext) : IWorkerRepository
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    /// <inheritdoc/>
    public async Task<List<Order>> GetListOrderWorkerAsync(int workerId)
    {
        var sql = @$"exec dbo.ЗаказыСотрудника @Ид = {workerId}";
        var result = await connection.QueryAsync<Order>(sql);
        return result.ToList();
    }

    /// <inheritdoc/>
    public async Task<Order> GetOrderWorkerAsync(int orderId)
    {
        var sql = @$"exec dbo.ПолучениеЗаказаСотрудника @Ид = {orderId}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<List<MessageFromOrder>> GetListMessageWorkerAsync(int orderId)
    {
        var sql = @$"exec dbo.ПросмотретьСообщенияПоЗаказуСотруднику @Ид = {orderId}";
        var result = await connection.QueryAsync<MessageFromOrder>(sql);
        return result.ToList();
    }

    /// <inheritdoc/>
    public async Task<MessageFromOrder> GetMessageWorkerAsync(int messageId)
    {
        var sql = @$"exec dbo.ПолучитьСообщениеСотруднику @Ид = {messageId}";
        var result = (await connection.QueryAsync<MessageFromOrder>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task SendMessageAsync(int idClient, int idOrder, string message)
    {
        var sql = @$"exec dbo.ОтправитьСообщениеКлиенту @ИдСотрудника = {idClient}, @ИдЗаказа = {idOrder}, @Текст = N'{message}'";
        await connection.ExecuteAsync(sql);
    }

    /// <inheritdoc/>
    public async Task<Order> SetNewDescriptionAsync(int orderId, string description)
    {
        var sql = @$"exec dbo.ОбновитьКомментарийСотрудника @Ид = {orderId}, @Комментарий = N'{description}'";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> SetNextStatusOrderAsync(int orderId)
    {
        var sql = @$"exec dbo.ТолкнутьЗаказСотруднику @Ид = {orderId}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> UpdateDirectionMPAsync(int orderId, bool why)
    {
        var sql = @$"exec dbo.ОбновитьНаправлениеМП @Ид = {orderId}, @why = {why}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> UpdateDirectionPCAsync(int orderId, bool why)
    {
        var sql = @$"exec dbo.ОбновитьНаправлениеПК @Ид = {orderId}, @why = {why}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> UpdateDirectionSiteAsync(int orderId, bool why)
    {
        var sql = @$"exec dbo.ОбновитьНаправлениеСайт @Ид = {orderId}, @why = {why}";
        var result = (await connection.QueryAsync<Order>(sql)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<Order> SetNewPriceAsync(int orderId, decimal price)
    {
        var sql = "exec dbo.ОбновитьЦенуЗаказа @Ид, @Цена";
        var parameters = new { Ид = orderId, Цена = price };
        var result = (await connection.QueryAsync<Order>(sql, parameters)).First();
        return result;
    }
}