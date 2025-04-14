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

    /// <inheritdoc/>
    public async Task CloseTicketAsync(string emailAddres, string name, string nameTicket, string lastMessage)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(Name, Login));
        message.To.Add(new MailboxAddress(name, emailAddres));
        message.Subject = "Обращение закрыто!";
        message.Body = new TextPart("plain") { Text = $"Уважаемый {name}, ваше обращение по заказу {nameTicket} закрыто!\nПоследнее сообщение:\n{lastMessage}" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 465, true);
        await client.AuthenticateAsync(Login, Password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }

    /// <inheritdoc/>
    public async Task SetAgreementOrderAsync(string emailAddres, string name, string nameTicket, decimal price)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(Name, Login));
        message.To.Add(new MailboxAddress(name, emailAddres));
        message.Subject = "Требуется согласование!";
        message.Body = new TextPart("plain") { Text = $"Уважаемый {name}, мы с командой рассмотрели ваш заказ {nameTicket}!\nКонечная стоимость: {price} р.\nВойдите в приложение чтобы согласовать стоимость!" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 465, true);
        await client.AuthenticateAsync(Login, Password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }

    /// <inheritdoc/>
    public async Task SetAcceptanceOrderAsync(string emailAddres, string name, string nameTicket)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(Name, Login));
        message.To.Add(new MailboxAddress(name, emailAddres));
        message.Subject = "Требуется приемка!";
        message.Body = new TextPart("plain") { Text = $"Уважаемый {name}, мы с командой завершили работу над заказом {nameTicket}!\nДля приемки заказа свяжитесь с нами по номеру: 8 800 458 85 48\nПосле приемки просим Вас войти в приложение и отметить, что заказ принят!" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 465, true);
        await client.AuthenticateAsync(Login, Password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }

    /// <inheritdoc/>
    public async Task SetSuccessAsync(string emailAddres, string name, string nameTicket)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(Name, Login));
        message.To.Add(new MailboxAddress(name, emailAddres));
        message.Subject = "Проект завершен!";
        message.Body = new TextPart("plain") { Text = $"Уважаемый {name}, наши специалисты успешно запустили/интегрировали проект из заказа {nameTicket}!\nПросим Вас войти в приложение и оценить качество работы!" };

        using var client = new SmtpClient();
        await client.ConnectAsync("smtp.gmail.com", 465, true);
        await client.AuthenticateAsync(Login, Password);
        await client.SendAsync(message);
        await client.DisconnectAsync(true);
    }
}
