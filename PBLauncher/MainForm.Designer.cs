namespace PBLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.WEB_Ranking = new System.Windows.Forms.WebBrowser();
            this.panel_end = new System.Windows.Forms.Panel();
            this.CheckPBox = new Guna.UI.WinForms.GunaButton();
            this.Total_Bar = new System.Windows.Forms.PictureBox();
            this.StartPBox = new Guna.UI.WinForms.GunaButton();
            this.Total_BarFixo = new System.Windows.Forms.PictureBox();
            this.LTitulo = new System.Windows.Forms.Label();
            this.Arquivo_Bar = new System.Windows.Forms.PictureBox();
            this.LTotalFixo = new System.Windows.Forms.Label();
            this.LAquivoFixo = new System.Windows.Forms.Label();
            this.Arquivo_BarFixo = new System.Windows.Forms.PictureBox();
            this.LArquivo = new System.Windows.Forms.Label();
            this.UpdatePBox = new Guna.UI.WinForms.GunaButton();
            this.WEB_Announce = new System.Windows.Forms.WebBrowser();
            this.LauncherHeader = new System.Windows.Forms.Panel();
            this.btn_youtube = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btn_site = new Guna.UI.WinForms.GunaButton();
            this.btn_facebook = new Guna.UI.WinForms.GunaButton();
            this.btn_discord = new Guna.UI.WinForms.GunaButton();
            this.btn_config = new Guna.UI.WinForms.GunaButton();
            this.btn_minimized = new Guna.UI.WinForms.GunaButton();
            this.language_btn = new System.Windows.Forms.PictureBox();
            this.btn_close = new Guna.UI.WinForms.GunaButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_my_info = new Guna.UI.WinForms.GunaLabel();
            this.Separator0 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_PlayerPCCafe = new Guna.UI.WinForms.GunaLabel();
            this.lbl_pccafe = new Guna.UI.WinForms.GunaLabel();
            this.lbl_playerclan = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PlayerExp = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Player_Clan = new Guna.UI.WinForms.GunaLabel();
            this.lbl_exp = new Guna.UI.WinForms.GunaLabel();
            this.PictureRank = new Guna.UI.WinForms.GunaPictureBox();
            this.lbl_PlayerRank = new Guna.UI.WinForms.GunaLabel();
            this.lbl_uid = new Guna.UI.WinForms.GunaLabel();
            this.lbl_name = new Guna.UI.WinForms.GunaLabel();
            this.lbl_rank = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PlayerID = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PlayerName = new Guna.UI.WinForms.GunaLabel();
            this.MyInfoProgressBar = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            this.PictureWarningMyInfo = new Guna.UI.WinForms.GunaPictureBox();
            this.Separator1 = new Guna.UI.WinForms.GunaSeparator();
            this.lbl_playergold = new Guna.UI.WinForms.GunaLabel();
            this.lbl_playercash = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Player_Gold = new Guna.UI.WinForms.GunaLabel();
            this.lbl_Player_Cash = new Guna.UI.WinForms.GunaLabel();
            this.lbl_account = new Guna.UI.WinForms.GunaLabel();
            this.lbl_PlayerAccount = new Guna.UI.WinForms.GunaLabel();
            this.panel_top.SuspendLayout();
            this.panel_end.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).BeginInit();
            this.LauncherHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_btn)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWarningMyInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_top.Controls.Add(this.WEB_Ranking);
            this.panel_top.Controls.Add(this.panel_end);
            this.panel_top.Controls.Add(this.WEB_Announce);
            this.panel_top.Controls.Add(this.LauncherHeader);
            this.panel_top.Controls.Add(this.panel4);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(906, 501);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // WEB_Ranking
            // 
            this.WEB_Ranking.IsWebBrowserContextMenuEnabled = false;
            this.WEB_Ranking.Location = new System.Drawing.Point(358, 58);
            this.WEB_Ranking.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_Ranking.Name = "WEB_Ranking";
            this.WEB_Ranking.ScrollBarsEnabled = false;
            this.WEB_Ranking.Size = new System.Drawing.Size(334, 257);
            this.WEB_Ranking.TabIndex = 2;
            this.WEB_Ranking.TabStop = false;
            this.WEB_Ranking.Visible = false;
            this.WEB_Ranking.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WEB_Ranking_DocumentCompleted);
            // 
            // panel_end
            // 
            this.panel_end.BackColor = System.Drawing.Color.Transparent;
            this.panel_end.BackgroundImage = global::PBLauncher.Properties.Resources.div1;
            this.panel_end.Controls.Add(this.CheckPBox);
            this.panel_end.Controls.Add(this.Total_Bar);
            this.panel_end.Controls.Add(this.StartPBox);
            this.panel_end.Controls.Add(this.Total_BarFixo);
            this.panel_end.Controls.Add(this.LTitulo);
            this.panel_end.Controls.Add(this.Arquivo_Bar);
            this.panel_end.Controls.Add(this.LTotalFixo);
            this.panel_end.Controls.Add(this.LAquivoFixo);
            this.panel_end.Controls.Add(this.Arquivo_BarFixo);
            this.panel_end.Controls.Add(this.LArquivo);
            this.panel_end.Controls.Add(this.UpdatePBox);
            this.panel_end.Location = new System.Drawing.Point(0, 406);
            this.panel_end.Name = "panel_end";
            this.panel_end.Size = new System.Drawing.Size(906, 94);
            this.panel_end.TabIndex = 1;
            this.panel_end.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.panel_end.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // CheckPBox
            // 
            this.CheckPBox.AnimationHoverSpeed = 0.07F;
            this.CheckPBox.AnimationSpeed = 0.03F;
            this.CheckPBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckPBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.CheckPBox.BorderColor = System.Drawing.Color.Transparent;
            this.CheckPBox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CheckPBox.Enabled = false;
            this.CheckPBox.FocusedColor = System.Drawing.Color.Empty;
            this.CheckPBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPBox.ForeColor = System.Drawing.Color.White;
            this.CheckPBox.Image = null;
            this.CheckPBox.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckPBox.ImageSize = new System.Drawing.Size(25, 20);
            this.CheckPBox.Location = new System.Drawing.Point(707, 30);
            this.CheckPBox.Name = "CheckPBox";
            this.CheckPBox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CheckPBox.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.CheckPBox.OnHoverForeColor = System.Drawing.Color.White;
            this.CheckPBox.OnHoverImage = null;
            this.CheckPBox.OnPressedColor = System.Drawing.Color.Transparent;
            this.CheckPBox.Radius = 5;
            this.CheckPBox.Size = new System.Drawing.Size(54, 60);
            this.CheckPBox.TabIndex = 43;
            this.CheckPBox.Text = "CHECK";
            this.CheckPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CheckPBox.Click += new System.EventHandler(this.CheckPBox_Click);
            // 
            // Total_Bar
            // 
            this.Total_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.Total_Bar.Location = new System.Drawing.Point(12, 73);
            this.Total_Bar.Name = "Total_Bar";
            this.Total_Bar.Size = new System.Drawing.Size(555, 10);
            this.Total_Bar.TabIndex = 28;
            this.Total_Bar.TabStop = false;
            // 
            // StartPBox
            // 
            this.StartPBox.AnimationHoverSpeed = 0.07F;
            this.StartPBox.AnimationSpeed = 0.03F;
            this.StartPBox.BackColor = System.Drawing.Color.Transparent;
            this.StartPBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.StartPBox.BorderColor = System.Drawing.Color.Transparent;
            this.StartPBox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StartPBox.Enabled = false;
            this.StartPBox.FocusedColor = System.Drawing.Color.Empty;
            this.StartPBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartPBox.ForeColor = System.Drawing.Color.White;
            this.StartPBox.Image = null;
            this.StartPBox.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartPBox.ImageSize = new System.Drawing.Size(25, 20);
            this.StartPBox.Location = new System.Drawing.Point(768, 30);
            this.StartPBox.Name = "StartPBox";
            this.StartPBox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.StartPBox.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.StartPBox.OnHoverForeColor = System.Drawing.Color.White;
            this.StartPBox.OnHoverImage = null;
            this.StartPBox.OnPressedColor = System.Drawing.Color.Transparent;
            this.StartPBox.Radius = 5;
            this.StartPBox.Size = new System.Drawing.Size(130, 60);
            this.StartPBox.TabIndex = 41;
            this.StartPBox.Text = "START";
            this.StartPBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartPBox.Click += new System.EventHandler(this.StartPBox_Click);
            // 
            // Total_BarFixo
            // 
            this.Total_BarFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_BarFixo.BackColor = System.Drawing.Color.White;
            this.Total_BarFixo.Location = new System.Drawing.Point(12, 73);
            this.Total_BarFixo.Name = "Total_BarFixo";
            this.Total_BarFixo.Size = new System.Drawing.Size(555, 10);
            this.Total_BarFixo.TabIndex = 29;
            this.Total_BarFixo.TabStop = false;
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.Location = new System.Drawing.Point(9, 7);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(43, 15);
            this.LTitulo.TabIndex = 3;
            this.LTitulo.Text = "Titulo";
            // 
            // Arquivo_Bar
            // 
            this.Arquivo_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arquivo_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.Arquivo_Bar.Location = new System.Drawing.Point(12, 45);
            this.Arquivo_Bar.Name = "Arquivo_Bar";
            this.Arquivo_Bar.Size = new System.Drawing.Size(555, 10);
            this.Arquivo_Bar.TabIndex = 24;
            this.Arquivo_Bar.TabStop = false;
            this.Arquivo_Bar.Click += new System.EventHandler(this.Arquivo_Bar_Click);
            this.Arquivo_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.Arquivo_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LTotalFixo
            // 
            this.LTotalFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LTotalFixo.AutoSize = true;
            this.LTotalFixo.BackColor = System.Drawing.Color.Transparent;
            this.LTotalFixo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalFixo.ForeColor = System.Drawing.Color.White;
            this.LTotalFixo.Location = new System.Drawing.Point(9, 57);
            this.LTotalFixo.Name = "LTotalFixo";
            this.LTotalFixo.Size = new System.Drawing.Size(31, 14);
            this.LTotalFixo.TabIndex = 19;
            this.LTotalFixo.Text = "Total";
            this.LTotalFixo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LTotalFixo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LAquivoFixo
            // 
            this.LAquivoFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LAquivoFixo.AutoSize = true;
            this.LAquivoFixo.BackColor = System.Drawing.Color.Transparent;
            this.LAquivoFixo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAquivoFixo.ForeColor = System.Drawing.Color.White;
            this.LAquivoFixo.Location = new System.Drawing.Point(11, 30);
            this.LAquivoFixo.Name = "LAquivoFixo";
            this.LAquivoFixo.Size = new System.Drawing.Size(30, 14);
            this.LAquivoFixo.TabIndex = 18;
            this.LAquivoFixo.Text = "Files";
            this.LAquivoFixo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LAquivoFixo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Arquivo_BarFixo
            // 
            this.Arquivo_BarFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arquivo_BarFixo.BackColor = System.Drawing.Color.White;
            this.Arquivo_BarFixo.Location = new System.Drawing.Point(12, 45);
            this.Arquivo_BarFixo.Name = "Arquivo_BarFixo";
            this.Arquivo_BarFixo.Size = new System.Drawing.Size(555, 10);
            this.Arquivo_BarFixo.TabIndex = 27;
            this.Arquivo_BarFixo.TabStop = false;
            // 
            // LArquivo
            // 
            this.LArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LArquivo.BackColor = System.Drawing.Color.Transparent;
            this.LArquivo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LArquivo.ForeColor = System.Drawing.Color.White;
            this.LArquivo.Location = new System.Drawing.Point(58, 24);
            this.LArquivo.Name = "LArquivo";
            this.LArquivo.Size = new System.Drawing.Size(574, 21);
            this.LArquivo.TabIndex = 20;
            this.LArquivo.Text = "Arquivo...";
            this.LArquivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LArquivo.Visible = false;
            this.LArquivo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LArquivo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // UpdatePBox
            // 
            this.UpdatePBox.AnimationHoverSpeed = 0.07F;
            this.UpdatePBox.AnimationSpeed = 0.03F;
            this.UpdatePBox.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.UpdatePBox.BorderColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdatePBox.Enabled = false;
            this.UpdatePBox.FocusedColor = System.Drawing.Color.Empty;
            this.UpdatePBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePBox.ForeColor = System.Drawing.Color.White;
            this.UpdatePBox.Image = null;
            this.UpdatePBox.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdatePBox.ImageSize = new System.Drawing.Size(25, 20);
            this.UpdatePBox.Location = new System.Drawing.Point(768, 30);
            this.UpdatePBox.Name = "UpdatePBox";
            this.UpdatePBox.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UpdatePBox.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.OnHoverForeColor = System.Drawing.Color.White;
            this.UpdatePBox.OnHoverImage = null;
            this.UpdatePBox.OnPressedColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.Radius = 5;
            this.UpdatePBox.Size = new System.Drawing.Size(130, 60);
            this.UpdatePBox.TabIndex = 42;
            this.UpdatePBox.Text = "UPDATER";
            this.UpdatePBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdatePBox.Click += new System.EventHandler(this.UpdatePBox_Click);
            // 
            // WEB_Announce
            // 
            this.WEB_Announce.IsWebBrowserContextMenuEnabled = false;
            this.WEB_Announce.Location = new System.Drawing.Point(7, 58);
            this.WEB_Announce.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_Announce.Name = "WEB_Announce";
            this.WEB_Announce.ScrollBarsEnabled = false;
            this.WEB_Announce.Size = new System.Drawing.Size(345, 257);
            this.WEB_Announce.TabIndex = 2;
            this.WEB_Announce.TabStop = false;
            this.WEB_Announce.Visible = false;
            this.WEB_Announce.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WEB_Announce_DocumentCompleted);
            // 
            // LauncherHeader
            // 
            this.LauncherHeader.BackColor = System.Drawing.Color.Transparent;
            this.LauncherHeader.BackgroundImage = global::PBLauncher.Properties.Resources.div1;
            this.LauncherHeader.Controls.Add(this.btn_youtube);
            this.LauncherHeader.Controls.Add(this.gunaPictureBox1);
            this.LauncherHeader.Controls.Add(this.btn_site);
            this.LauncherHeader.Controls.Add(this.btn_facebook);
            this.LauncherHeader.Controls.Add(this.btn_discord);
            this.LauncherHeader.Controls.Add(this.btn_config);
            this.LauncherHeader.Controls.Add(this.btn_minimized);
            this.LauncherHeader.Controls.Add(this.language_btn);
            this.LauncherHeader.Controls.Add(this.btn_close);
            this.LauncherHeader.Location = new System.Drawing.Point(0, -1);
            this.LauncherHeader.Name = "LauncherHeader";
            this.LauncherHeader.Size = new System.Drawing.Size(906, 45);
            this.LauncherHeader.TabIndex = 28;
            this.LauncherHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LauncherHeader_MouseDown);
            this.LauncherHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LauncherHeader_MouseMove);
            // 
            // btn_youtube
            // 
            this.btn_youtube.AnimationHoverSpeed = 0.07F;
            this.btn_youtube.AnimationSpeed = 0.03F;
            this.btn_youtube.BackColor = System.Drawing.Color.Transparent;
            this.btn_youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_youtube.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_youtube.BorderColor = System.Drawing.Color.Transparent;
            this.btn_youtube.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_youtube.FocusedColor = System.Drawing.Color.Empty;
            this.btn_youtube.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_youtube.ForeColor = System.Drawing.Color.White;
            this.btn_youtube.Image = global::PBLauncher.Properties.Resources.Youtube;
            this.btn_youtube.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_youtube.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_youtube.Location = new System.Drawing.Point(91, 12);
            this.btn_youtube.Name = "btn_youtube";
            this.btn_youtube.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_youtube.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_youtube.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_youtube.OnHoverImage = null;
            this.btn_youtube.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_youtube.Radius = 5;
            this.btn_youtube.Size = new System.Drawing.Size(25, 22);
            this.btn_youtube.TabIndex = 39;
            this.btn_youtube.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_youtube.Click += new System.EventHandler(this.btn_youtube_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::PBLauncher.Properties.Resources.PB_FIVE_LOGO;
            this.gunaPictureBox1.Location = new System.Drawing.Point(337, -38);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(165, 122);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 36;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btn_site
            // 
            this.btn_site.AnimationHoverSpeed = 0.07F;
            this.btn_site.AnimationSpeed = 0.03F;
            this.btn_site.BackColor = System.Drawing.Color.Transparent;
            this.btn_site.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_site.BorderColor = System.Drawing.Color.Transparent;
            this.btn_site.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_site.FocusedColor = System.Drawing.Color.Empty;
            this.btn_site.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_site.ForeColor = System.Drawing.Color.White;
            this.btn_site.Image = global::PBLauncher.Properties.Resources.icone_site2;
            this.btn_site.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_site.ImageSize = new System.Drawing.Size(24, 19);
            this.btn_site.Location = new System.Drawing.Point(7, 12);
            this.btn_site.Name = "btn_site";
            this.btn_site.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_site.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_site.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_site.OnHoverImage = null;
            this.btn_site.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_site.Radius = 5;
            this.btn_site.Size = new System.Drawing.Size(25, 22);
            this.btn_site.TabIndex = 38;
            this.btn_site.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_site.Click += new System.EventHandler(this.btn_site_Click);
            // 
            // btn_facebook
            // 
            this.btn_facebook.AnimationHoverSpeed = 0.07F;
            this.btn_facebook.AnimationSpeed = 0.03F;
            this.btn_facebook.BackColor = System.Drawing.Color.Transparent;
            this.btn_facebook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_facebook.BorderColor = System.Drawing.Color.Transparent;
            this.btn_facebook.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_facebook.FocusedColor = System.Drawing.Color.Empty;
            this.btn_facebook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facebook.ForeColor = System.Drawing.Color.White;
            this.btn_facebook.Image = global::PBLauncher.Properties.Resources.icone_facebook;
            this.btn_facebook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_facebook.ImageSize = new System.Drawing.Size(25, 20);
            this.btn_facebook.Location = new System.Drawing.Point(35, 12);
            this.btn_facebook.Name = "btn_facebook";
            this.btn_facebook.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_facebook.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_facebook.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_facebook.OnHoverImage = null;
            this.btn_facebook.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_facebook.Radius = 5;
            this.btn_facebook.Size = new System.Drawing.Size(25, 22);
            this.btn_facebook.TabIndex = 37;
            this.btn_facebook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_facebook.Click += new System.EventHandler(this.btn_facebook_Click);
            // 
            // btn_discord
            // 
            this.btn_discord.AnimationHoverSpeed = 0.07F;
            this.btn_discord.AnimationSpeed = 0.03F;
            this.btn_discord.BackColor = System.Drawing.Color.Transparent;
            this.btn_discord.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_discord.BorderColor = System.Drawing.Color.Transparent;
            this.btn_discord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_discord.FocusedColor = System.Drawing.Color.Empty;
            this.btn_discord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_discord.ForeColor = System.Drawing.Color.White;
            this.btn_discord.Image = global::PBLauncher.Properties.Resources.icone_discord;
            this.btn_discord.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_discord.ImageSize = new System.Drawing.Size(25, 20);
            this.btn_discord.Location = new System.Drawing.Point(63, 12);
            this.btn_discord.Name = "btn_discord";
            this.btn_discord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_discord.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_discord.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_discord.OnHoverImage = null;
            this.btn_discord.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_discord.Radius = 5;
            this.btn_discord.Size = new System.Drawing.Size(25, 22);
            this.btn_discord.TabIndex = 36;
            this.btn_discord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_discord.Click += new System.EventHandler(this.btn_discord_Click);
            // 
            // btn_config
            // 
            this.btn_config.AnimationHoverSpeed = 0.07F;
            this.btn_config.AnimationSpeed = 0.03F;
            this.btn_config.BackColor = System.Drawing.Color.Transparent;
            this.btn_config.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.btn_config.BorderColor = System.Drawing.Color.Transparent;
            this.btn_config.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_config.FocusedColor = System.Drawing.Color.Empty;
            this.btn_config.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.Image = global::PBLauncher.Properties.Resources.icone_config;
            this.btn_config.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_config.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_config.Location = new System.Drawing.Point(815, 12);
            this.btn_config.Name = "btn_config";
            this.btn_config.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_config.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_config.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_config.OnHoverImage = null;
            this.btn_config.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_config.Radius = 5;
            this.btn_config.Size = new System.Drawing.Size(25, 22);
            this.btn_config.TabIndex = 35;
            this.btn_config.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
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
            this.btn_minimized.Location = new System.Drawing.Point(845, 12);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_minimized.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_minimized.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_minimized.OnHoverImage = null;
            this.btn_minimized.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_minimized.Radius = 5;
            this.btn_minimized.Size = new System.Drawing.Size(25, 22);
            this.btn_minimized.TabIndex = 34;
            this.btn_minimized.Text = "_";
            this.btn_minimized.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_minimized.Click += new System.EventHandler(this.btn_minimized_Click);
            // 
            // language_btn
            // 
            this.language_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.language_btn.Image = global::PBLauncher.Properties.Resources.br_;
            this.language_btn.Location = new System.Drawing.Point(779, 12);
            this.language_btn.Name = "language_btn";
            this.language_btn.Size = new System.Drawing.Size(29, 22);
            this.language_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.language_btn.TabIndex = 32;
            this.language_btn.TabStop = false;
            this.language_btn.Click += new System.EventHandler(this.language_btn_Click);
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
            this.btn_close.Location = new System.Drawing.Point(873, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btn_close.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_close.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnPressedColor = System.Drawing.Color.Transparent;
            this.btn_close.Radius = 5;
            this.btn_close.Size = new System.Drawing.Size(25, 22);
            this.btn_close.TabIndex = 33;
            this.btn_close.Text = "X";
            this.btn_close.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::PBLauncher.Properties.Resources.div1;
            this.panel4.Controls.Add(this.lbl_account);
            this.panel4.Controls.Add(this.lbl_PlayerAccount);
            this.panel4.Controls.Add(this.lbl_Player_Cash);
            this.panel4.Controls.Add(this.lbl_Player_Gold);
            this.panel4.Controls.Add(this.lbl_playercash);
            this.panel4.Controls.Add(this.lbl_playergold);
            this.panel4.Controls.Add(this.lbl_my_info);
            this.panel4.Controls.Add(this.Separator0);
            this.panel4.Controls.Add(this.lbl_PlayerPCCafe);
            this.panel4.Controls.Add(this.lbl_pccafe);
            this.panel4.Controls.Add(this.lbl_playerclan);
            this.panel4.Controls.Add(this.lbl_PlayerExp);
            this.panel4.Controls.Add(this.lbl_Player_Clan);
            this.panel4.Controls.Add(this.lbl_exp);
            this.panel4.Controls.Add(this.PictureRank);
            this.panel4.Controls.Add(this.lbl_PlayerRank);
            this.panel4.Controls.Add(this.lbl_uid);
            this.panel4.Controls.Add(this.lbl_name);
            this.panel4.Controls.Add(this.lbl_rank);
            this.panel4.Controls.Add(this.lbl_PlayerID);
            this.panel4.Controls.Add(this.lbl_PlayerName);
            this.panel4.Controls.Add(this.MyInfoProgressBar);
            this.panel4.Controls.Add(this.PictureWarningMyInfo);
            this.panel4.Controls.Add(this.Separator1);
            this.panel4.Location = new System.Drawing.Point(698, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 257);
            this.panel4.TabIndex = 31;
            // 
            // lbl_my_info
            // 
            this.lbl_my_info.AutoSize = true;
            this.lbl_my_info.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_my_info.Location = new System.Drawing.Point(4, 8);
            this.lbl_my_info.Name = "lbl_my_info";
            this.lbl_my_info.Size = new System.Drawing.Size(67, 17);
            this.lbl_my_info.TabIndex = 1;
            this.lbl_my_info.Text = "No String";
            this.lbl_my_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Separator0
            // 
            this.Separator0.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.Separator0.Location = new System.Drawing.Point(-14, -4);
            this.Separator0.Name = "Separator0";
            this.Separator0.Size = new System.Drawing.Size(214, 10);
            this.Separator0.TabIndex = 40;
            // 
            // lbl_PlayerPCCafe
            // 
            this.lbl_PlayerPCCafe.AutoSize = true;
            this.lbl_PlayerPCCafe.Enabled = false;
            this.lbl_PlayerPCCafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerPCCafe.Location = new System.Drawing.Point(50, 151);
            this.lbl_PlayerPCCafe.Name = "lbl_PlayerPCCafe";
            this.lbl_PlayerPCCafe.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlayerPCCafe.TabIndex = 9;
            this.lbl_PlayerPCCafe.Text = "No String";
            this.lbl_PlayerPCCafe.Visible = false;
            // 
            // lbl_pccafe
            // 
            this.lbl_pccafe.AutoSize = true;
            this.lbl_pccafe.Enabled = false;
            this.lbl_pccafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pccafe.Location = new System.Drawing.Point(9, 151);
            this.lbl_pccafe.Name = "lbl_pccafe";
            this.lbl_pccafe.Size = new System.Drawing.Size(28, 15);
            this.lbl_pccafe.TabIndex = 5;
            this.lbl_pccafe.Text = "Vip:";
            this.lbl_pccafe.Visible = false;
            // 
            // lbl_playerclan
            // 
            this.lbl_playerclan.AutoSize = true;
            this.lbl_playerclan.Enabled = false;
            this.lbl_playerclan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerclan.Location = new System.Drawing.Point(9, 173);
            this.lbl_playerclan.Name = "lbl_playerclan";
            this.lbl_playerclan.Size = new System.Drawing.Size(33, 15);
            this.lbl_playerclan.TabIndex = 12;
            this.lbl_playerclan.Text = "Clan:";
            this.lbl_playerclan.Visible = false;
            // 
            // lbl_PlayerExp
            // 
            this.lbl_PlayerExp.AutoSize = true;
            this.lbl_PlayerExp.Enabled = false;
            this.lbl_PlayerExp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerExp.Location = new System.Drawing.Point(50, 129);
            this.lbl_PlayerExp.Name = "lbl_PlayerExp";
            this.lbl_PlayerExp.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlayerExp.TabIndex = 15;
            this.lbl_PlayerExp.Text = "No String";
            this.lbl_PlayerExp.Visible = false;
            // 
            // lbl_Player_Clan
            // 
            this.lbl_Player_Clan.AutoSize = true;
            this.lbl_Player_Clan.Enabled = false;
            this.lbl_Player_Clan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_Clan.Location = new System.Drawing.Point(49, 173);
            this.lbl_Player_Clan.Name = "lbl_Player_Clan";
            this.lbl_Player_Clan.Size = new System.Drawing.Size(60, 15);
            this.lbl_Player_Clan.TabIndex = 13;
            this.lbl_Player_Clan.Text = "No String";
            this.lbl_Player_Clan.Visible = false;
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Enabled = false;
            this.lbl_exp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exp.Location = new System.Drawing.Point(9, 129);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(30, 15);
            this.lbl_exp.TabIndex = 14;
            this.lbl_exp.Text = "Exp:";
            this.lbl_exp.Visible = false;
            // 
            // PictureRank
            // 
            this.PictureRank.BaseColor = System.Drawing.Color.White;
            this.PictureRank.Enabled = false;
            this.PictureRank.Image = global::PBLauncher.Properties.Resources.rank_0;
            this.PictureRank.Location = new System.Drawing.Point(54, 105);
            this.PictureRank.Name = "PictureRank";
            this.PictureRank.Size = new System.Drawing.Size(22, 22);
            this.PictureRank.TabIndex = 11;
            this.PictureRank.TabStop = false;
            this.PictureRank.Visible = false;
            // 
            // lbl_PlayerRank
            // 
            this.lbl_PlayerRank.AutoSize = true;
            this.lbl_PlayerRank.Enabled = false;
            this.lbl_PlayerRank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerRank.Location = new System.Drawing.Point(76, 107);
            this.lbl_PlayerRank.Name = "lbl_PlayerRank";
            this.lbl_PlayerRank.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlayerRank.TabIndex = 8;
            this.lbl_PlayerRank.Text = "No String";
            this.lbl_PlayerRank.Visible = false;
            // 
            // lbl_uid
            // 
            this.lbl_uid.AutoSize = true;
            this.lbl_uid.Enabled = false;
            this.lbl_uid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uid.Location = new System.Drawing.Point(9, 40);
            this.lbl_uid.Name = "lbl_uid";
            this.lbl_uid.Size = new System.Drawing.Size(57, 15);
            this.lbl_uid.TabIndex = 2;
            this.lbl_uid.Text = "PlayerID:";
            this.lbl_uid.Visible = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Enabled = false;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(9, 60);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(43, 15);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            this.lbl_name.Visible = false;
            // 
            // lbl_rank
            // 
            this.lbl_rank.AutoSize = true;
            this.lbl_rank.Enabled = false;
            this.lbl_rank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rank.Location = new System.Drawing.Point(10, 107);
            this.lbl_rank.Name = "lbl_rank";
            this.lbl_rank.Size = new System.Drawing.Size(38, 15);
            this.lbl_rank.TabIndex = 4;
            this.lbl_rank.Text = "Rank:";
            this.lbl_rank.Visible = false;
            // 
            // lbl_PlayerID
            // 
            this.lbl_PlayerID.AutoSize = true;
            this.lbl_PlayerID.Enabled = false;
            this.lbl_PlayerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerID.Location = new System.Drawing.Point(67, 39);
            this.lbl_PlayerID.Name = "lbl_PlayerID";
            this.lbl_PlayerID.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlayerID.TabIndex = 6;
            this.lbl_PlayerID.Text = "No String";
            this.lbl_PlayerID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_PlayerID.Visible = false;
            // 
            // lbl_PlayerName
            // 
            this.lbl_PlayerName.AutoSize = true;
            this.lbl_PlayerName.Enabled = false;
            this.lbl_PlayerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerName.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_PlayerName.Location = new System.Drawing.Point(51, 61);
            this.lbl_PlayerName.Name = "lbl_PlayerName";
            this.lbl_PlayerName.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlayerName.TabIndex = 7;
            this.lbl_PlayerName.Text = "No String";
            this.lbl_PlayerName.Visible = false;
            // 
            // MyInfoProgressBar
            // 
            this.MyInfoProgressBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyInfoProgressBar.Enabled = false;
            this.MyInfoProgressBar.Location = new System.Drawing.Point(72, 105);
            this.MyInfoProgressBar.Name = "MyInfoProgressBar";
            this.MyInfoProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.MyInfoProgressBar.Size = new System.Drawing.Size(64, 64);
            this.MyInfoProgressBar.TabIndex = 10;
            this.MyInfoProgressBar.Visible = false;
            // 
            // PictureWarningMyInfo
            // 
            this.PictureWarningMyInfo.BaseColor = System.Drawing.Color.White;
            this.PictureWarningMyInfo.Enabled = false;
            this.PictureWarningMyInfo.Image = global::PBLauncher.Properties.Resources.warning;
            this.PictureWarningMyInfo.Location = new System.Drawing.Point(72, 102);
            this.PictureWarningMyInfo.Name = "PictureWarningMyInfo";
            this.PictureWarningMyInfo.Size = new System.Drawing.Size(64, 64);
            this.PictureWarningMyInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureWarningMyInfo.TabIndex = 32;
            this.PictureWarningMyInfo.TabStop = false;
            this.PictureWarningMyInfo.Visible = false;
            // 
            // Separator1
            // 
            this.Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(68)))), ((int)(((byte)(14)))));
            this.Separator1.Location = new System.Drawing.Point(-2, 23);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(214, 10);
            this.Separator1.TabIndex = 0;
            // 
            // lbl_playergold
            // 
            this.lbl_playergold.AutoSize = true;
            this.lbl_playergold.Enabled = false;
            this.lbl_playergold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playergold.ForeColor = System.Drawing.Color.White;
            this.lbl_playergold.Location = new System.Drawing.Point(9, 195);
            this.lbl_playergold.Name = "lbl_playergold";
            this.lbl_playergold.Size = new System.Drawing.Size(36, 15);
            this.lbl_playergold.TabIndex = 41;
            this.lbl_playergold.Text = "Gold:";
            this.lbl_playergold.Visible = false;
            // 
            // lbl_playercash
            // 
            this.lbl_playercash.AutoSize = true;
            this.lbl_playercash.Enabled = false;
            this.lbl_playercash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playercash.ForeColor = System.Drawing.Color.White;
            this.lbl_playercash.Location = new System.Drawing.Point(9, 216);
            this.lbl_playercash.Name = "lbl_playercash";
            this.lbl_playercash.Size = new System.Drawing.Size(35, 15);
            this.lbl_playercash.TabIndex = 42;
            this.lbl_playercash.Text = "Cash:";
            this.lbl_playercash.Visible = false;
            // 
            // lbl_Player_Gold
            // 
            this.lbl_Player_Gold.AutoSize = true;
            this.lbl_Player_Gold.Enabled = false;
            this.lbl_Player_Gold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_Gold.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Player_Gold.Location = new System.Drawing.Point(51, 195);
            this.lbl_Player_Gold.Name = "lbl_Player_Gold";
            this.lbl_Player_Gold.Size = new System.Drawing.Size(60, 15);
            this.lbl_Player_Gold.TabIndex = 43;
            this.lbl_Player_Gold.Text = "No String";
            this.lbl_Player_Gold.Visible = false;
            // 
            // lbl_Player_Cash
            // 
            this.lbl_Player_Cash.AutoSize = true;
            this.lbl_Player_Cash.Enabled = false;
            this.lbl_Player_Cash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_Cash.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Player_Cash.Location = new System.Drawing.Point(51, 216);
            this.lbl_Player_Cash.Name = "lbl_Player_Cash";
            this.lbl_Player_Cash.Size = new System.Drawing.Size(60, 15);
            this.lbl_Player_Cash.TabIndex = 44;
            this.lbl_Player_Cash.Text = "No String";
            this.lbl_Player_Cash.Visible = false;
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Enabled = false;
            this.lbl_account.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.Location = new System.Drawing.Point(8, 82);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(56, 15);
            this.lbl_account.TabIndex = 45;
            this.lbl_account.Text = "Account:";
            this.lbl_account.Visible = false;
            // 
            // lbl_PlayerAccount
            // 
            this.lbl_PlayerAccount.AutoSize = true;
            this.lbl_PlayerAccount.Enabled = false;
            this.lbl_PlayerAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerAccount.Location = new System.Drawing.Point(64, 83);
            this.lbl_PlayerAccount.Name = "lbl_PlayerAccount";
            this.lbl_PlayerAccount.Size = new System.Drawing.Size(60, 15);
            this.lbl_PlayerAccount.TabIndex = 46;
            this.lbl_PlayerAccount.Text = "No String";
            this.lbl_PlayerAccount.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::PBLauncher.Properties.Resources.bg_launcher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 501);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBLauncher - Combat";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_end.ResumeLayout(false);
            this.panel_end.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).EndInit();
            this.LauncherHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.language_btn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWarningMyInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_end;
        private System.Windows.Forms.PictureBox Arquivo_Bar;
        private System.Windows.Forms.Label LTotalFixo;
        private System.Windows.Forms.Label LAquivoFixo;
        private System.Windows.Forms.PictureBox Arquivo_BarFixo;
        private System.Windows.Forms.Label LArquivo;
        private System.Windows.Forms.WebBrowser WEB_Announce;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel LauncherHeader;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaLabel lbl_rank;
        private Guna.UI.WinForms.GunaLabel lbl_name;
        private Guna.UI.WinForms.GunaLabel lbl_uid;
        private Guna.UI.WinForms.GunaLabel lbl_my_info;
        private Guna.UI.WinForms.GunaSeparator Separator1;
        private Guna.UI.WinForms.GunaLabel lbl_PlayerPCCafe;
        private Guna.UI.WinForms.GunaLabel lbl_PlayerRank;
        private Guna.UI.WinForms.GunaLabel lbl_PlayerName;
        private Guna.UI.WinForms.GunaLabel lbl_PlayerID;
        private Guna.UI.WinForms.GunaLabel lbl_pccafe;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator MyInfoProgressBar;
        private Guna.UI.WinForms.GunaPictureBox PictureRank;
        private Guna.UI.WinForms.GunaLabel lbl_Player_Clan;
        private Guna.UI.WinForms.GunaLabel lbl_playerclan;
        private Guna.UI.WinForms.GunaLabel lbl_PlayerExp;
        private Guna.UI.WinForms.GunaLabel lbl_exp;
        private Guna.UI.WinForms.GunaPictureBox PictureWarningMyInfo;
        private System.Windows.Forms.PictureBox language_btn;
        private System.Windows.Forms.WebBrowser WEB_Ranking;
        private System.Windows.Forms.PictureBox Total_Bar;
        private System.Windows.Forms.PictureBox Total_BarFixo;
        private Guna.UI.WinForms.GunaButton btn_minimized;
        private Guna.UI.WinForms.GunaButton btn_close;
        private Guna.UI.WinForms.GunaButton btn_config;
        private Guna.UI.WinForms.GunaButton btn_discord;
        private Guna.UI.WinForms.GunaButton btn_facebook;
        private Guna.UI.WinForms.GunaButton btn_site;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaSeparator Separator0;
        private Guna.UI.WinForms.GunaButton StartPBox;
        private Guna.UI.WinForms.GunaButton UpdatePBox;
        private Guna.UI.WinForms.GunaButton CheckPBox;
        private Guna.UI.WinForms.GunaButton btn_youtube;
        private Guna.UI.WinForms.GunaLabel lbl_Player_Cash;
        private Guna.UI.WinForms.GunaLabel lbl_Player_Gold;
        private Guna.UI.WinForms.GunaLabel lbl_playercash;
        private Guna.UI.WinForms.GunaLabel lbl_playergold;
        private Guna.UI.WinForms.GunaLabel lbl_account;
        private Guna.UI.WinForms.GunaLabel lbl_PlayerAccount;
    }
}