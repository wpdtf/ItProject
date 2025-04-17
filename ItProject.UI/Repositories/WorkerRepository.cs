using ItProject.UI.Domain.Interface;
using ItProject.UI.Domain.Models;

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

    /// <inheritdoc/>
    public async Task<List<WorkerLogin>> GetListWorkerAsync()
    {
        var sql = @$"exec dbo.ПолучениеСотрудников";
        var result = await connection.QueryAsync<WorkerLogin>(sql);
        return result.ToList();
    }

    /// <inheritdoc/>
    public async Task<WorkerLogin> GetWorkerAsync(int workerId)
    {
        var sql = @$"exec dbo.ПолучениеСотрудника";
        var parameters = new { Ид = workerId };
        var result = (await connection.QueryAsync<WorkerLogin>(sql, parameters)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<WorkerLogin> AddWorkerAsync(WorkerLogin workerLogin)
    {
        var sql = @$"exec dbo.ДобавлениеСотрудника @Фамилия, @Имя, @Роль, @Телефон, @ДатаПриема, @Логин, @Пароль";
        var parameters = new { Фамилия = workerLogin.FirstName, Имя = workerLogin.LastName, Роль = workerLogin.Position, Телефон = workerLogin.Phone, ДатаПриема = workerLogin.DateStart, Логин = workerLogin.Login, Пароль = workerLogin.Password };
        var result = (await connection.QueryAsync<WorkerLogin>(sql, parameters)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<WorkerLogin> UpdateWorkerAsync(WorkerLogin workerLogin)
    {
        var sql = @$"exec dbo.ОбновлениеСотрудника @Ид, @Фамилия, @Имя, @Роль, @Телефон, @ДатаПриема";
        var parameters = new { Ид = workerLogin.WorkerId, Фамилия = workerLogin.FirstName, Имя = workerLogin.LastName, Роль = workerLogin.Position, Телефон = workerLogin.Phone, ДатаПриема = workerLogin.DateStart };
        var result = (await connection.QueryAsync<WorkerLogin>(sql, parameters)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<WorkerLogin> UpdateUserWorkerAsync(WorkerLogin workerLogin)
    {
        var sql = @$"exec dbo.ОбновлениеПользователяСотрудника @Ид, @Логин, @Пароль";
        var parameters = new { Ид = workerLogin.WorkerId, Логин = workerLogin.Login, Пароль = workerLogin.Password };
        var result = (await connection.QueryAsync<WorkerLogin>(sql, parameters)).First();
        return result;
    }

    /// <inheritdoc/>
    public async Task<List<ReportAmount>> GetReportAmountAsync()
    {
        var sql = @$"exec dbo.ОтчетПродажи";
        var result = await connection.QueryAsync<ReportAmount>(sql);
        return result.ToList();
    }

    /// <inheritdoc/>
    public async Task<List<ReportScore>> GetReportScoreAsync()
    {
        var sql = @$"exec dbo.ОтчетОценки";
        var result = await connection.QueryAsync<ReportScore>(sql);
        return result.ToList();
    }
}