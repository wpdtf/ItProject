using Guna.UI2.WinForms;
using ItProject.UI.Domain.Interface;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ItProject.UI.FormDialog;

public partial class FormWorker : Form
{
    private readonly IWorkerRepository repository;
    private WorkerLogin workerLogin;
    private bool isNew = false;
    private FormMain formMain;

    public FormWorker(IWorkerRepository Repository, bool isNew, WorkerLogin worker, FormMain formMain)
    {
        InitializeComponent();
        repository = Repository;
        this.isNew = isNew;
        workerLogin = worker;

        if (!isNew)
        {
            _txtFirstName.Text = worker.FirstName;
            _txtLastName.Text = worker.LastName;
            _txtPhone.Text = worker.Phone;
            dateStart.Value = worker.DateStart;
            EmailText.Text = worker.Login;

            IsWork1.Checked = worker.Position == "Разработчик ПО";
            IsWork2.Checked = worker.Position == "Разработчик МП";
            IsWork3.Checked = worker.Position == "Верстальщик";
            IsWork4.Checked = worker.Position == "Менеджер";
            IsWork5.Checked = worker.Position == "Админ";
        }

        this.formMain = formMain;
    }

    private bool ValidateFields()
    {
        if (isNew && (string.IsNullOrEmpty(PasswordText.Text) || string.IsNullOrEmpty(PasswordText.Text)))
        {
            MessageBox.Show("Введите пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PasswordText.Focus();
            return false;
        }

        if (isNew && (PasswordText.Text != RepeatedPasswordText.Text))
        {
            MessageBox.Show("Пароли не совпадают", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RepeatedPasswordText.Focus();
            return false;
        }

        if (isNew && (!Regex.IsMatch(PasswordText.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")))
        {
            MessageBox.Show("Слишком простой пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PasswordText.Focus();
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

        if (dateStart.Value < DateTime.Now.AddYears(-30))
        {
            MessageBox.Show("Некорректный возраст начала работы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dateStart.Focus();
            return false;
        }

        if (!IsWork1.Checked && !IsWork2.Checked && !IsWork3.Checked && !IsWork4.Checked && !IsWork5.Checked)
        {
            MessageBox.Show("Необходимо выбрать должность!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dateStart.Focus();
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

            var request = new WorkerLogin
            {
                Login = EmailText.Text,
                Password = HashPassword(PasswordText.Text),
                WorkerId = workerLogin.WorkerId,
                FirstName = _txtFirstName.Text,
                LastName = _txtLastName.Text,
                Phone = _txtPhone.Text,
                DateStart = dateStart.Value,
                Position = IsWork1.Checked ? IsWork1.Text :
                           IsWork2.Checked ? IsWork2.Text :
                           IsWork3.Checked ? IsWork3.Text :
                           IsWork4.Checked ? IsWork4.Text : IsWork5.Text
            };

            if (isNew)
            {
                await repository.AddWorkerAsync(request);
            }
            else
            {
                await repository.UpdateWorkerAsync(request);
            }

            MessageBox.Show("Изменения внесены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await formMain.UpdateWorkerInfoAsync();
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        this.Enabled = true;
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

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateFields())
            {
                return;
            }

            this.Enabled = false;

            var request = new WorkerLogin
            {
                Login = EmailText.Text,
                Password = HashPassword(PasswordText.Text),
                WorkerId = workerLogin.WorkerId
            };

            await repository.UpdateUserWorkerAsync(request);

            MessageBox.Show("Изменения внесены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await formMain.UpdateWorkerInfoAsync();
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

    private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if (guna2CheckBox2.Checked)
        {
            PasswordText.PasswordChar = '\0';
        }
        else
        {
            PasswordText.PasswordChar = '●';

        }
    }
} 