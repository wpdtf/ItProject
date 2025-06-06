namespace ItProject.UI.FormDialog;

partial class FormAuth : Form
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuth));
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        panel2 = new Panel();
        guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
        label4 = new Label();
        Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
        Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
        guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
        guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
        guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
        label1 = new Label();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.Green;
        panel2.Controls.Add(guna2ControlBox2);
        panel2.Controls.Add(label3);
        panel2.Dock = DockStyle.Top;
        panel2.ForeColor = SystemColors.ActiveCaption;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(4);
        panel2.Name = "panel2";
        panel2.Size = new Size(438, 40);
        panel2.TabIndex = 26;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges1;
        guna2ControlBox2.FillColor = Color.FromArgb(0, 64, 0);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(390, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges2;
        guna2ControlBox2.Size = new Size(35, 30);
        guna2ControlBox2.TabIndex = 20;
        guna2ControlBox2.Click += Guna2Button1_Click_1;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label3.ForeColor = Color.White;
        label3.Location = new Point(10, 11);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(101, 20);
        label3.TabIndex = 17;
        label3.Text = "Авторизация";
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
        // label4
        // 
        label4.AutoSize = true;
        label4.Cursor = Cursors.Hand;
        label4.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
        label4.ForeColor = Color.FromArgb(64, 64, 64);
        label4.Location = new Point(124, 161);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(87, 19);
        label4.TabIndex = 43;
        label4.Text = "Регистрация";
        label4.Click += label4_Click;
        // 
        // Guna2Button1
        // 
        Guna2Button1.Animated = true;
        Guna2Button1.BorderColor = Color.FromArgb(16, 90, 101);
        Guna2Button1.BorderRadius = 12;
        Guna2Button1.Cursor = Cursors.Hand;
        Guna2Button1.CustomizableEdges = customizableEdges4;
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray;
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        Guna2Button1.FillColor = Color.Green;
        Guna2Button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Guna2Button1.ForeColor = Color.White;
        Guna2Button1.Location = new Point(258, 184);
        Guna2Button1.Margin = new Padding(4);
        Guna2Button1.Name = "Guna2Button1";
        Guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges5;
        Guna2Button1.Size = new Size(125, 40);
        Guna2Button1.TabIndex = 42;
        Guna2Button1.Text = "Выйти";
        Guna2Button1.Click += Guna2Button1_Click_1;
        // 
        // Guna2Button2
        // 
        Guna2Button2.Animated = true;
        Guna2Button2.BorderColor = Color.FromArgb(16, 90, 101);
        Guna2Button2.BorderRadius = 12;
        Guna2Button2.Cursor = Cursors.Hand;
        Guna2Button2.CustomizableEdges = customizableEdges6;
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray;
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        Guna2Button2.FillColor = Color.Green;
        Guna2Button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
        Guna2Button2.ForeColor = Color.White;
        Guna2Button2.Location = new Point(124, 184);
        Guna2Button2.Margin = new Padding(4);
        Guna2Button2.Name = "Guna2Button2";
        Guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges7;
        Guna2Button2.Size = new Size(125, 40);
        Guna2Button2.TabIndex = 40;
        Guna2Button2.Text = "Войти";
        Guna2Button2.Click += Guna2Button2_Click;
        // 
        // guna2TextBox2
        // 
        guna2TextBox2.BorderRadius = 12;
        guna2TextBox2.Cursor = Cursors.IBeam;
        guna2TextBox2.CustomizableEdges = customizableEdges8;
        guna2TextBox2.DefaultText = "";
        guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        guna2TextBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        guna2TextBox2.Location = new Point(124, 118);
        guna2TextBox2.Margin = new Padding(4);
        guna2TextBox2.MaxLength = 16;
        guna2TextBox2.Name = "guna2TextBox2";
        guna2TextBox2.PasswordChar = '●';
        guna2TextBox2.PlaceholderText = "Пароль";
        guna2TextBox2.SelectedText = "";
        guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges9;
        guna2TextBox2.Size = new Size(259, 38);
        guna2TextBox2.TabIndex = 2;
        // 
        // guna2TextBox1
        // 
        guna2TextBox1.BorderRadius = 12;
        guna2TextBox1.Cursor = Cursors.IBeam;
        guna2TextBox1.CustomizableEdges = customizableEdges10;
        guna2TextBox1.DefaultText = "";
        guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        guna2TextBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        guna2TextBox1.Location = new Point(124, 72);
        guna2TextBox1.Margin = new Padding(4);
        guna2TextBox1.MaxLength = 255;
        guna2TextBox1.Name = "guna2TextBox1";
        guna2TextBox1.PlaceholderText = "Логин";
        guna2TextBox1.SelectedText = "";
        guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges11;
        guna2TextBox1.Size = new Size(259, 38);
        guna2TextBox1.TabIndex = 1;
        // 
        // guna2ImageButton1
        // 
        guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
        guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
        guna2ImageButton1.ImageOffset = new Point(0, 0);
        guna2ImageButton1.ImageRotate = 0F;
        guna2ImageButton1.Location = new Point(0, 72);
        guna2ImageButton1.Name = "guna2ImageButton1";
        guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
        guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
        guna2ImageButton1.Size = new Size(114, 84);
        guna2ImageButton1.TabIndex = 44;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Cursor = Cursors.Hand;
        label1.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
        label1.ForeColor = Color.FromArgb(64, 64, 64);
        label1.Location = new Point(258, 161);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(112, 19);
        label1.TabIndex = 45;
        label1.Text = "Забыли пароль?";
        label1.Click += label1_Click;
        // 
        // FormAuth
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(438, 250);
        Controls.Add(label1);
        Controls.Add(guna2ImageButton1);
        Controls.Add(label4);
        Controls.Add(Guna2Button1);
        Controls.Add(Guna2Button2);
        Controls.Add(guna2TextBox2);
        Controls.Add(guna2TextBox1);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "FormAuth";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Авторизация";
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label3;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label4;
    private Guna.UI2.WinForms.Guna2Button Guna2Button1;
    private Guna.UI2.WinForms.Guna2Button Guna2Button2;
    private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    private Label label1;
}
