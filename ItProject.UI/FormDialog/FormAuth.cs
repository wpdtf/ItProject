using Azure.Core;
using ItProject.UI.Client;
using ItProject.UI.Domain.Interface;
using System.Security.Cryptography;

namespace ItProject.UI.FormDialog;

public partial class FormAuth : Form
{
    private readonly SendToBack sendToBack;
    private readonly IClientRepository _repository;

    public FormAuth(SendToBack apiClient, IClientRepository repository)
    {
        InitializeComponent();
        sendToBack = apiClient;
        _repository = repository;
    }

    private string HashPassword(string password)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    private void Guna2Button1_Click_1(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private async void Guna2Button2_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
        {
            MessageBox.Show("Укажите логин и пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var request = new AuthDTO()
        {
            Login = guna2TextBox1.Text,
            Password = HashPassword(guna2TextBox2.Text)
        };

        try
        {
            await sendToBack.AuthenticateAsync(request);

            FormMain formMain = new(sendToBack, _repository);
            formMain.Show();
            this.Hide();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void label4_Click(object sender, EventArgs e)
    {
        FormRegister form = new(sendToBack);
        form.Show();
    }

    private async void label1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(guna2TextBox1.Text))
        {
            MessageBox.Show("Укажите логин (почту с которой вы регистрировались!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        FormPasswordRecovery form = new(sendToBack, guna2TextBox1.Text);
        form.Show();
    }
}
