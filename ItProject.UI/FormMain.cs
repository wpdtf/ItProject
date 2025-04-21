using Azure.Core;
using Guna.UI2.WinForms;
using ItProject.UI.Client;
using ItProject.UI.customElement;
using ItProject.UI.Domain.Interface;
using ItProject.UI.Domain.Models;
using ItProject.UI.FormDialog;
using ItProject.UI.Infrastructure.Repositories;
using ItProject.UI.StaticModel;
using OfficeOpenXml;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        SetAccess(CurrentUser.Position);
    }

    private void SetAccess(string role)
    {
        switch (role.ToLower().Trim())
        {
            case "разработчик по":
                guna2TabControl1.TabPages.Remove(tabPage1);
                guna2TabControl1.TabPages.Remove(tabPage3);
                guna2TabControl1.TabPages.Remove(tabPage4);
                break;
            case "менеджер":
                guna2TabControl1.TabPages.Remove(tabPage1);
                guna2TabControl1.TabPages.Remove(tabPage3);
                guna2TabControl1.TabPages.Remove(tabPage3);
                break;
            case "разработчик мп":
                guna2TabControl1.TabPages.Remove(tabPage1);
                guna2TabControl1.TabPages.Remove(tabPage3);
                guna2TabControl1.TabPages.Remove(tabPage4);
                break;
            case "верстальщик":
                guna2TabControl1.TabPages.Remove(tabPage1);
                guna2TabControl1.TabPages.Remove(tabPage3);
                guna2TabControl1.TabPages.Remove(tabPage4);
                break;
            case "":
                guna2TabControl1.TabPages.Remove(tabPage3);
                guna2TabControl1.TabPages.Remove(tabPage4);
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
            case "tabPage3":
                await UpdateWorkerInfoAsync();
                break;
            case "tabPage4":
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
            var element = new CustomOrder(item, _repository2);

            element.UpdateInfoOrderAsync(_repository, _repository2);

            element._mainForm = this;

            element.Button.Click += async (s, e) =>
            {
                if (element.OrderInfo.Status is "Согласование" or "Приемка")
                {
                    var result = await _repository.SetNextStatusOrderAsync(element.OrderInfo.Id);
                    element.UpdateInfoOrderPanel(result, true);
                }
                else if (element.OrderInfo.Status is "Готов" or "Уточнение деталей")
                {
                    if (element.OrderInfo.Status == "Готов")
                    {
                        var newStatus = await _repository.CreateNewMessageStatusAsync(element.OrderInfo.Id);
                        element.UpdateInfoOrderPanel(newStatus, true);
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

                    element.UpdateInfoOrderPanel(result, true);
                }
                else if (element.OrderInfo.Status is "Новый" or "Проверка" or "Оценка" or "Разработка" or "Запуск")
                {
                    var question = new DialogResult();

                    switch (element.OrderInfo.Status)
                    {
                        case "Новый":
                            if (!element.IsMPCheck.Checked && !element.IsWinCheck.Checked && !element.IsSiteCheck.Checked)
                            {
                                MessageBox.Show("Заполните направления разработки!", "Уведомления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            break;
                        case "Проверка":
                            if (element.DescriptionTextWorker.Text.Trim().Count() == 0)
                            {
                                MessageBox.Show("Заполните описание сотрудника, необходимо для конечной оценки!", "Уведомления", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            break;
                        case "Оценка":
                            question = MessageBox.Show($"Отправить на согласование клиенту проект с итоговой ценой {element.OrderInfo.Price}?", "Уведомления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (question == DialogResult.No)
                                return;

                            await _sendToBack.Agreement(element.alias, element.OrderInfo.Id, element.OrderInfo.Price);
                            break;
                        case "Разработка":
                            question = MessageBox.Show($"Вы подтверждаете готовность проекта и его отправку на приемку клиенту?", "Уведомления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (question == DialogResult.No)
                                return;

                            await _sendToBack.Acceptance(element.alias, element.OrderInfo.Id);
                            break;
                        case "Запуск":
                            question = MessageBox.Show($"Вы подтверждаете запуск проекта и закрытие заказа?", "Уведомления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (question == DialogResult.No)
                                return;

                            await _sendToBack.Success(element.alias, element.OrderInfo.Id);
                            break;
                    }

                    await _repository2.SetNextStatusOrderAsync(element.OrderInfo.Id);
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

    private void guna2Button4_Click(object sender, EventArgs e)
    {

    }

    public async Task UpdateWorkerInfoAsync()
    {
        try
        {
            var listWorker = await _repository2.GetListWorkerAsync();

            guna2DataGridView1.DataSource = listWorker;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async void guna2Button3_Click(object sender, EventArgs e)
    {
        FormWorker form = new(_repository2, true, new WorkerLogin(), this);
        form.Show();
    }

    private bool IsSelecedRow()
    {
        if (guna2DataGridView1.SelectedRows.Count <= 0)
        {
            MessageBox.Show("Выберите запись для данного действия.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        return true;
    }

    private async void guna2Button2_Click(object sender, EventArgs e)
    {
        if (!IsSelecedRow())
        {
            return;
        }

        var selectedRow = guna2DataGridView1.SelectedRows[0];
        var selectedModel = selectedRow.DataBoundItem;

        if (selectedModel is WorkerLogin selectedWorker)
        {
            FormWorker form = new(_repository2, false, selectedWorker, this);
            form.Show();
        }
    }

    private void guna2Button6_Click(object sender, EventArgs e)
    {
        var data = guna2DataGridView2.DataSource;

        if (data is List<ReportScore> or List<ReportAmount>)
        {
            using var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Сохранить файл Excel";
            saveFileDialog.FileName = "Отчет.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (data is List<ReportAmount> salesReports)
                {
                    WriteToExcel(salesReports, filePath);
                }
                else if (data is List<ReportScore> popularityReports)
                {
                    WriteToExcel(popularityReports, filePath);
                }

                MessageBox.Show($"Данные успешно записаны в файл: {filePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private async void guna2Button4_Click_1(object sender, EventArgs e)
    {
        try
        {
            var listWorker = await _repository2.GetReportAmountAsync();

            guna2DataGridView2.DataSource = listWorker;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async void guna2Button5_Click(object sender, EventArgs e)
    {
        try
        {
            var listWorker = await _repository2.GetReportScoreAsync();

            guna2DataGridView2.DataSource = listWorker;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    /// <summary>
    /// Записывает список объектов в Excel-файл.
    /// </summary>
    /// <typeparam name="T">Тип модели данных.</typeparam>
    /// <param name="data">Список объектов для записи.</param>
    /// <param name="filePath">Путь для сохранения.</param>
    public void WriteToExcel<T>(IEnumerable<T> data, string filePath)
    {
        // Устанавливаем контекст лицензии для EPPlus (требуется для коммерческого использования)
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        // Создаем новый Excel-пакет
        using (var package = new ExcelPackage())
        {
            // Добавляем лист в файл
            var worksheet = package.Workbook.Worksheets.Add("Data");

            // Получаем свойства модели
            var properties = typeof(T).GetProperties();

            // Записываем заголовки столбцов
            for (int i = 0; i < properties.Length; i++)
            {
                worksheet.Cells[1, i + 1].Value = properties[i].Name;
            }

            // Записываем данные
            int row = 2;
            foreach (var item in data)
            {
                for (int col = 0; col < properties.Length; col++)
                {
                    var value = properties[col].GetValue(item)?.ToString() ?? string.Empty;
                    worksheet.Cells[row, col + 1].Value = value;
                }
                row++;
            }

            // Авто-подгонка ширины столбцов
            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

            // Сохраняем файл
            var fileInfo = new FileInfo(filePath);
            package.SaveAs(fileInfo);
        }
    }
}
