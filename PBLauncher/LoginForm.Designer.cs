
namespace PBLauncher
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_minimized = new Guna.UI.WinForms.GunaButton();
            this.btn_close = new Guna.UI.WinForms.GunaButton();
            this.btn_register = new Guna.UI.WinForms.GunaButton();
            this.btn_login = new Guna.UI.WinForms.GunaButton();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.status_barra = new System.Windows.Forms.StatusStrip();
            this.lbl_message_barra = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_checked_id = new Guna.UI.WinForms.GunaLabel();
            this.checkboxID = new Guna.UI.WinForms.GunaSwitch();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pLoading = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.panel_top.SuspendLayout();
            this.status_barra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.BackgroundImage = global::PBLauncher.Properties.Resources.div1;
            this.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel_top.Controls.Add(this.btn_minimized);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Controls.Add(this.btn_register);
            this.panel_top.Controls.Add(this.btn_login);
            this.panel_top.Controls.Add(this.txtUsername);
            this.panel_top.Controls.Add(this.status_barra);
            this.panel_top.Controls.Add(this.lbl_checked_id);
            this.panel_top.Controls.Add(this.checkboxID);
            this.panel_top.Controls.Add(this.txtPassword);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.pLoading);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(316, 241);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            // 
            // btn_minimized
            // 
            this.btn_minimized.AnimationHoverSpeed = 0.07F;
            this.btn_minimized.AnimationSpeed = 0.03F;
            this.btn_minimized.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimized.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_minimized.BorderColor = System.Drawing.Color.Transparent;
            this.btn_minimized.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_minimized.FocusedColor = System.Drawing.Color.Empty;
            this.btn_minimized.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimized.ForeColor = System.Drawing.Color.White;
            this.btn_minimized.Image = null;
            this.btn_minimized.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_minimized.Location = new System.Drawing.Point(226, 12);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_minimized.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_minimized.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_minimized.OnHoverImage = null;
            this.btn_minimized.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_minimized.Radius = 5;
            this.btn_minimized.Size = new System.Drawing.Size(25, 22);
            this.btn_minimized.TabIndex = 30;
            this.btn_minimized.Text = "_";
            this.btn_minimized.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_minimized.Click += new System.EventHandler(this.btn_minimized_Click);
            // 
            // btn_close
            // 
            this.btn_close.AnimationHoverSpeed = 0.07F;
            this.btn_close.AnimationSpeed = 0.03F;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_close.BorderColor = System.Drawing.Color.Transparent;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.FocusedColor = System.Drawing.Color.Empty;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = null;
            this.btn_close.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_close.Location = new System.Drawing.Point(254, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_close.Radius = 5;
            this.btn_close.Size = new System.Drawing.Size(25, 22);
            this.btn_close.TabIndex = 29;
            this.btn_close.Text = "X";
            this.btn_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_register
            // 
            this.btn_register.AnimationHoverSpeed = 0.07F;
            this.btn_register.AnimationSpeed = 0.03F;
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_register.BorderColor = System.Drawing.Color.Transparent;
            this.btn_register.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_register.FocusedColor = System.Drawing.Color.Empty;
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Image = null;
            this.btn_register.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_register.Location = new System.Drawing.Point(174, 159);
            this.btn_register.Name = "btn_register";
            this.btn_register.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_register.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_register.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_register.OnHoverImage = null;
            this.btn_register.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_register.Radius = 5;
            this.btn_register.Size = new System.Drawing.Size(105, 50);
            this.btn_register.TabIndex = 28;
            this.btn_register.Text = "No String";
            this.btn_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_login
            // 
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = null;
            this.btn_login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_login.Location = new System.Drawing.Point(38, 159);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_login.Radius = 5;
            this.btn_login.Size = new System.Drawing.Size(105, 50);
            this.btn_login.TabIndex = 27;
            this.btn_login.Text = "No String";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(38, 46);
            this.txtUsername.MaxLength = 10;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 5;
            this.txtUsername.Size = new System.Drawing.Size(241, 30);
            this.txtUsername.TabIndex = 19;
            // 
            // status_barra
            // 
            this.status_barra.BackColor = System.Drawing.Color.Transparent;
            this.status_barra.Dock = System.Windows.Forms.DockStyle.None;
            this.status_barra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_barra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.status_barra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_message_barra});
            this.status_barra.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.status_barra.Location = new System.Drawing.Point(60, 212);
            this.status_barra.Name = "status_barra";
            this.status_barra.Size = new System.Drawing.Size(106, 20);
            this.status_barra.SizingGrip = false;
            this.status_barra.TabIndex = 26;
            this.status_barra.Text = "Barra Menu";
            this.status_barra.Visible = false;
            // 
            // lbl_message_barra
            // 
            this.lbl_message_barra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_message_barra.Name = "lbl_message_barra";
            this.lbl_message_barra.Size = new System.Drawing.Size(60, 15);
            this.lbl_message_barra.Text = "No String";
            // 
            // lbl_checked_id
            // 
            this.lbl_checked_id.AutoSize = true;
            this.lbl_checked_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_checked_id.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_checked_id.Location = new System.Drawing.Point(74, 129);
            this.lbl_checked_id.Name = "lbl_checked_id";
            this.lbl_checked_id.Size = new System.Drawing.Size(45, 15);
            this.lbl_checked_id.TabIndex = 22;
            this.lbl_checked_id.Text = "Save ID";
            // 
            // checkboxID
            // 
            this.checkboxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkboxID.BaseColor = System.Drawing.SystemColors.Control;
            this.checkboxID.CheckedOffColor = System.Drawing.Color.DarkGray;
            this.checkboxID.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.checkboxID.FillColor = System.Drawing.Color.White;
            this.checkboxID.Location = new System.Drawing.Point(40, 125);
            this.checkboxID.Name = "checkboxID";
            this.checkboxID.Size = new System.Drawing.Size(28, 20);
            this.checkboxID.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(38, 91);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Radius = 5;
            this.txtPassword.Size = new System.Drawing.Size(241, 32);
            this.txtPassword.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("SimSun", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 9);
            this.label2.TabIndex = 14;
            this.label2.Text = "PASSWORD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 9);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLoading
            // 
            this.pLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pLoading.Enabled = false;
            this.pLoading.Location = new System.Drawing.Point(88, 44);
            this.pLoading.Name = "pLoading";
            this.pLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.pLoading.Size = new System.Drawing.Size(132, 143);
            this.pLoading.TabIndex = 23;
            this.pLoading.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::PBLauncher.Properties.Resources._bg_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(316, 241);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBLauncher - Login";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.status_barra.ResumeLayout(false);
            this.status_barra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private Guna.UI.WinForms.GunaSwitch checkboxID;
        private Guna.UI.WinForms.GunaLabel lbl_checked_id;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator pLoading;
        private System.Windows.Forms.StatusStrip status_barra;
        private System.Windows.Forms.ToolStripStatusLabel lbl_message_barra;
        private Guna.UI.WinForms.GunaButton btn_login;
        private Guna.UI.WinForms.GunaButton btn_register;
        private Guna.UI.WinForms.GunaButton btn_close;
        private Guna.UI.WinForms.GunaButton btn_minimized;
    }
}