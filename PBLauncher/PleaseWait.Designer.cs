﻿namespace PBLauncher
{
    partial class PleaseWait
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer
        public static readonly string Credits = "https://github.com/ForceFK";
        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PleaseWait));
            this.panel_label = new System.Windows.Forms.Panel();
            this.lb_loading = new System.Windows.Forms.Label();
            this.panel_label.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_label
            // 
            this.panel_label.BackColor = System.Drawing.Color.Transparent;
            this.panel_label.Controls.Add(this.lb_loading);
            this.panel_label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_label.Location = new System.Drawing.Point(0, 150);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(473, 29);
            this.panel_label.TabIndex = 0;
            // 
            // lb_loading
            // 
            this.lb_loading.BackColor = System.Drawing.Color.Transparent;
            this.lb_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_loading.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loading.ForeColor = System.Drawing.Color.White;
            this.lb_loading.Location = new System.Drawing.Point(0, 0);
            this.lb_loading.Name = "lb_loading";
            this.lb_loading.Size = new System.Drawing.Size(473, 29);
            this.lb_loading.TabIndex = 0;
            this.lb_loading.Text = "NonString";
            this.lb_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_loading.Click += new System.EventHandler(this.lb_loading_Click);
            // 
            // PleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PBLauncher.Properties.Resources.bg_loading;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 179);
            this.Controls.Add(this.panel_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PleaseWait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Please Wait";
            this.Load += new System.EventHandler(this.PleaseWait_Load);
            this.panel_label.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.Label lb_loading;
    }
}

