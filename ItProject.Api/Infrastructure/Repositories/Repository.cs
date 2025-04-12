namespace ItProject.Api.Infrastructure.Repositories;

public class Repository(DataBaseContext dbContext) : IRepository
{
    private readonly IDbConnection connection = new SqlConnection(dbContext.Database.GetConnectionString());

    /// <inheritdoc/>
    public async Task<AuthResult> AuthenticateAsync(string login, string passwordHash)
    {
        var sql = @$"exec dbo.Авторизация @login = N'{login}', @password = N'{passwordHash}'";
        var result = await connection.QueryFirstOrDefaultAsync<AuthResult>(sql);
        return result;
    }

    /// <inheritdoc/>
    public async Task RegistrationAsync(RegistrationDTO registration)
    {
        var sql = @$"exec dbo.Регистрация 
            @login = N'{registration.Login}', 
            @password = N'{registration.Password}',
            @lastName = N'{registration.LastName}',
            @firstName = N'{registration.FirstName}',
            @phone = N'{registration.Phone}'";

        await connection.ExecuteAsync(sql);
    }

    /// <inheritdoc/>
    public async Task<NewCode> CreateCodeAsync(string login)
    {
        var sql = @$"exec dbo.СоздатьКодДляВосстановления @Почта = N'{login}'";
        var result = await connection.QueryFirstOrDefaultAsync<NewCode>(sql);
        return result;
    }

    /// <inheritdoc/>
    public async Task<IsResult> CheckCodeAsync(string login, int code)
    {
        var sql = @$"exec dbo.ПроверитьКод @Почта = N'{login}', @Код = {code}";
        var result = await connection.QueryFirstOrDefaultAsync<IsResult>(sql);
        return result;
    }

    /// <inheritdoc/>
    public async Task UpdatePasswordAsync(string login, string passwordHash)
    {
        var sql = @$"exec dbo.ОбновитьПароль 
            @Почта = N'{login}', 
            @password = N'{passwordHash}'";

        await connection.ExecuteAsync(sql);
    }
}