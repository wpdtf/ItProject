using Guna.UI2.WinForms;
using ItProject.UI.Client;
using ItProject.UI.Domain.Models;
using ItProject.UI.StaticModel;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ItProject.UI.FormDialog;

public partial class FormRegister : Form
{
    private readonly SendToBack sendToBack;

    public FormRegister(SendToBack apiClient)
    {
        InitializeComponent();
        sendToBack = apiClient;
        this.Text = "Регистрация";
    }

    private bool ValidateFields()
    {
        if (string.IsNullOrWhiteSpace(_txtPassword.Text))
        {
            MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtPassword.Focus();
            return false;
        }

        if (_txtPassword.Text != _txtPasswordConfirm.Text)
        {
            MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtPasswordConfirm.Focus();
            return false;
        }

        if (!Regex.IsMatch(_txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$"))
        {
            MessageBox.Show("Слишком простой пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (string.IsNullOrWhiteSpace(_txtFirstName.Text))
        {
            MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtFirstName.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(_txtLastName.Text))
        {
            MessageBox.Show("Введите фамилию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtLastName.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(_txtEmail.Text))
        {
            MessageBox.Show("Введите email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtEmail.Focus();
            return false;
        }

        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        if (!emailRegex.IsMatch(_txtEmail.Text))
        {
            MessageBox.Show("Введите корректный email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtEmail.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(_txtPhone.Text))
        {
            MessageBox.Show("Введите номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtPhone.Focus();
            return false;
        }

        var phoneRegex = new Regex(@"^9\d{9}$");
        if (!phoneRegex.IsMatch(_txtPhone.Text))
        {
            MessageBox.Show("Номер телефона должен начинаться с 9 и содержать еще 9 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _txtPhone.Focus();
            return false;
        }

        return true;
    }

    private async void _btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateFields())
            {
                return;
            }

            this.Enabled = false;

            var request = new Registration
            {
                FirstName = _txtFirstName.Text,
                LastName = _txtLastName.Text,
                Login = _txtEmail.Text,
                Phone = _txtPhone.Text,
                Password = HashPassword(_txtPassword.Text)
            };

            await sendToBack.RegisterAsync(request);
            MessageBox.Show("Регистрация успешно завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            this.Enabled = true;
        }
    }

    private void _btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (this.DialogResult == DialogResult.None)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }

    private string HashPassword(string password)
    {
        byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
        return Convert.ToBase64String(bytes);
    }

    private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (guna2CheckBox2.Checked)
        {
            _txtPassword.PasswordChar = '\0';
        }
        else
        {
            _txtPassword.PasswordChar = '●';

        }
    }
} 