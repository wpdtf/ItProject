using Guna.UI2.WinForms;
using ItProject.UI.Client;
using ItProject.UI.customElement;
using ItProject.UI.Domain.Interface;
using ItProject.UI.StaticModel;
using System.Threading.Tasks;

namespace ItProject.UI.FormDialog;

public partial class FormChat : Form
{
    private readonly IClientRepository _repository;
    private readonly IWorkerRepository _repository2;
    private readonly SendToBack _sendToBack;
    private int OrderId;
    private string Alias;

    public FormChat(IClientRepository repository, string alias, int idOrder, IWorkerRepository repository2, SendToBack sendToBack)
    {
        InitializeComponent();
        _repository = repository;
        _repository2 = repository2;
        _sendToBack = sendToBack;
        OrderId = idOrder;
        Alias = alias;
        label3.Text = $"Чат по заказу: {alias}-{idOrder}";
        if (CurrentUser.Position.Count() == 0)
            guna2Button1.Visible = false;

        UpdateListMessageAsync();
    }

    public async Task UpdateListMessageAsync()
    {
        flowLayoutPanel1.Controls.Clear();

        var message = new List<MessageFromOrder>();

        if (CurrentUser.Position.Count() == 0)
            message = await _repository.GetListMessageClientAsync(OrderId);
        else
            message = await _repository2.GetListMessageWorkerAsync(OrderId);

        foreach (var item in message)
        {
            var element = new CustomMessage(item);

            if (!element.MessageInfo.IsVisible)
                element.UpdateInfoOrderAsync(_repository, _repository2);

            flowLayoutPanel1.Controls.Add(element);
        }

        flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Minimum;
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

            if (CurrentUser.Position.Count() == 0)
                await _repository.SendMessageAsync(CurrentUser.Id, OrderId, _Message.Text);
            else
                await _repository2.SendMessageAsync(CurrentUser.Id, OrderId, _Message.Text);

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

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        try
        {
            this.Close();
            await _sendToBack.CloseTicket(Alias, OrderId);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}