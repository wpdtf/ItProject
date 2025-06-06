using Guna.UI2.WinForms;

namespace ItProject.UI.FormDialog;

partial class FormRegister
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        _txtPassword = new Guna2TextBox();
        _txtPasswordConfirm = new Guna2TextBox();
        _txtFirstName = new Guna2TextBox();
        _txtLastName = new Guna2TextBox();
        _txtEmail = new Guna2TextBox();
        _txtPhone = new Guna2TextBox();
        _btnRegister = new Guna2Button();
        _btnCancel = new Guna2Button();
        panel2 = new Panel();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2ControlBox2 = new Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        guna2CheckBox2 = new Guna2CheckBox();
        guna2ImageButton1 = new Guna2ImageButton();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // _txtPassword
        // 
        _txtPassword.BorderRadius = 12;
        _txtPassword.Cursor = Cursors.IBeam;
        _txtPassword.CustomizableEdges = customizableEdges1;
        _txtPassword.DefaultText = "";
        _txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtPassword.ForeColor = Color.Black;
        _txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPassword.Location = new Point(12, 146);
        _txtPassword.Name = "_txtPassword";
        _txtPassword.PasswordChar = '●';
        _txtPassword.PlaceholderText = "Пароль";
        _txtPassword.SelectedText = "";
        _txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
        _txtPassword.Size = new Size(212, 36);
        _txtPassword.TabIndex = 2;
        // 
        // _txtPasswordConfirm
        // 
        _txtPasswordConfirm.BorderRadius = 12;
        _txtPasswordConfirm.Cursor = Cursors.IBeam;
        _txtPasswordConfirm.CustomizableEdges = customizableEdges3;
        _txtPasswordConfirm.DefaultText = "";
        _txtPasswordConfirm.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtPasswordConfirm.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtPasswordConfirm.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtPasswordConfirm.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtPasswordConfirm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPasswordConfirm.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtPasswordConfirm.ForeColor = Color.Black;
        _txtPasswordConfirm.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPasswordConfirm.Location = new Point(230, 146);
        _txtPasswordConfirm.Name = "_txtPasswordConfirm";
        _txtPasswordConfirm.PasswordChar = '●';
        _txtPasswordConfirm.PlaceholderText = "Подтвердите пароль";
        _txtPasswordConfirm.SelectedText = "";
        _txtPasswordConfirm.ShadowDecoration.CustomizableEdges = customizableEdges4;
        _txtPasswordConfirm.Size = new Size(212, 36);
        _txtPasswordConfirm.TabIndex = 3;
        // 
        // _txtFirstName
        // 
        _txtFirstName.BorderRadius = 12;
        _txtFirstName.Cursor = Cursors.IBeam;
        _txtFirstName.CustomizableEdges = customizableEdges5;
        _txtFirstName.DefaultText = "";
        _txtFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtFirstName.ForeColor = Color.Black;
        _txtFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtFirstName.Location = new Point(230, 211);
        _txtFirstName.Name = "_txtFirstName";
        _txtFirstName.PlaceholderText = "Имя";
        _txtFirstName.SelectedText = "";
        _txtFirstName.ShadowDecoration.CustomizableEdges = customizableEdges6;
        _txtFirstName.Size = new Size(212, 36);
        _txtFirstName.TabIndex = 4;
        // 
        // _txtLastName
        // 
        _txtLastName.BorderRadius = 12;
        _txtLastName.Cursor = Cursors.IBeam;
        _txtLastName.CustomizableEdges = customizableEdges7;
        _txtLastName.DefaultText = "";
        _txtLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtLastName.ForeColor = Color.Black;
        _txtLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtLastName.Location = new Point(12, 211);
        _txtLastName.Name = "_txtLastName";
        _txtLastName.PlaceholderText = "Фамилия";
        _txtLastName.SelectedText = "";
        _txtLastName.ShadowDecoration.CustomizableEdges = customizableEdges8;
        _txtLastName.Size = new Size(212, 36);
        _txtLastName.TabIndex = 3;
        // 
        // _txtEmail
        // 
        _txtEmail.BorderRadius = 12;
        _txtEmail.Cursor = Cursors.IBeam;
        _txtEmail.CustomizableEdges = customizableEdges9;
        _txtEmail.DefaultText = "";
        _txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtEmail.ForeColor = Color.Black;
        _txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtEmail.Location = new Point(137, 74);
        _txtEmail.MaxLength = 255;
        _txtEmail.Name = "_txtEmail";
        _txtEmail.PlaceholderText = "Почта";
        _txtEmail.SelectedText = "";
        _txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges10;
        _txtEmail.Size = new Size(212, 36);
        _txtEmail.TabIndex = 1;
        // 
        // _txtPhone
        // 
        _txtPhone.BorderRadius = 12;
        _txtPhone.Cursor = Cursors.IBeam;
        _txtPhone.CustomizableEdges = customizableEdges11;
        _txtPhone.DefaultText = "";
        _txtPhone.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _txtPhone.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _txtPhone.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _txtPhone.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _txtPhone.ForeColor = Color.Black;
        _txtPhone.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _txtPhone.Location = new Point(10, 253);
        _txtPhone.Name = "_txtPhone";
        _txtPhone.PlaceholderText = "Телефон";
        _txtPhone.SelectedText = "";
        _txtPhone.ShadowDecoration.CustomizableEdges = customizableEdges12;
        _txtPhone.Size = new Size(212, 36);
        _txtPhone.TabIndex = 5;
        // 
        // _btnRegister
        // 
        _btnRegister.BorderRadius = 5;
        _btnRegister.CustomizableEdges = customizableEdges13;
        _btnRegister.DisabledState.BorderColor = Color.DarkGray;
        _btnRegister.DisabledState.CustomBorderColor = Color.DarkGray;
        _btnRegister.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        _btnRegister.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        _btnRegister.FillColor = Color.Green;
        _btnRegister.Font = new Font("Segoe UI", 9F);
        _btnRegister.ForeColor = Color.White;
        _btnRegister.Location = new Point(12, 318);
        _btnRegister.Name = "_btnRegister";
        _btnRegister.ShadowDecoration.CustomizableEdges = customizableEdges14;
        _btnRegister.Size = new Size(212, 40);
        _btnRegister.TabIndex = 7;
        _btnRegister.Text = "Зарегистрироваться";
        _btnRegister.Click += _btnRegister_Click;
        // 
        // _btnCancel
        // 
        _btnCancel.BorderRadius = 5;
        _btnCancel.CustomizableEdges = customizableEdges15;
        _btnCancel.DisabledState.BorderColor = Color.DarkGray;
        _btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        _btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        _btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        _btnCancel.FillColor = Color.Green;
        _btnCancel.Font = new Font("Segoe UI", 9F);
        _btnCancel.ForeColor = Color.White;
        _btnCancel.Location = new Point(230, 318);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges16;
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
        panel2.Size = new Size(472, 40);
        panel2.TabIndex = 27;
        // 
        // guna2ControlBox1
        // 
        guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox1.Animated = true;
        guna2ControlBox1.Cursor = Cursors.Hand;
        guna2ControlBox1.CustomizableEdges = customizableEdges17;
        guna2ControlBox1.FillColor = Color.FromArgb(0, 64, 0);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(425, 6);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges18;
        guna2ControlBox1.Size = new Size(35, 30);
        guna2ControlBox1.TabIndex = 21;
        guna2ControlBox1.Click += _btnCancel_Click;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges19;
        guna2ControlBox2.FillColor = Color.FromArgb(0, 0, 64);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(667, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges20;
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
        label3.Size = new Size(96, 20);
        label3.TabIndex = 17;
        label3.Text = "Регистрация";
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
        // guna2CheckBox2
        // 
        guna2CheckBox2.AutoSize = true;
        guna2CheckBox2.CheckedState.BorderColor = Color.Green;
        guna2CheckBox2.CheckedState.BorderRadius = 0;
        guna2CheckBox2.CheckedState.BorderThickness = 0;
        guna2CheckBox2.CheckedState.FillColor = Color.Green;
        guna2CheckBox2.Location = new Point(146, 186);
        guna2CheckBox2.Name = "guna2CheckBox2";
        guna2CheckBox2.Size = new Size(76, 19);
        guna2CheckBox2.TabIndex = 61;
        guna2CheckBox2.Text = "Показать";
        guna2CheckBox2.UncheckedState.BorderColor = Color.FromArgb(0, 64, 0);
        guna2CheckBox2.UncheckedState.BorderRadius = 0;
        guna2CheckBox2.UncheckedState.BorderThickness = 0;
        guna2CheckBox2.UncheckedState.FillColor = Color.FromArgb(0, 64, 0);
        guna2CheckBox2.CheckedChanged += guna2CheckBox2_CheckedChanged;
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
        guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges21;
        guna2ImageButton1.Size = new Size(114, 84);
        guna2ImageButton1.TabIndex = 62;
        // 
        // FormRegister
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(472, 370);
        Controls.Add(guna2CheckBox2);
        Controls.Add(_txtPasswordConfirm);
        Controls.Add(_txtPassword);
        Controls.Add(guna2ImageButton1);
        Controls.Add(panel2);
        Controls.Add(_btnCancel);
        Controls.Add(_btnRegister);
        Controls.Add(_txtPhone);
        Controls.Add(_txtEmail);
        Controls.Add(_txtLastName);
        Controls.Add(_txtFirstName);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "FormRegister";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регистрация";
        FormClosing += FormRegister_FormClosing;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
    private Guna.UI2.WinForms.Guna2TextBox _txtPassword;
    private Guna.UI2.WinForms.Guna2TextBox _txtPasswordConfirm;
    private Guna.UI2.WinForms.Guna2TextBox _txtFirstName;
    private Guna.UI2.WinForms.Guna2TextBox _txtLastName;
    private Guna.UI2.WinForms.Guna2TextBox _txtEmail;
    private Guna.UI2.WinForms.Guna2TextBox _txtPhone;
    private Guna.UI2.WinForms.Guna2Button _btnRegister;
    private Guna.UI2.WinForms.Guna2Button _btnCancel;
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2CheckBox guna2CheckBox2;
    private Guna2ImageButton guna2ImageButton1;
} 