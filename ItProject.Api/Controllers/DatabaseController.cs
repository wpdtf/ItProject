namespace ItProject.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DatabaseController(IRepository repository, IEmailService service) : ControllerBase
{
    private readonly IRepository _repository = repository;
    private readonly IEmailService _service = service;

    /// <summary>
    /// Авторизация
    /// </summary>
    /// <param name="authDTO">Данные для аутентификации</param>
    /// <returns>Клиент</returns>
    /// <response code="200">Авторизация успешна</response>
    /// <response code="401">Неверные учетные данные</response>
    [HttpPost("auth")]
    public async Task<ActionResult<AuthResult>> AuthenticateAsync(AuthDTO authDTO)
    {
        var user = await _repository.AuthenticateAsync(authDTO.Login, authDTO.Password);

        if (user == null)
        {
            return Unauthorized("Неверный логин или пароль");
        }

        return Ok(user);
    }

    /// <summary>
    /// Регистрация
    /// </summary>
    /// <param name="registrationDTO">Данные для регистрации</param>
    /// <returns>Клиент</returns>
    /// <response code="204">Регистрация успешна</response>
    [HttpPost("registration")]
    public async Task<ActionResult<AuthResult>> RegistrationAsync(RegistrationDTO registrationDTO)
    {
        await _repository.RegistrationAsync(registrationDTO);

        return NoContent();
    }

    /// <summary>
    /// Отправка код для восстановления
    /// </summary>
    /// <param name="address">Куда</param>
    /// <param name="fullName">Кому</param>
    /// <returns>Клиент</returns>
    /// <response code="204">Успешная отправка</response>
    [HttpPost("PasswordRecovery")]
    public async Task<ActionResult<AuthResult>> PasswordRecoveryAsync([FromQuery] string address, string fullName = "")
    {
        var code = await _repository.CreateCodeAsync(address);

        await _service.PasswordRecoveryAsync(address, fullName, code.Code);

        return NoContent();
    }

    /// <summary>
    /// Проверить код для восстановления
    /// </summary>
    /// <param name="address">Куда</param>
    /// <param name="code">Код для проверки</param>
    /// <returns>Клиент</returns>
    /// <response code="200">Результат проверки</response>
    [HttpGet("PasswordRecovery")]
    public async Task<ActionResult<AuthResult>> PasswordRecoveryAsync([FromQuery] string address, int code)
    {
        var result = await _repository.CheckCodeAsync(address, code);
        return Ok(result);
    }

    /// <summary>
    /// Обновить пароль
    /// </summary>
    /// <param name="authDTO">Данные для обновления</param>
    /// <returns>Клиент</returns>
    /// <response code="204">Обновлено успешно</response>
    [HttpPut("PasswordRecovery")]
    public async Task<ActionResult<AuthResult>> PasswordRecoveryAsync(AuthDTO authDTO)
    {
        await _repository.UpdatePasswordAsync(authDTO.Login, authDTO.Password);
        return NoContent();
    }
}