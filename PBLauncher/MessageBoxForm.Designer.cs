namespace PBLauncher
{
    partial class MessageBoxForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Grup1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnOK = new Guna.UI.WinForms.GunaButton();
            this.lblText = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.Grup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // Grup1
            // 
            this.Grup1.BackColor = System.Drawing.Color.Transparent;
            this.Grup1.BaseColor = System.Drawing.Color.White;
            this.Grup1.BorderColor = System.Drawing.Color.Gainsboro;
            this.Grup1.Controls.Add(this.btnClose);
            this.Grup1.Controls.Add(this.btnOK);
            this.Grup1.Controls.Add(this.lblText);
            this.Grup1.Controls.Add(this.lblTitle);
            this.Grup1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Grup1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.Grup1.Location = new System.Drawing.Point(-1, 0);
            this.Grup1.Name = "Grup1";
            this.Grup1.Size = new System.Drawing.Size(314, 167);
            this.Grup1.TabIndex = 0;
            this.Grup1.TextLocation = new System.Drawing.Point(10, 8);
            this.Grup1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.groupForm_MouseDown);
            this.Grup1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.groupForm_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(279, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 5;
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.AnimationHoverSpeed = 0.07F;
            this.btnOK.AnimationSpeed = 0.03F;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btnOK.BorderColor = System.Drawing.Color.Transparent;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.FocusedColor = System.Drawing.Color.Empty;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = null;
            this.btnOK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOK.Location = new System.Drawing.Point(268, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(89)))), ((int)(((byte)(113)))));
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOK.OnHoverImage = null;
            this.btnOK.OnPressedColor = System.Drawing.Color.Black;
            this.btnOK.Radius = 5;
            this.btnOK.Size = new System.Drawing.Size(36, 30);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblText
            // 
            this.lblText.AutoEllipsis = true;
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblText.Location = new System.Drawing.Point(12, 44);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(57, 15);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "No String";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PBLauncher";
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 166);
            this.Controls.Add(this.Grup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBox";
            this.Grup1.ResumeLayout(false);
            this.Grup1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGroupBox Grup1;
        private Guna.UI.WinForms.GunaButton btnOK;
        private Guna.UI.WinForms.GunaLabel lblText;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private Guna.UI.WinForms.GunaButton btnClose;
    }
}