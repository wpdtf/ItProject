using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using ItProject.UI.Domain.Interface;
using ItProject.UI.Domain.Models;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using static SkiaSharp.HarfBuzz.SKShaper;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace ItProject.UI.customElement;

public class CustomOrder : Guna2Panel
{
    private Order orderInfo;

    private bool _isBlinking = false;
    private bool _isScore = false;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel LabelInfo { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2HtmlLabel DescriptionLabel { get; private set; }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public Guna2TextBox DescriptionText { get; private set; }


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

    public CustomOrder()
    {
        InitializeComponent();
    }

    public CustomOrder(Order order) : this()
    {
        UpdateInfoOrderPanel(order);
    }

    public void UpdateInfoOrderPanel(Order order)
    {
        OrderInfo = order;

        var label = "";
        label += order.IsMp ? "МП" : "";
        label += order.IsSite ? "С" : "";
        label += order.IsWin ? "Д" : "";

        DescriptionText.Text = order.Description;

        LabelInfo.Text = $"Заказ {label}-{order.Id} от {order.DateCreate} на {order.Price} руб.";
        Button.Text = order.Status == "Согласование" ? "Согласовать" :
                      order.Status == "Приемка" ? "Принять" :
                      order.Status == "Готов" ? "Создать обр." :
                      order.Status == "Уточнение деталей" ? "Проверить обр." : "";

        Button.Visible = Button.Text != "";

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
    }

    private void InitializeComponent()
    {
        // Настройка панели
        this.Anchor = AnchorStyles.Right;
        this.BorderColor = Color.Green;
        this.BorderRadius = 10;
        this.BorderThickness = 2;
        this.Location = new Point(3, 3);
        this.Size = new Size(630, 190);

        DescriptionLabel = new Guna2HtmlLabel();
        DescriptionLabel.BackColor = Color.Transparent;
        DescriptionLabel.Font = new Font("Segoe UI", 9F);
        DescriptionLabel.ForeColor = Color.Black;
        DescriptionLabel.Location = new Point(4, 30);
        DescriptionLabel.Size = new Size(61, 17);
        DescriptionLabel.Text = "Описание:";

        LabelInfo = new Guna2HtmlLabel();
        LabelInfo.BackColor = Color.Transparent;
        LabelInfo.Font = new Font("Segoe UI", 9F);
        LabelInfo.ForeColor = Color.Black;
        LabelInfo.Location = new Point(4, 9);
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
        DescriptionText.Location = new Point(4, 50);
        DescriptionText.Multiline = true;
        DescriptionText.ReadOnly = true;
        DescriptionText.AutoScroll = true;
        DescriptionText.ScrollBars = ScrollBars.Vertical;
        DescriptionText.SelectedText = "";
        DescriptionText.Size = new Size(480, 84);

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
        Button.Location = new Point(492, 94);
        Button.Margin = new Padding(4);
        Button.Size = new Size(130, 40);

        IsMPCheck = new Guna2CheckBox();
        IsMPCheck.AutoSize = true;
        IsMPCheck.CheckedState.BorderColor = Color.Green;
        IsMPCheck.CheckedState.BorderRadius = 0;
        IsMPCheck.CheckedState.BorderThickness = 0;
        IsMPCheck.CheckedState.FillColor = Color.Green;
        IsMPCheck.Location = new Point(445, 10);
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
        IsSiteCheck.Location = new Point(497, 10);
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
        IsWinCheck.Location = new Point(555, 10);
        IsWinCheck.Size = new Size(71, 19);
        IsWinCheck.Text = "Десктоп";
        IsWinCheck.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWinCheck.UncheckedState.BorderRadius = 0;
        IsWinCheck.UncheckedState.BorderThickness = 0;
        IsWinCheck.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        IsWinCheck.CheckedChanged += ReadOnly;

        ProgressBar = new Guna2ProgressBar();
        ProgressBar.BorderRadius = 10;
        ProgressBar.Location = new Point(6, 141);
        ProgressBar.ProgressColor = Color.Green;
        ProgressBar.ProgressColor2 = Color.Green;
        ProgressBar.Size = new Size(618, 23);
        ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

        Status1 = new Guna2CheckBox();
        Status1.AutoSize = true;
        Status1.CheckedState.BorderColor = Color.Green;
        Status1.CheckedState.BorderRadius = 0;
        Status1.CheckedState.BorderThickness = 0;
        Status1.CheckedState.FillColor = Color.Green;
        Status1.Location = new Point(6, 168);
        Status1.Size = new Size(134, 19);
        Status1.Text = "Анализ требований";
        Status1.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status1.UncheckedState.BorderRadius = 0;
        Status1.UncheckedState.BorderThickness = 0;
        Status1.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status1.CheckedChanged += ReadOnly;

        Status2 = new Guna2CheckBox();
        Status2.AutoSize = true;
        Status2.CheckedState.BorderColor = Color.Green;
        Status2.CheckedState.BorderRadius = 0;
        Status2.CheckedState.BorderThickness = 0;
        Status2.CheckedState.FillColor = Color.Green;
        Status2.Location = new Point(146, 168);
        Status2.Size = new Size(136, 19);
        Status2.Text = "Согласование цены";
        Status2.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status2.UncheckedState.BorderRadius = 0;
        Status2.UncheckedState.BorderThickness = 0;
        Status2.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status2.CheckedChanged += ReadOnly;

        Status3 = new Guna2CheckBox();
        Status3.AutoSize = true;
        Status3.CheckedState.BorderColor = Color.Green;
        Status3.CheckedState.BorderRadius = 0;
        Status3.CheckedState.BorderThickness = 0;
        Status3.CheckedState.FillColor = Color.Green;
        Status3.Location = new Point(288, 168);
        Status3.Size = new Size(88, 19);
        Status3.Text = "Разработка";
        Status3.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status3.UncheckedState.BorderRadius = 0;
        Status3.UncheckedState.BorderThickness = 0;
        Status3.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status3.CheckedChanged += ReadOnly;

        Status4 = new Guna2CheckBox();
        Status4.AutoSize = true;
        Status4.CheckedState.BorderColor = Color.Green;
        Status4.CheckedState.BorderRadius = 0;
        Status4.CheckedState.BorderThickness = 0;
        Status4.CheckedState.FillColor = Color.Green;
        Status4.Location = new Point(473, 168);
        Status4.Size = new Size(76, 19);
        Status4.Text = "Приемка";
        Status4.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status4.UncheckedState.BorderRadius = 0;
        Status4.UncheckedState.BorderThickness = 0;
        Status4.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status4.CheckedChanged += ReadOnly;

        Status5 = new Guna2CheckBox();
        Status5.AutoSize = true;
        Status5.CheckedState.BorderColor = Color.Green;
        Status5.CheckedState.BorderRadius = 0;
        Status5.CheckedState.BorderThickness = 0;
        Status5.CheckedState.FillColor = Color.Green;
        Status5.Location = new Point(558, 168);
        Status5.Size = new Size(64, 19);
        Status5.Text = "Запуск";
        Status5.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        Status5.UncheckedState.BorderRadius = 0;
        Status5.UncheckedState.BorderThickness = 0;
        Status5.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        Status5.CheckedChanged += ReadOnly;

        // Добавление элементов
        this.Controls.Add(DescriptionLabel);
        this.Controls.Add(LabelInfo);
        this.Controls.Add(DescriptionText);
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

    private void ReadOnly(object sender, EventArgs e)
    {
        if (sender is Guna2CheckBox checkBox)
        {
            switch (checkBox.Text)
            {
                case "МП":
                    checkBox.Checked = OrderInfo.IsMp;
                    break;
                case "Сайт":
                    checkBox.Checked = OrderInfo.IsSite;
                    break;
                case "Десктоп":
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

    public async Task UpdateInfoOrderAsync(IClientRepository repository)
    {
        while (true)
        {
            await Task.Delay(30000);

            var result = await repository.GetOrderClientAsync(OrderInfo.Id);

            if (result.Status == "Готов" && result.Score == -1 && _isScore == false)
            {
                result.Score = await UpdateScore(repository, result);
                _isScore = false;
            }

            UpdateInfoOrderPanel(result);
        }
    }

    public async Task<int> UpdateScore(IClientRepository repository, Order order)
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

        await repository.SetScore(OrderInfo.Id, dialogResultInt);

        return dialogResultInt;
    }
}