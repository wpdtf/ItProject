using MailKit.Net.Smtp;
using MimeKit;

namespace ItProject.Api.Infrastructure.EmailService;

public class EmailService : IEmailService
{
    private readonly string Name = "Ваши ИТ Заказы";
    private readonly string Login = "lecarstvo21@gmail.com";
    private readonly string Password = "reqc lshh gxqi huhi";

    /// <inheritdoc/>
    public async Task PasswordRecoveryAsync(string emailAddres, string name, int code)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(Name, Login));
        message.To.Add(new MailboxAddress(name, emailAddres));
        message.Subject = "Восстановление пароля!";
        message.Body = new TextPart("plain") { Text = $"Для ввостановления пароля введите код {code} в приложении. Никому не сообщайте код!" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 465, true);
        await client.AuthenticateAsync(Login, Password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }
}
