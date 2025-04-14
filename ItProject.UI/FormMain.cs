using Guna.UI2.WinForms;
using ItProject.UI.Client;
using ItProject.UI.customElement;
using ItProject.UI.Domain.Interface;
using ItProject.UI.Domain.Models;
using ItProject.UI.FormDialog;
using ItProject.UI.Infrastructure.Repositories;
using ItProject.UI.StaticModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace ItProject.UI;

public partial class FormMain : Form
{
    private readonly IClientRepository _repository;
    private readonly IWorkerRepository _repository2;
    private readonly SendToBack _sendToBack;

    private List<Order> orders;

    public FormMain(SendToBack sendToBack, IClientRepository repository, IWorkerRepository repository2)
    {
        InitializeComponent();
        _repository = repository;
        _sendToBack = sendToBack;
        _repository2 = repository2;
    }

    private async void FormMain_Load(object sender, EventArgs e)
    {
        CurrentUser.Id = 1;
        CurrentUser.Position = "Балбес";

        SetAccess(CurrentUser.Position);
    }

    private void SetAccess(string role)
    {
        switch (role.ToLower())
        {
            case "балбес":
                guna2TabControl1.TabPages.Remove(tabPage1);
                break;
            case "старший менеджер":
                break;
            case "админ":
                break;
            case "":
                break;
        }
    }


    private void guna2ControlBox2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private async void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (guna2TabControl1.SelectedTab.Name)
        {
            case "tabPage1":
                break;
            case "tabPage2":
                guna2TextBox1.Visible = false;
                guna2CircleProgressBar1.Visible = true;
                guna2CircleProgressBar1.Animated = true;

                await UpdateListLocalOrder();

                guna2TextBox1.Visible = true;
                guna2CircleProgressBar1.Visible = false;
                guna2CircleProgressBar1.Animated = false;

                break;
            default:
                MessageBox.Show("Не определена открытая форма, перезапустите приложение", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                break;
        }
    }

    private async Task UpdateClientOrder(List<Order> localOrders)
    {
        flowLayoutPanel1.Controls.Clear();

        foreach (var item in localOrders)
        {
            var element = new CustomOrder(item);

            element.UpdateInfoOrderAsync(_repository, _repository2);

            element._IWorkerRepository = _repository2;

            element._mainForm = this;

            element.Button.Click += async (s, e) =>
            {
                if (item.Status is "Согласование" or "Приемка")
                {
                    var result = await _repository.SetNextStatusOrderAsync(element.OrderInfo.Id);
                    element.UpdateInfoOrderPanel(result);
                }
                else if (item.Status is "Готов" or "Уточнение деталей")
                {
                    if (item.Status == "Готов")
                    {
                        var newStatus = await _repository.CreateNewMessageStatusAsync(element.OrderInfo.Id);
                        element.UpdateInfoOrderPanel(newStatus);
                        await UpdateLocalOrder(newStatus);
                    }

                    FormChat form = new(_repository, element.alias, element.OrderInfo.Id, _repository2, _sendToBack);
                    form.Show();

                    var result = new Order();

                    if (CurrentUser.Position.Count() == 0)
                        result = await _repository.GetOrderClientAsync(element.OrderInfo.Id);
                    else
                        result = await _repository2.GetOrderWorkerAsync(element.OrderInfo.Id);

                    await UpdateLocalOrder(result);

                    element.UpdateInfoOrderPanel(result);
                }
                else if (item.Status is "Новый" or "Проверка" or "Оценка" or "Разработка" or "Запуск")
                {
                    var typeMessage = 0;
                    var question = new DialogResult();

                    switch (item.Status)
                    {
                        case "Новый":
                            if (!item.IsMp && !item.IsWin && !item.IsSite)
                            {
                                MessageBox.Show("Заполните направления разработки!", "Уведомления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            break;
                        case "Проверка":
                            if (item.DescriptionWorker.Trim().Count() == 0)
                            {
                                MessageBox.Show("Заполните описание сотрудника, необходимо для конечной оценки!", "Уведомления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            break;
                        case "Оценка":
                            question = MessageBox.Show($"Отправить на согласование клиенту проект с итоговой ценой {item.Price}?", "Уведомления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (question == DialogResult.No)
                                return;

                            typeMessage = 1;
                            break;
                        case "Разработка":
                            question = MessageBox.Show($"Вы подтверждаете готовность проекта и его отправку на приемку клиенту?", "Уведомления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (question == DialogResult.No)
                                return;

                            typeMessage = 2;
                            break;
                        case "Запуск":
                            question = MessageBox.Show($"Вы подтверждаете запуск проекта и закрытие заказа?", "Уведомления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (question == DialogResult.No)
                                return;

                            typeMessage = 3;
                            break;
                    }

                    await _repository2.SetNextStatusOrderAsync(item.Id);
                    await UpdateListLocalOrder();
                }
            };

            flowLayoutPanel1.Controls.Add(element);
        }
    }

    private async void guna2TextBox1_TextChanged(object sender, EventArgs e)
    {
        string searchText = guna2TextBox1.Text.Trim().ToUpper();

        if (string.IsNullOrEmpty(searchText))
        {
            await UpdateListLocalOrder();
            return;
        }

        try
        {
            var flagMatch = Regex.Match(searchText, "^([МПСДВ]+)(?:-(\\d+))?$");
            if (flagMatch.Success)
            {
                string flags = flagMatch.Groups[1].Value;
                bool hasId = flagMatch.Groups[2].Success;
                int id = hasId ? int.Parse(flagMatch.Groups[2].Value) : 0;

                bool mp = flags.Contains("МП") || flags.Contains("М");
                bool site = flags.Contains("С");
                bool win = flags.Contains("Д") || flags.Contains("В");

                var filteredOrders = orders.Where(o =>
                    (!hasId || o.Id == id) &&
                    (!mp || o.IsMp) &&
                    (!site || o.IsSite) &&
                    (!win || o.IsWin))
                    .ToList();

                UpdateClientOrder(filteredOrders);
                return;
            }

            if (TryParseDate(searchText, out DateTime? date, out int? year, out int? month, out int? day))
            {
                var filteredOrders = new List<Order>();

                if (year.HasValue && !month.HasValue && !day.HasValue)
                {
                    filteredOrders = orders.Where(o => o.DateCreate.Year == year.Value).ToList();
                }
                else if (year.HasValue && month.HasValue && !day.HasValue)
                {
                    filteredOrders = orders.Where(o =>
                        o.DateCreate.Year == year.Value &&
                        o.DateCreate.Month == month.Value).ToList();
                }
                else if (date.HasValue)
                {
                    filteredOrders = orders.Where(o => o.DateCreate.Date == date.Value.Date).ToList();
                }

                UpdateClientOrder(filteredOrders);
                return;
            }

            UpdateClientOrder(new List<Order>());
        }
        catch
        {
            UpdateClientOrder(orders);
        }
    }

    private bool TryParseDate(string input, out DateTime? date, out int? year, out int? month, out int? day)
    {
        date = null;
        year = null;
        month = null;
        day = null;

        if (DateTime.TryParse(input, CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime parsedDate))
        {
            date = parsedDate;
            year = parsedDate.Year;
            month = parsedDate.Month;
            day = parsedDate.Day;
            return true;
        }

        if (Regex.IsMatch(input, @"^\d{4}$") && int.TryParse(input, out int y))
        {
            year = y;
            return true;
        }

        var match = Regex.Match(input, @"^(\d{1,2})[\.\-](\d{4})$");
        if (match.Success && int.TryParse(match.Groups[1].Value, out int m) && m >= 1 && m <= 12)
        {
            year = int.Parse(match.Groups[2].Value);
            month = m;
            return true;
        }

        string[] monthNames = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
        for (int i = 0; i < monthNames.Length; i++)
        {
            if (monthNames[i].ToUpper().StartsWith(input))
            {
                month = i + 1;
                return true;
            }
        }

        return false;
    }

    private async void _btnRegister_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(guna2TextBox2.Text))
        {
            MessageBox.Show("Введите описание задания!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            await _repository.CreateOrderAsync(CurrentUser.Id, guna2TextBox2.Text);
            guna2TabControl1.SelectedTab = tabPage2;
        }
        catch
        {
            MessageBox.Show("Не удалось создать задание!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    public async Task UpdateLocalOrder(Order order)
    {
        var itemToUpdate = orders.FirstOrDefault(x => x.Id == order.Id);

        if (itemToUpdate is not null)
        {
            var index = orders.IndexOf(itemToUpdate);
            orders[index] = order;
        }
    }


    public async Task UpdateListLocalOrder()
    {
        if (CurrentUser.Position.Count() > 0)
        {
            guna2Button1.Visible = true;
            tabPage2.Text = "Мои задачи";
            orders = await _repository2.GetListOrderWorkerAsync(CurrentUser.Id);
        }
        else
        {
            orders = await _repository.GetListOrderClientAsync(CurrentUser.Id);

        }

        await UpdateClientOrder(orders);
    }

    private async void guna2Button1_Click(object sender, EventArgs e)
    {
        await UpdateListLocalOrder();
    }
}
