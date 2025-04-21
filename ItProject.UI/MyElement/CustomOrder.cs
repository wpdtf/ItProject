using Guna.UI2.WinForms;
using ItProject.UI.Domain.Interface;
using ItProject.UI.Domain.Models;
using ItProject.UI.Infrastructure.Repositories;
using ItProject.UI.StaticModel;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Tasks;

namespace ItProject.UI.customElement;

public class CustomOrder : Guna2Panel
{
    private Order orderInfo;

    private bool _isBlinking = false;
    private bool _isScore = false;
    private bool _isLoad = false;
    private int _tryLeave = 0;
    private IWorkerRepository workerRepository1;
    private FormMain mainForm;


    public string alias;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel LabelInfo { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel DescriptionLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2TextBox DescriptionText { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2TextBox DescriptionTextWorker { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel DescriptionLabelWorker { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel PriceLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2TextBox PriceText { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel PrioritetLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2TextBox PrioritetText { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2Button Button { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox IsMPCheck { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox IsSiteCheck { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox IsWinCheck { get; private set; }


    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox Status1 { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox Status2 { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox Status3 { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox Status4 { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2CheckBox Status5 { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2ProgressBar ProgressBar { get; private set; }


    [DefaultValue("")]
    public Order OrderInfo
    {
        get => orderInfo;
        set
        {
            if (orderInfo != value)
            {
                orderInfo = value;
            }
        }
    }

    [DefaultValue("")]
    public IWorkerRepository _IWorkerRepository
    {
        get => workerRepository1;
        set
        {
            if (workerRepository1 != value)
            {
                workerRepository1 = value;
            }
        }
    }

    [DefaultValue("")]
    public FormMain _mainForm
    {
        get => mainForm;
        set
        {
            if (mainForm != value)
            {
                mainForm = value;
            }
        }
    }

    public CustomOrder()
    {
        InitializeComponent();
    }

    public CustomOrder(Order order, IWorkerRepository workerRepository) : this()
    {
        _IWorkerRepository = workerRepository;
        UpdateInfoOrderPanel(order, true);
        _isLoad = true;
    }

    public void UpdateInfoOrderPanel(Order order, bool isUpdateText = true)
    {
        OrderInfo = order;


        alias = GetAlias();

        DescriptionText.Text = order.Description;

        LabelInfo.Text = $"Заказ {alias}-{order.Id} от {order.DateCreate} на {order.Price} руб.";

        PriceLabel.Visible = false;
        PriceText.Visible = false;

        Button.Text = order.Status == "Согласование" ? "Согласовать" :
                      order.Status == "Приемка" ? "Принять" :
                      order.Status == "Готов" ? "Создать обр." :
                      order.Status == "Уточнение деталей" ? "Проверить обр." : "";

        if (CurrentUser.Position.Count() > 0)
        {
            LabelInfo.Text = $"Заказ {alias}-{order.Id} от {order.DateCreate}. Тел. {order.Phone}.";

            if (order.Score > 0)
                LabelInfo.Text = $"Заказ {alias}-{order.Id} от {order.DateCreate}. Тел. {order.Phone}. Оценен клиентом на: {order.Score} балл";

            PriceLabel.Visible = true;
            PriceText.Visible = true;
            PriceText.Text = order.Price.ToString();

            PrioritetLabel.Visible = true;
            PrioritetText.Visible = true;
            PrioritetText.Text = order.Prioritet.ToString();

            DescriptionTextWorker.Visible = true;
            
            if (isUpdateText)
                DescriptionTextWorker.Text = order.DescriptionWorker;

            DescriptionLabelWorker.Visible = true;
            DescriptionLabel.Text = "Описание от клиента:";
            DescriptionText.Size = new Size(350, 180);

            Button.Text = order.Status == "Разработка" ? "На приемку" :
                      order.Status == "Новый" ? "Данные уточнены" :
                      order.Status == "Проверка" ? "На оценку" :
                      order.Status == "Оценка" ? "На согласование" :
                      order.Status == "Запуск" ? "Запущено" :
                      order.Status == "Уточнение деталей" ? "Ответить на обр." : "";
        }

        _isBlinking = order.IsVisible;
        if (_isBlinking)
            StartBlinkingAsync();

        ProgressBar.Value = order.Status == "Новый" ? 0 :
                      order.Status == "Проверка" ? 10 :
                      order.Status == "Оценка" ? 20 :
                      order.Status == "Согласование" ? 25 :
                      order.Status == "Разработка" ? 50 :
                      order.Status == "Приемка" ? 80 :
                      order.Status == "Запуск" ? 90 : 100;

        IsMPCheck.Checked = order.IsMp;
        IsWinCheck.Checked = order.IsWin;
        IsSiteCheck.Checked = order.IsSite;

        Status1.Checked = order.Status == "Оценка" || order.Status == "Согласование" || order.Status == "Разработка" || order.Status == "Приемка" || order.Status == "Запуск" || order.Status == "Готов" || order.Status == "Уточнение деталей";
        Status2.Checked = order.Status == "Согласование" || order.Status == "Разработка" || order.Status == "Приемка" || order.Status == "Запуск" || order.Status == "Готов" || order.Status == "Уточнение деталей";
        Status3.Checked = order.Status == "Разработка" || order.Status == "Приемка" || order.Status == "Запуск" || order.Status == "Готов" || order.Status == "Уточнение деталей";
        Status4.Checked = order.Status == "Приемка" || order.Status == "Запуск" || order.Status == "Готов" || order.Status == "Уточнение деталей";
        Status5.Checked = order.Status == "Запуск" || order.Status == "Готов" || order.Status == "Уточнение деталей";

        Button.Visible = Button.Text != "";
    }

    public string GetAlias()
    {
        var label = "";
        label += OrderInfo.IsMp ? "МП" : "";
        label += OrderInfo.IsSite ? "С" : "";
        label += OrderInfo.IsWin ? "Д" : "";

        return label;
    }

    private void InitializeComponent()
    {
        // Настройка панели
        this.Anchor = AnchorStyles.Right;
        this.BorderColor = Color.Green;
        this.BorderRadius = 10;
        this.BorderThickness = 2;
        this.Location = new Point(3, 3);
        this.Size = new Size(775, 340);

        DescriptionLabel = new Guna2HtmlLabel();
        DescriptionLabel.BackColor = Color.Transparent;
        DescriptionLabel.Font = new Font("Segoe UI", 9F);
        DescriptionLabel.ForeColor = Color.Black;
        DescriptionLabel.Location = new Point(10, 70);
        DescriptionLabel.Size = new Size(61, 17);
        DescriptionLabel.Text = "Описание:";

        LabelInfo = new Guna2HtmlLabel();
        LabelInfo.BackColor = Color.Transparent;
        LabelInfo.Font = new Font("Segoe UI", 9F);
        LabelInfo.ForeColor = Color.Black;
        LabelInfo.Location = new Point(10, 19);
        LabelInfo.Size = new Size(228, 17);

        DescriptionText = new Guna2TextBox();
        DescriptionText.BorderRadius = 12;
        DescriptionText.Cursor = Cursors.IBeam;
        DescriptionText.DisabledState.BorderColor = Color.Green;
        DescriptionText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        DescriptionText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        DescriptionText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        DescriptionText.FocusedState.BorderColor = Color.Green;
        DescriptionText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        DescriptionText.ForeColor = Color.Black;
        DescriptionText.HoverState.BorderColor = Color.Green;
        DescriptionText.Location = new Point(10, 90);
        DescriptionText.Multiline = true;
        DescriptionText.ReadOnly = true;
        DescriptionText.AutoScroll = true;
        DescriptionText.ScrollBars = ScrollBars.Vertical;
        DescriptionText.SelectedText = "";
        DescriptionText.Size = new Size(750, 180);

        DescriptionLabelWorker = new Guna2HtmlLabel();
        DescriptionLabelWorker.BackColor = Color.Transparent;
        DescriptionLabelWorker.Font = new Font("Segoe UI", 9F);
        DescriptionLabelWorker.ForeColor = Color.Black;
        DescriptionLabelWorker.Location = new Point(370, 70);
        DescriptionLabelWorker.Size = new Size(61, 17);
        DescriptionLabelWorker.Text = "Описание от сотрудника:";
        DescriptionLabelWorker.Visible = false;

        DescriptionTextWorker = new Guna2TextBox();
        DescriptionTextWorker.BorderRadius = 12;
        DescriptionTextWorker.Cursor = Cursors.IBeam;
        DescriptionTextWorker.DisabledState.BorderColor = Color.Green;
        DescriptionTextWorker.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        DescriptionTextWorker.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        DescriptionTextWorker.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        DescriptionTextWorker.FocusedState.BorderColor = Color.Green;
        DescriptionTextWorker.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        DescriptionTextWorker.ForeColor = Color.Black;
        DescriptionTextWorker.HoverState.BorderColor = Color.Green;
        DescriptionTextWorker.Location = new Point(370, 90);
        DescriptionTextWorker.Multiline = true;
        DescriptionTextWorker.AutoScroll = true;
        DescriptionTextWorker.ScrollBars = ScrollBars.Vertical;
        DescriptionTextWorker.SelectedText = "";
        DescriptionTextWorker.Size = new Size(350, 180);
        DescriptionTextWorker.Visible = false;
        DescriptionTextWorker.Leave += LeaveAsync;

        PriceLabel = new Guna2HtmlLabel();
        PriceLabel.BackColor = Color.Transparent;
        PriceLabel.Font = new Font("Segoe UI", 9F);
        PriceLabel.ForeColor = Color.Black;
        PriceLabel.Location = new Point(10, 45);
        PriceLabel.Size = new Size(50, 17);
        PriceLabel.Text = "Цена:";

        PriceText = new Guna2TextBox();
        PriceText.Name = "PriceText";
        PriceText.BorderRadius = 12;
        PriceText.Cursor = Cursors.IBeam;
        PriceText.DisabledState.BorderColor = Color.Green;
        PriceText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        PriceText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        PriceText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        PriceText.FocusedState.BorderColor = Color.Green;
        PriceText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        PriceText.ForeColor = Color.Black;
        PriceText.HoverState.BorderColor = Color.Green;
        PriceText.Location = new Point(60, 40);
        PriceText.SelectedText = "";
        PriceText.Size = new Size(110, 25);
        PriceText.Visible = false;
        PriceText.Leave += LeaveAsync;

        PrioritetLabel = new Guna2HtmlLabel();
        PrioritetLabel.BackColor = Color.Transparent;
        PrioritetLabel.Font = new Font("Segoe UI", 9F);
        PrioritetLabel.ForeColor = Color.Black;
        PrioritetLabel.Location = new Point(180, 45);
        PrioritetLabel.Size = new Size(50, 17);
        PrioritetLabel.Text = "Приоритет:";
        PrioritetLabel.Visible = false;

        PrioritetText = new Guna2TextBox();
        PrioritetText.Name = "PrioritetText";
        PrioritetText.BorderRadius = 12;
        PrioritetText.Cursor = Cursors.IBeam;
        PrioritetText.DisabledState.BorderColor = Color.Green;
        PrioritetText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        PrioritetText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        PrioritetText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        PrioritetText.FocusedState.BorderColor = Color.Green;
        PrioritetText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        PrioritetText.ForeColor = Color.Black;
        PrioritetText.HoverState.BorderColor = Color.Green;
        PrioritetText.Location = new Point(260, 40);
        PrioritetText.SelectedText = "";
        PrioritetText.Size = new Size(110, 25);
        PrioritetText.Visible = false;
        PrioritetText.Leave += LeaveAsync;

        Button = new Guna2Button();
        Button.Animated = true;
        Button.BorderColor = Color.FromArgb(16, 90, 101);
        Button.BorderRadius = 12;
        Button.Cursor = Cursors.Hand;
        Button.DisabledState.BorderColor = Color.DarkGray;
        Button.DisabledState.CustomBorderColor = Color.DarkGray;
        Button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        Button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        Button.FillColor = Color.Green;
        Button.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Button.ForeColor = Color.White;
        Button.Location = new Point(630, 280);
        Button.Margin = new Padding(4);
        Button.Size = new Size(130, 40);

        IsMPCheck = new Guna2CheckBox();
        IsMPCheck.AutoSize = true;
        IsMPCheck.CheckedState.BorderColor = Color.Green;
        IsMPCheck.CheckedState.BorderRadius = 0;
        IsMPCheck.CheckedState.BorderThickness = 0;
        IsMPCheck.CheckedState.FillColor = Color.Green;
        IsMPCheck.Location = new Point(550, 20);
        IsMPCheck.Size = new Size(46, 19);
        IsMPCheck.Text = "МП";
        IsMPCheck.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsMPCheck.UncheckedState.BorderRadius = 0;
        IsMPCheck.UncheckedState.BorderThickness = 0;
        IsMPCheck.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        IsMPCheck.CheckedChanged += ReadOnly;

        IsSiteCheck = new Guna2CheckBox();
        IsSiteCheck.AutoSize = true;
        IsSiteCheck.CheckedState.BorderColor = Color.Green;
        IsSiteCheck.CheckedState.BorderRadius = 0;
        IsSiteCheck.CheckedState.BorderThickness = 0;
        IsSiteCheck.CheckedState.FillColor = Color.Green;
        IsSiteCheck.Location = new Point(602, 20);
        IsSiteCheck.Size = new Size(52, 19);
        IsSiteCheck.Text = "Сайт";
        IsSiteCheck.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsSiteCheck.UncheckedState.BorderRadius = 0;
        IsSiteCheck.UncheckedState.BorderThickness = 0;
        IsSiteCheck.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        IsSiteCheck.CheckedChanged += ReadOnly;

        IsWinCheck = new Guna2CheckBox();
        IsWinCheck.AutoSize = true;
        IsWinCheck.CheckedState.BorderColor = Color.Green;
        IsWinCheck.CheckedState.BorderRadius = 0;
        IsWinCheck.CheckedState.BorderThickness = 0;
        IsWinCheck.CheckedState.FillColor = Color.Green;
        IsWinCheck.Location = new Point(660, 20);
        IsWinCheck.Size = new Size(71, 19);
        IsWinCheck.Text = "Десктоп";
        IsWinCheck.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWinCheck.UncheckedState.BorderRadius = 0;
        IsWinCheck.UncheckedState.BorderThickness = 0;
        IsWinCheck.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        IsWinCheck.CheckedChanged += ReadOnly;

        ProgressBar = new Guna2ProgressBar();
        ProgressBar.BorderRadius = 5;
        ProgressBar.Location = new Point(10, 280);
        ProgressBar.ProgressColor = Color.Green;
        ProgressBar.ProgressColor2 = Color.Green;
        ProgressBar.Size = new Size(600, 15);
        ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

        Status1 = new Guna2CheckBox();
        Status1.AutoSize = true;
        Status1.CheckedState.BorderColor = Color.Green;
        Status1.CheckedState.BorderRadius = 0;
        Status1.CheckedState.BorderThickness = 0;
        Status1.CheckedState.FillColor = Color.Green;
        Status1.Location = new Point(10, 300);
        Status1.Size = new Size(134, 19);
        Status1.Text = "Анализ требований";
        Status1.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status1.UncheckedState.BorderRadius = 0;
        Status1.UncheckedState.BorderThickness = 0;
        Status1.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Status1.CheckedChanged += ReadOnly;

        Status2 = new Guna2CheckBox();
        Status2.AutoSize = true;
        Status2.CheckedState.BorderColor = Color.Green;
        Status2.CheckedState.BorderRadius = 0;
        Status2.CheckedState.BorderThickness = 0;
        Status2.CheckedState.FillColor = Color.Green;
        Status2.Location = new Point(150, 300);
        Status2.Size = new Size(136, 19);
        Status2.Text = "Согласование цены";
        Status2.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status2.UncheckedState.BorderRadius = 0;
        Status2.UncheckedState.BorderThickness = 0;
        Status2.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Status2.CheckedChanged += ReadOnly;

        Status3 = new Guna2CheckBox();
        Status3.AutoSize = true;
        Status3.CheckedState.BorderColor = Color.Green;
        Status3.CheckedState.BorderRadius = 0;
        Status3.CheckedState.BorderThickness = 0;
        Status3.CheckedState.FillColor = Color.Green;
        Status3.Location = new Point(310, 300);
        Status3.Size = new Size(88, 19);
        Status3.Text = "Разработка";
        Status3.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status3.UncheckedState.BorderRadius = 0;
        Status3.UncheckedState.BorderThickness = 0;
        Status3.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Status3.CheckedChanged += ReadOnly;

        Status4 = new Guna2CheckBox();
        Status4.AutoSize = true;
        Status4.CheckedState.BorderColor = Color.Green;
        Status4.CheckedState.BorderRadius = 0;
        Status4.CheckedState.BorderThickness = 0;
        Status4.CheckedState.FillColor = Color.Green;
        Status4.Location = new Point(460, 300);
        Status4.Size = new Size(76, 19);
        Status4.Text = "Приемка";
        Status4.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status4.UncheckedState.BorderRadius = 0;
        Status4.UncheckedState.BorderThickness = 0;
        Status4.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Status4.CheckedChanged += ReadOnly;

        Status5 = new Guna2CheckBox();
        Status5.AutoSize = true;
        Status5.CheckedState.BorderColor = Color.Green;
        Status5.CheckedState.BorderRadius = 0;
        Status5.CheckedState.BorderThickness = 0;
        Status5.CheckedState.FillColor = Color.Green;
        Status5.Location = new Point(550, 300);
        Status5.Size = new Size(64, 19);
        Status5.Text = "Запуск";
        Status5.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status5.UncheckedState.BorderRadius = 0;
        Status5.UncheckedState.BorderThickness = 0;
        Status5.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Status5.CheckedChanged += ReadOnly;

        // Добавление элементов
        this.Controls.Add(DescriptionLabel);
        this.Controls.Add(LabelInfo);
        this.Controls.Add(DescriptionText);
        this.Controls.Add(DescriptionLabelWorker);
        this.Controls.Add(DescriptionTextWorker);
        this.Controls.Add(PriceLabel);
        this.Controls.Add(PriceText);
        this.Controls.Add(PrioritetLabel);
        this.Controls.Add(PrioritetText);
        this.Controls.Add(Button);
        this.Controls.Add(IsMPCheck);
        this.Controls.Add(IsSiteCheck);
        this.Controls.Add(IsWinCheck);
        this.Controls.Add(Status1);
        this.Controls.Add(Status2);
        this.Controls.Add(Status3);
        this.Controls.Add(Status4);
        this.Controls.Add(Status4);
        this.Controls.Add(Status5);
        this.Controls.Add(ProgressBar);
    }

    private async void ReadOnly(object sender, EventArgs e)
    {
        if (sender is Guna2CheckBox checkBox)
        {
            switch (checkBox.Text)
            {
                case "МП":
                    if (CurrentUser.Position is "Менеджер" or "Админ" && _isLoad)
                    {
                        OrderInfo.IsMp = checkBox.Checked;
                        await _IWorkerRepository.UpdateDirectionMPAsync(OrderInfo.Id, checkBox.Checked);
                        UpdateInfoOrderPanel(OrderInfo);
                        await _mainForm.UpdateLocalOrder(OrderInfo);
                    }
                    else
                        checkBox.Checked = OrderInfo.IsMp;
                    break;
                case "Сайт":
                    if (CurrentUser.Position is "Менеджер" or "Админ" && _isLoad)
                    {
                        OrderInfo.IsSite = checkBox.Checked;
                        await _IWorkerRepository.UpdateDirectionSiteAsync(OrderInfo.Id, checkBox.Checked);
                        UpdateInfoOrderPanel(OrderInfo);
                        await _mainForm.UpdateLocalOrder(OrderInfo);
                    }
                    else
                        checkBox.Checked = OrderInfo.IsSite;
                    break;
                case "Десктоп":
                    if (CurrentUser.Position is "Менеджер" or "Админ" && _isLoad)
                    {
                        OrderInfo.IsWin = checkBox.Checked;
                        await _IWorkerRepository.UpdateDirectionPCAsync(OrderInfo.Id, checkBox.Checked);
                        UpdateInfoOrderPanel(OrderInfo);
                        await _mainForm.UpdateLocalOrder(OrderInfo);
                    }
                    else
                        checkBox.Checked = OrderInfo.IsWin;
                    break;
                case "Анализ требований":
                    checkBox.Checked = OrderInfo.Status == "Оценка" || OrderInfo.Status == "Согласование" || OrderInfo.Status == "Разработка" || OrderInfo.Status == "Приемка" || OrderInfo.Status == "Запуск" || OrderInfo.Status == "Готов" || OrderInfo.Status == "Уточнение деталей";
                    break;
                case "Согласование цены":
                    checkBox.Checked = OrderInfo.Status == "Согласование" || OrderInfo.Status == "Разработка" || OrderInfo.Status == "Приемка" || OrderInfo.Status == "Запуск" || OrderInfo.Status == "Готов" || OrderInfo.Status == "Уточнение деталей";
                    break;
                case "Разработка":
                    checkBox.Checked = OrderInfo.Status == "Разработка" || OrderInfo.Status == "Приемка" || OrderInfo.Status == "Запуск" || OrderInfo.Status == "Готов" || OrderInfo.Status == "Уточнение деталей";
                    break;
                case "Приемка":
                    checkBox.Checked = OrderInfo.Status == "Приемка" || OrderInfo.Status == "Запуск" || OrderInfo.Status == "Готов" || OrderInfo.Status == "Уточнение деталей";
                    break;
                case "Запуск":
                    checkBox.Checked = OrderInfo.Status == "Запуск" || OrderInfo.Status == "Готов" || OrderInfo.Status == "Уточнение деталей";
                    break;
            }
        }
    }

    private async void LeaveAsync(object sender, EventArgs e)
    {
        if (sender is Guna2TextBox textBox)
        {
            if (textBox.Text.Trim() != OrderInfo.DescriptionWorker.Trim() && textBox.Name != "PriceText" && textBox.Name != "PrioritetText")
            {
                var dialogResult = MessageBox.Show($"Было изменено описание, сохранить?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                {
                    _tryLeave++;
                    if (_tryLeave == 2)
                    {
                        var dialogResult2 = MessageBox.Show($"Откатить изменения?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult2 == DialogResult.Yes)
                        {
                            _tryLeave = 0;
                            textBox.Text = OrderInfo.DescriptionWorker;
                            return;
                        }
                    }

                    textBox.Focus();
                }
                else
                {
                    _tryLeave = 0;
                    await workerRepository1.SetNewDescriptionAsync(OrderInfo.Id, textBox.Text);
                    OrderInfo.DescriptionWorker = textBox.Text;

                    await _mainForm.UpdateLocalOrder(OrderInfo);
                }
            }
            else if (textBox.Name == "PriceText")
            {
                if (textBox.Text.Trim() != OrderInfo.Price.ToString().Trim() && CurrentUser.Position is "Менеджер" or "Админ" && textBox.Name == "PriceText")
                {
                    if (!IsValidNumberDecimal(textBox.Text))
                    {
                        MessageBox.Show($"Некорректное значение цены!", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _tryLeave = 0;
                        textBox.Text = OrderInfo.Price.ToString();
                        return;
                    }

                    var dialogResult = MessageBox.Show($"Была изменена цена, сохранить?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        _tryLeave++;
                        if (_tryLeave == 2)
                        {
                            var dialogResult2 = MessageBox.Show($"Откатить изменения?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult2 == DialogResult.Yes)
                            {
                                _tryLeave = 0;
                                textBox.Text = OrderInfo.Price.ToString();
                                return;
                            }
                        }

                        textBox.Focus();
                    }
                    else
                    {
                        _tryLeave = 0;
                        await workerRepository1.SetNewPriceAsync(OrderInfo.Id, Convert.ToDecimal(textBox.Text));
                        OrderInfo.Price = Convert.ToDecimal(textBox.Text);

                        await _mainForm.UpdateLocalOrder(OrderInfo);
                    }
                }
                else if (textBox.Text.Trim() != OrderInfo.Price.ToString().Trim() && CurrentUser.Position is not "Менеджер" and not "Админ")
                {
                    MessageBox.Show($"Вы не можете обновлять цену для заказа!", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    _tryLeave = 0;
                    textBox.Text = OrderInfo.Price.ToString();
                    return;
                }
            }
            else if (textBox.Name == "PrioritetText")
            {
                if (textBox.Text.Trim() != OrderInfo.Prioritet.ToString().Trim() && CurrentUser.Position is "Менеджер" or "Админ")
                {
                    if (!IsValidNumberDecimal(textBox.Text))
                    {
                        MessageBox.Show($"Некорректное значение приоритета!", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _tryLeave = 0;
                        textBox.Text = OrderInfo.Price.ToString();
                        return;
                    }

                    var dialogResult = MessageBox.Show($"Был изменен приоритет, сохранить?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        _tryLeave++;
                        if (_tryLeave == 2)
                        {
                            var dialogResult2 = MessageBox.Show($"Откатить изменения?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult2 == DialogResult.Yes)
                            {
                                _tryLeave = 0;
                                textBox.Text = OrderInfo.Prioritet.ToString();
                                return;
                            }
                        }

                        textBox.Focus();
                    }
                    else
                    {
                        _tryLeave = 0;
                        await workerRepository1.UpdatePrioritetAsync(OrderInfo.Id, Convert.ToInt32(textBox.Text));
                        OrderInfo.Prioritet = Convert.ToInt32(textBox.Text);

                        await _mainForm.UpdateLocalOrder(OrderInfo);
                    }
                }
                else if (textBox.Text.Trim() != OrderInfo.Prioritet.ToString().Trim())
                {
                    MessageBox.Show($"Вы не можете обновлять приоритет для заказа!", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    _tryLeave = 0;
                    textBox.Text = OrderInfo.Prioritet.ToString();
                    return;
                }
            }
        }
    }

    private async Task StartBlinkingAsync()
    {
        while (_isBlinking)
        {
            Button.FillColor = Color.FromArgb(0, 64, 0);
            await Task.Delay(500);
            Button.FillColor = Color.Green;
            await Task.Delay(500);
        }
    }

    public async Task UpdateInfoOrderAsync(IClientRepository clientRepository, IWorkerRepository workerRepository)
    {
        while (true)
        {
            await Task.Delay(10000);

            var result = new Order();

            if (CurrentUser.Position.Count() == 0)
                result = await clientRepository.GetOrderClientAsync(OrderInfo.Id);
            else
                result = await workerRepository.GetOrderWorkerAsync(OrderInfo.Id);

            if (result.Status == "Готов" && result.Score == -1 && _isScore == false && CurrentUser.Position.Count() == 0)
            {
                result.Score = await UpdateScore(clientRepository, result);
                _isScore = false;
            }
            if (OrderInfo.DescriptionWorker != DescriptionTextWorker.Text)
                UpdateInfoOrderPanel(result, false);
            else
                UpdateInfoOrderPanel(result, true);

        }
    }

    public async Task<int> UpdateScore(IClientRepository clientRepository, Order order)
    {
        _isScore = true;
        var label = "";
        label += order.IsMp ? "МП" : "";
        label += order.IsSite ? "С" : "";
        label += order.IsWin ? "Д" : "";
        var dialogResult = MessageBox.Show(
            $"Заказ {label}-{order.Id} выполнен, оцените работу:\n\n" +
             "Да - Отлично\n" +
             "Нет - Удовлетворительно",
            "Оценка",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
        );

        var dialogResultInt = 0;

        switch (dialogResult)
        {
            case DialogResult.Yes: dialogResultInt = 3; break;
            case DialogResult.No: dialogResultInt = 2; break;
            case DialogResult.Cancel: dialogResultInt = 1; break;
        }

        await clientRepository.SetScore(OrderInfo.Id, dialogResultInt);

        return dialogResultInt;
    }

    static bool IsValidNumberDecimal(string text)
    {
        if (decimal.TryParse(text, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out decimal num))
        {
            return num > 0m && num <= decimal.MaxValue;
        }
        return false;
    }
}