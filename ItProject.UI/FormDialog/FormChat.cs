using ItProject.UI.Client;
using ItProject.UI.customElement;
using ItProject.UI.Domain.Interface;
using ItProject.UI.Domain.Models;
using ItProject.UI.StaticModel;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ItProject.UI.FormDialog;

public partial class FormChat : Form
{
    private readonly IClientRepository _repository;
    private int OrderId;

    public FormChat(IClientRepository repository, int idOrder)
    {
        InitializeComponent();
        _repository = repository;
        OrderId = idOrder;
        label3.Text = $"Чат по заказу: {idOrder}";
        UpdateListMessageAsync();
    }

    private async Task UpdateListMessageAsync()
    {
        flowLayoutPanel1.Controls.Clear();

        var message = await _repository.GetListMessageClientAsync(OrderId);

        foreach (var item in message)
        {
            var element = new CustomMessage(item);

            if (!element.MessageInfo.IsVisible)
                element.UpdateInfoOrderAsync(_repository);

            flowLayoutPanel1.Controls.Add(element);
        }
    }

    private bool ValidateFields()
    {
        if (string.IsNullOrWhiteSpace(_Message.Text))
        {
            MessageBox.Show("Введите сообщение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _Message.Focus();
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

            await _repository.SendMessageAsync(CurrentUser.Id, OrderId, _Message.Text);
            _Message.Text = "";
            UpdateListMessageAsync();
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
} 