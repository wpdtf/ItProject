using ItProject.UI.Client;
using ItProject.UI.Domain.Interface;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ItProject.UI.FormDialog;

public partial class FormPasswordRecovery : Form
{
    private readonly SendToBack sendToBack;
    private readonly string SendEmail;

    private bool IsSuccess;

    public FormPasswordRecovery(SendToBack apiClient, string sendEmail)
    {
        InitializeComponent();
        sendToBack = apiClient;
        SendEmail = sendEmail;

        guna2CheckBox2.Visible = false;
        guna2TextBox2.Visible = false;
        guna2TextBox3.Visible = false;

        CreateCode();
    }

    private string HashPassword(string password)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    private async void Guna2Button1_Click_1(object sender, EventArgs e)
    {
        if (IsSuccess)
        {
            if (string.IsNullOrEmpty(guna2TextBox2.Text) || string.IsNullOrEmpty(guna2TextBox2.Text))
            {
                MessageBox.Show("Введите пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (guna2TextBox2.Text != guna2TextBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(guna2TextBox2.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
            {
                MessageBox.Show("Слишком простой пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new AuthDTO()
            {
                Login = SendEmail,
                Password = HashPassword(guna2TextBox2.Text)
            };

            try
            {
                await sendToBack.UpdatePasswordAsync(request);

                MessageBox.Show("Пароль успешно обновлен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text))
            {
                MessageBox.Show("Введите код", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(guna2TextBox1.Text, out _))
            {
                MessageBox.Show("Код может быть только целочесленным числом", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await sendToBack.CheckCodeAsync(SendEmail, Convert.ToInt32(guna2TextBox1.Text));
                MessageBox.Show("Успешно! Введите новый пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IsSuccess = true;

                guna2TextBox1.Visible = false;

                guna2CheckBox2.Visible = true;
                guna2TextBox2.Visible = true;
                guna2TextBox3.Visible = true;

                label1.Visible = false;
                Guna2Button1.Text = "Обновить";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private async void Guna2Button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private async Task CreateCode()
    {
        MessageBox.Show("Мы отправим вам код для восстановления на почту", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

        try
        {
            await sendToBack.CreateCodeAsync(SendEmail);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    }

    private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (guna2CheckBox2.Checked)
        {
            guna2TextBox2.PasswordChar = '\0';
        }
        else
        {
            guna2TextBox2.PasswordChar = '●';

        }
    }

    private async void label1_Click(object sender, EventArgs e)
    {
        await CreateCode();
    }
}
