using Guna.UI2.WinForms;

namespace ItProject.UI.FormDialog;

partial class FormChat
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
        _btnSend = new Guna2Button();
        _btnCancel = new Guna2Button();
        panel2 = new Panel();
        guna2ControlBox1 = new Guna2ControlBox();
        guna2ControlBox2 = new Guna2ControlBox();
        label3 = new Label();
        guna2DragControl1 = new Guna2DragControl(components);
        guna2BorderlessForm1 = new Guna2BorderlessForm(components);
        _Message = new Guna2TextBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // _btnSend
        // 
        _btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnSend.BorderRadius = 5;
        _btnSend.CustomizableEdges = customizableEdges1;
        _btnSend.DisabledState.BorderColor = Color.DarkGray;
        _btnSend.DisabledState.CustomBorderColor = Color.DarkGray;
        _btnSend.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        _btnSend.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        _btnSend.FillColor = Color.Green;
        _btnSend.Font = new Font("Segoe UI", 9F);
        _btnSend.ForeColor = Color.White;
        _btnSend.Location = new Point(293, 548);
        _btnSend.Name = "_btnSend";
        _btnSend.ShadowDecoration.CustomizableEdges = customizableEdges2;
        _btnSend.Size = new Size(136, 40);
        _btnSend.TabIndex = 7;
        _btnSend.Text = "Отправить";
        _btnSend.Click += _btnRegister_Click;
        // 
        // _btnCancel
        // 
        _btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _btnCancel.BorderRadius = 5;
        _btnCancel.CustomizableEdges = customizableEdges3;
        _btnCancel.DisabledState.BorderColor = Color.DarkGray;
        _btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
        _btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
        _btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
        _btnCancel.FillColor = Color.Green;
        _btnCancel.Font = new Font("Segoe UI", 9F);
        _btnCancel.ForeColor = Color.White;
        _btnCancel.Location = new Point(435, 548);
        _btnCancel.Name = "_btnCancel";
        _btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
        _btnCancel.Size = new Size(73, 40);
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
        panel2.Size = new Size(520, 40);
        panel2.TabIndex = 27;
        // 
        // guna2ControlBox1
        // 
        guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox1.Animated = true;
        guna2ControlBox1.Cursor = Cursors.Hand;
        guna2ControlBox1.CustomizableEdges = customizableEdges5;
        guna2ControlBox1.FillColor = Color.FromArgb(0, 64, 0);
        guna2ControlBox1.IconColor = Color.White;
        guna2ControlBox1.Location = new Point(473, 6);
        guna2ControlBox1.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox1.Name = "guna2ControlBox1";
        guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
        guna2ControlBox1.Size = new Size(35, 30);
        guna2ControlBox1.TabIndex = 21;
        guna2ControlBox1.Click += _btnCancel_Click;
        // 
        // guna2ControlBox2
        // 
        guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        guna2ControlBox2.Animated = true;
        guna2ControlBox2.Cursor = Cursors.Hand;
        guna2ControlBox2.CustomizableEdges = customizableEdges7;
        guna2ControlBox2.FillColor = Color.FromArgb(0, 0, 64);
        guna2ControlBox2.IconColor = Color.White;
        guna2ControlBox2.Location = new Point(715, 5);
        guna2ControlBox2.Margin = new Padding(3, 2, 3, 2);
        guna2ControlBox2.Name = "guna2ControlBox2";
        guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
        label3.Size = new Size(113, 20);
        label3.TabIndex = 17;
        label3.Text = "Чат по заказу: ";
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
        // _Message
        // 
        _Message.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        _Message.AutoScroll = true;
        _Message.BorderRadius = 12;
        _Message.Cursor = Cursors.IBeam;
        _Message.CustomizableEdges = customizableEdges9;
        _Message.DefaultText = "";
        _Message.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
        _Message.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
        _Message.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
        _Message.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
        _Message.FocusedState.BorderColor = Color.FromArgb(0, 64, 0);
        _Message.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        _Message.ForeColor = Color.Black;
        _Message.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
        _Message.Location = new Point(163, 468);
        _Message.Multiline = true;
        _Message.Name = "_Message";
        _Message.PlaceholderText = "Сообщение...";
        _Message.ScrollBars = ScrollBars.Vertical;
        _Message.SelectedText = "";
        _Message.ShadowDecoration.CustomizableEdges = customizableEdges10;
        _Message.Size = new Size(345, 74);
        _Message.TabIndex = 63;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
        flowLayoutPanel1.Location = new Point(10, 47);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(498, 415);
        flowLayoutPanel1.TabIndex = 64;
        flowLayoutPanel1.WrapContents = false;
        // 
        // FormChat
        // 
        AllowDrop = true;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(520, 600);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(_Message);
        Controls.Add(panel2);
        Controls.Add(_btnCancel);
        Controls.Add(_btnSend);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "FormChat";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Регистрация";
        FormClosing += FormRegister_FormClosing;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }
    private Guna.UI2.WinForms.Guna2Button _btnSend;
    private Guna.UI2.WinForms.Guna2Button _btnCancel;
    private Panel panel2;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    private Label label3;
    private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2TextBox _Message;
    private FlowLayoutPanel flowLayoutPanel1;
} 