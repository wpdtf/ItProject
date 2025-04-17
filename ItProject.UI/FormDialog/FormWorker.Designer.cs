using Guna.UI2.WinForms;

namespace ItProject.UI.FormDialog;

partial class FormWorker
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorker));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        _txtFirstName = new Guna2TextBox();
        _txtLastName = new Guna2TextBox();
        _txtPhone = new Guna2TextBox();
        _btnRegister = new Guna2Button();
        _btnCancel = new Guna2Button();
        panel2 = new Panel();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2ControlBox2 = new Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        guna2ImageButton1 = new Guna2ImageButton();
        guna2HtmlLabel1 = new Guna2HtmlLabel();
        dateStart = new Guna2DateTimePicker();
        guna2Button1 = new Guna2Button();
        guna2CheckBox2 = new Guna2CheckBox();
        RepeatedPasswordText = new Guna2TextBox();
        PasswordText = new Guna2TextBox();
        EmailText = new Guna2TextBox();
        IsWork1 = new Guna2RadioButton();
        IsWork2 = new Guna2RadioButton();
        IsWork3 = new Guna2RadioButton();
        IsWork4 = new Guna2RadioButton();
        IsWork5 = new Guna2RadioButton();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // _txtFirstName
        // 
        _txtFirstName.BorderRadius = 12;
        _txtFirstName.Cursor = Cursors.IBeam;
        _txtFirstName.CustomizableEdges = customizableEdges1;
        _txtFirstName.DefaultText = "";
        _txtFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtFirstName.ForeColor = Color.Black;
        _txtFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtFirstName.Location = new Point(355, 52);
        _txtFirstName.Name = "_txtFirstName";
        _txtFirstName.PlaceholderText = "Имя";
        _txtFirstName.SelectedText = "";
        _txtFirstName.ShadowDecoration.CustomizableEdges = customizableEdges2;
        _txtFirstName.Size = new Size(212, 36);
        _txtFirstName.TabIndex = 4;
        // 
        // _txtLastName
        // 
        _txtLastName.BorderRadius = 12;
        _txtLastName.Cursor = Cursors.IBeam;
        _txtLastName.CustomizableEdges = customizableEdges3;
        _txtLastName.DefaultText = "";
        _txtLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtLastName.ForeColor = Color.Black;
        _txtLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtLastName.Location = new Point(130, 52);
        _txtLastName.Name = "_txtLastName";
        _txtLastName.PlaceholderText = "Фамилия";
        _txtLastName.SelectedText = "";
        _txtLastName.ShadowDecoration.CustomizableEdges = customizableEdges4;
        _txtLastName.Size = new Size(212, 36);
        _txtLastName.TabIndex = 3;
        // 
        // _txtPhone
        // 
        _txtPhone.BorderRadius = 12;
        _txtPhone.Cursor = Cursors.IBeam;
        _txtPhone.CustomizableEdges = customizableEdges5;
        _txtPhone.DefaultText = "";
        _txtPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtPhone.ForeColor = Color.Black;
        _txtPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPhone.Location = new Point(128, 119);
        _txtPhone.Name = "_txtPhone";
        _txtPhone.PlaceholderText = "Телефон";
        _txtPhone.SelectedText = "";
        _txtPhone.ShadowDecoration.CustomizableEdges = customizableEdges6;
        _txtPhone.Size = new Size(212, 36);
        _txtPhone.TabIndex = 5;
        // 
        // _btnRegister
        // 
        _btnRegister.BorderRadius = 5;
        _btnRegister.CustomizableEdges = customizableEdges7;
        _btnRegister.DisabledState.BorderColor = Color.DarkGray;
        _btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
        _btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        _btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        _btnRegister.FillColor = Color.Green;
        _btnRegister.Font = new Font("Segoe UI", 9F);
        _btnRegister.ForeColor = Color.White;
        _btnRegister.Location = new Point(359, 302);
        _btnRegister.Name = "_btnRegister";
        _btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges8;
        _btnRegister.Size = new Size(212, 40);
        _btnRegister.TabIndex = 7;
        _btnRegister.Text = "Сохранить";
        _btnRegister.Click += _btnRegister_Click;
        // 
        // _btnCancel
        // 
        _btnCancel.BorderRadius = 5;
        _btnCancel.CustomizableEdges = customizableEdges9;
        _btnCancel.DisabledState.BorderColor = Color.DarkGray;
        _btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        _btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        _btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        _btnCancel.FillColor = Color.Green;
        _btnCancel.Font = new Font("Segoe UI", 9F);
        _btnCancel.ForeColor = Color.White;
        _btnCancel.Location = new Point(358, 348);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges10;
        _btnCancel.Size = new Size(212, 40);
        _btnCancel.TabIndex = 8;
        _btnCancel.Text = "Отмена";
        _btnCancel.Click += _btnCancel_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.Green;
        panel2.Controls.Add(guna2ControlBox1);
        panel2.Controls.Add(guna2ControlBox2);
        panel2.Controls.Add(label3);
        panel2.Dock = DockStyle.Top;
        panel2.ForeColor = SystemColors.ActiveCaption;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(4);
        panel2.Name = "panel2";
        panel2.Size = new Size(580, 40);
        panel2.TabIndex = 27;
        // 
        // guna2ControlBox1
        // 
        guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox1.Animated = true;
        guna2ControlBox1.Cursor = Cursors.Hand;
        guna2ControlBox1.CustomizableEdges = customizableEdges11;
        guna2ControlBox1.FillColor = Color.FromArgb(0, 64, 0);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(533, 6);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges12;
        guna2ControlBox1.Size = new Size(35, 30);
        guna2ControlBox1.TabIndex = 21;
        guna2ControlBox1.Click += _btnCancel_Click;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges13;
        guna2ControlBox2.FillColor = Color.FromArgb(0, 0, 64);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(775, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges14;
        guna2ControlBox2.Size = new Size(35, 30);
        guna2ControlBox2.TabIndex = 20;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.ForeColor = Color.White;
        label3.Location = new Point(10, 11);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(210, 20);
        label3.TabIndex = 17;
        label3.Text = "Редактирование сотрудника";
        // 
        // guna2DragControl1
        // 
        guna2DragControl1.DockIndicatorTransparencyValue = 1D;
        guna2DragControl1.DragStartTransparencyValue = 1D;
        guna2DragControl1.TargetControl = panel2;
        guna2DragControl1.UseTransparentDrag = true;
        // 
        // guna2BorderlessForm1
        // 
        guna2BorderlessForm1.AnimationInterval = 100;
        guna2BorderlessForm1.BorderRadius = 20;
        guna2BorderlessForm1.ContainerControl = this;
        guna2BorderlessForm1.DockIndicatorTransparencyValue = 1D;
        guna2BorderlessForm1.DragStartTransparencyValue = 1D;
        guna2BorderlessForm1.TransparentWhileDrag = true;
        // 
        // guna2ImageButton1
        // 
        guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
        guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
        guna2ImageButton1.ImageOffset = new Point(0, 0);
        guna2ImageButton1.ImageRotate = 0F;
        guna2ImageButton1.Location = new Point(0, 47);
        guna2ImageButton1.Name = "guna2ImageButton1";
        guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges25;
        guna2ImageButton1.Size = new Size(124, 91);
        guna2ImageButton1.TabIndex = 62;
        // 
        // guna2HtmlLabel1
        // 
        guna2HtmlLabel1.BackColor = Color.Transparent;
        guna2HtmlLabel1.Font = new Font("Segoe UI", 9F);
        guna2HtmlLabel1.ForeColor = Color.Black;
        guna2HtmlLabel1.Location = new Point(358, 99);
        guna2HtmlLabel1.Name = "guna2HtmlLabel1";
        guna2HtmlLabel1.Size = new Size(117, 17);
        guna2HtmlLabel1.TabIndex = 64;
        guna2HtmlLabel1.Text = "Дата начала работы:";
        // 
        // dateStart
        // 
        dateStart.BorderRadius = 10;
        dateStart.Checked = true;
        dateStart.CustomizableEdges = customizableEdges23;
        dateStart.FillColor = Color.Green;
        dateStart.Font = new Font("Segoe UI", 9F);
        dateStart.ForeColor = Color.White;
        dateStart.Format = DateTimePickerFormat.Long;
        dateStart.Location = new Point(355, 121);
        dateStart.Margin = new Padding(3, 2, 3, 2);
        dateStart.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
        dateStart.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
        dateStart.Name = "dateStart";
        dateStart.ShadowDecoration.CustomizableEdges = customizableEdges24;
        dateStart.Size = new Size(212, 34);
        dateStart.TabIndex = 63;
        dateStart.Value = new DateTime(2024, 11, 18, 23, 57, 59, 671);
        // 
        // guna2Button1
        // 
        guna2Button1.BorderRadius = 5;
        guna2Button1.CustomizableEdges = customizableEdges21;
        guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        guna2Button1.FillColor = Color.Green;
        guna2Button1.Font = new Font("Segoe UI", 9F);
        guna2Button1.ForeColor = Color.White;
        guna2Button1.Location = new Point(129, 348);
        guna2Button1.Name = "guna2Button1";
        guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges22;
        guna2Button1.Size = new Size(212, 40);
        guna2Button1.TabIndex = 70;
        guna2Button1.Text = "Обновить данные авторизации";
        guna2Button1.Click += guna2Button1_Click;
        // 
        // guna2CheckBox2
        // 
        guna2CheckBox2.AutoSize = true;
        guna2CheckBox2.CheckedState.BorderColor = Color.Green;
        guna2CheckBox2.CheckedState.BorderRadius = 0;
        guna2CheckBox2.CheckedState.BorderThickness = 0;
        guna2CheckBox2.CheckedState.FillColor = Color.Green;
        guna2CheckBox2.Location = new Point(13, 266);
        guna2CheckBox2.Name = "guna2CheckBox2";
        guna2CheckBox2.Size = new Size(76, 19);
        guna2CheckBox2.TabIndex = 74;
        guna2CheckBox2.Text = "Показать";
        guna2CheckBox2.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        guna2CheckBox2.UncheckedState.BorderRadius = 0;
        guna2CheckBox2.UncheckedState.BorderThickness = 0;
        guna2CheckBox2.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        guna2CheckBox2.CheckedChanged += guna2CheckBox2_CheckedChanged;
        // 
        // RepeatedPasswordText
        // 
        RepeatedPasswordText.BorderRadius = 12;
        RepeatedPasswordText.Cursor = Cursors.IBeam;
        RepeatedPasswordText.CustomizableEdges = customizableEdges15;
        RepeatedPasswordText.DefaultText = "";
        RepeatedPasswordText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        RepeatedPasswordText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        RepeatedPasswordText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        RepeatedPasswordText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        RepeatedPasswordText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        RepeatedPasswordText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        RepeatedPasswordText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        RepeatedPasswordText.Location = new Point(12, 292);
        RepeatedPasswordText.Margin = new Padding(4);
        RepeatedPasswordText.MaxLength = 16;
        RepeatedPasswordText.Name = "RepeatedPasswordText";
        RepeatedPasswordText.PasswordChar = '●';
        RepeatedPasswordText.PlaceholderText = "Подтвердите пароль";
        RepeatedPasswordText.SelectedText = "";
        RepeatedPasswordText.ShadowDecoration.CustomizableEdges = customizableEdges16;
        RepeatedPasswordText.Size = new Size(259, 38);
        RepeatedPasswordText.TabIndex = 73;
        // 
        // PasswordText
        // 
        PasswordText.BorderRadius = 12;
        PasswordText.Cursor = Cursors.IBeam;
        PasswordText.CustomizableEdges = customizableEdges17;
        PasswordText.DefaultText = "";
        PasswordText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        PasswordText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        PasswordText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        PasswordText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        PasswordText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        PasswordText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        PasswordText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        PasswordText.Location = new Point(13, 221);
        PasswordText.Margin = new Padding(4);
        PasswordText.MaxLength = 16;
        PasswordText.Name = "PasswordText";
        PasswordText.PasswordChar = '●';
        PasswordText.PlaceholderText = "Пароль";
        PasswordText.SelectedText = "";
        PasswordText.ShadowDecoration.CustomizableEdges = customizableEdges18;
        PasswordText.Size = new Size(259, 38);
        PasswordText.TabIndex = 72;
        // 
        // EmailText
        // 
        EmailText.BorderRadius = 12;
        EmailText.Cursor = Cursors.IBeam;
        EmailText.CustomizableEdges = customizableEdges19;
        EmailText.DefaultText = "";
        EmailText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        EmailText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        EmailText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        EmailText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        EmailText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        EmailText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        EmailText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        EmailText.Location = new Point(12, 175);
        EmailText.Margin = new Padding(4);
        EmailText.MaxLength = 16;
        EmailText.Name = "EmailText";
        EmailText.PlaceholderText = "Почта";
        EmailText.SelectedText = "";
        EmailText.ShadowDecoration.CustomizableEdges = customizableEdges20;
        EmailText.Size = new Size(259, 38);
        EmailText.TabIndex = 71;
        // 
        // IsWork1
        // 
        IsWork1.AutoSize = true;
        IsWork1.CheckedState.BorderColor = Color.Green;
        IsWork1.CheckedState.BorderThickness = 0;
        IsWork1.CheckedState.FillColor = Color.Green;
        IsWork1.CheckedState.InnerColor = Color.White;
        IsWork1.CheckedState.InnerOffset = -4;
        IsWork1.Location = new Point(307, 171);
        IsWork1.Name = "IsWork1";
        IsWork1.Size = new Size(116, 19);
        IsWork1.TabIndex = 75;
        IsWork1.Text = "Разработчик ПО";
        IsWork1.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWork1.UncheckedState.BorderThickness = 2;
        IsWork1.UncheckedState.FillColor = Color.Transparent;
        IsWork1.UncheckedState.InnerColor = Color.Transparent;
        // 
        // IsWork2
        // 
        IsWork2.AutoSize = true;
        IsWork2.CheckedState.BorderColor = Color.Green;
        IsWork2.CheckedState.BorderThickness = 0;
        IsWork2.CheckedState.FillColor = Color.Green;
        IsWork2.CheckedState.InnerColor = Color.White;
        IsWork2.CheckedState.InnerOffset = -4;
        IsWork2.Location = new Point(307, 194);
        IsWork2.Name = "IsWork2";
        IsWork2.Size = new Size(118, 19);
        IsWork2.TabIndex = 76;
        IsWork2.Text = "Разработчик МП";
        IsWork2.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWork2.UncheckedState.BorderThickness = 2;
        IsWork2.UncheckedState.FillColor = Color.Transparent;
        IsWork2.UncheckedState.InnerColor = Color.Transparent;
        // 
        // IsWork3
        // 
        IsWork3.AutoSize = true;
        IsWork3.CheckedState.BorderColor = Color.Green;
        IsWork3.CheckedState.BorderThickness = 0;
        IsWork3.CheckedState.FillColor = Color.Green;
        IsWork3.CheckedState.InnerColor = Color.White;
        IsWork3.CheckedState.InnerOffset = -4;
        IsWork3.Location = new Point(307, 219);
        IsWork3.Name = "IsWork3";
        IsWork3.Size = new Size(99, 19);
        IsWork3.TabIndex = 77;
        IsWork3.Text = "Верстальщик";
        IsWork3.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWork3.UncheckedState.BorderThickness = 2;
        IsWork3.UncheckedState.FillColor = Color.Transparent;
        IsWork3.UncheckedState.InnerColor = Color.Transparent;
        // 
        // IsWork4
        // 
        IsWork4.AutoSize = true;
        IsWork4.CheckedState.BorderColor = Color.Green;
        IsWork4.CheckedState.BorderThickness = 0;
        IsWork4.CheckedState.FillColor = Color.Green;
        IsWork4.CheckedState.InnerColor = Color.White;
        IsWork4.CheckedState.InnerOffset = -4;
        IsWork4.Location = new Point(427, 171);
        IsWork4.Name = "IsWork4";
        IsWork4.Size = new Size(83, 19);
        IsWork4.TabIndex = 78;
        IsWork4.Text = "Менеджер";
        IsWork4.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWork4.UncheckedState.BorderThickness = 2;
        IsWork4.UncheckedState.FillColor = Color.Transparent;
        IsWork4.UncheckedState.InnerColor = Color.Transparent;
        // 
        // IsWork5
        // 
        IsWork5.AutoSize = true;
        IsWork5.CheckedState.BorderColor = Color.Green;
        IsWork5.CheckedState.BorderThickness = 0;
        IsWork5.CheckedState.FillColor = Color.Green;
        IsWork5.CheckedState.InnerColor = Color.White;
        IsWork5.CheckedState.InnerOffset = -4;
        IsWork5.Location = new Point(427, 196);
        IsWork5.Name = "IsWork5";
        IsWork5.Size = new Size(112, 19);
        IsWork5.TabIndex = 79;
        IsWork5.Text = "Администратор";
        IsWork5.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        IsWork5.UncheckedState.BorderThickness = 2;
        IsWork5.UncheckedState.FillColor = Color.Transparent;
        IsWork5.UncheckedState.InnerColor = Color.Transparent;
        // 
        // FormWorker
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(580, 400);
        Controls.Add(IsWork5);
        Controls.Add(IsWork4);
        Controls.Add(IsWork3);
        Controls.Add(IsWork2);
        Controls.Add(IsWork1);
        Controls.Add(guna2CheckBox2);
        Controls.Add(RepeatedPasswordText);
        Controls.Add(PasswordText);
        Controls.Add(EmailText);
        Controls.Add(guna2Button1);
        Controls.Add(guna2HtmlLabel1);
        Controls.Add(dateStart);
        Controls.Add(guna2ImageButton1);
        Controls.Add(panel2);
        Controls.Add(_btnCancel);
        Controls.Add(_btnRegister);
        Controls.Add(_txtPhone);
        Controls.Add(_txtLastName);
        Controls.Add(_txtFirstName);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "FormWorker";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регистрация";
        FormClosing += FormRegister_FormClosing;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
    private Guna.UI2.WinForms.Guna2TextBox _txtFirstName;
    private Guna.UI2.WinForms.Guna2TextBox _txtLastName;
    private Guna.UI2.WinForms.Guna2TextBox _txtPhone;
    private Guna.UI2.WinForms.Guna2Button _btnRegister;
    private Guna.UI2.WinForms.Guna2Button _btnCancel;
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2ImageButton guna2ImageButton1;
    private Guna2HtmlLabel guna2HtmlLabel1;
    private Guna2DateTimePicker dateStart;
    private Guna2CheckBox guna2CheckBox6;
    private Guna2CheckBox guna2CheckBox5;
    private Guna2CheckBox guna2CheckBox4;
    private Guna2CheckBox guna2CheckBox3;
    private Guna2CheckBox guna2CheckBox1;
    private Guna2Button guna2Button1;
    private Guna2CheckBox guna2CheckBox2;
    private Guna2TextBox RepeatedPasswordText;
    private Guna2TextBox PasswordText;
    private Guna2TextBox EmailText;
    private Guna2RadioButton IsWork1;
    private Guna2RadioButton IsWork5;
    private Guna2RadioButton IsWork4;
    private Guna2RadioButton IsWork3;
    private Guna2RadioButton IsWork2;
} 