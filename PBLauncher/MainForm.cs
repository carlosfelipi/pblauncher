using Ionic.Zip;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using PBLauncher.Properties;
using PBLauncher.Utils;
using PBLauncher.Utils.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PBLauncher
{
    public partial class MainForm : Form
    {

        private bool Updat, Verif;

        private BackgroundWorker PlayerInfo = new BackgroundWorker();
      
        public Point NewPoint;
        private int AVersion;
        private readonly WebClient GameUpdate = new WebClient();
        [Obfuscation(Feature = "virtualization", Exclude = false)]
        public WebClient Web = new WebClient();
        public Computer myComputer = new Computer();

        public int _Player_id;
        public string
        _Player_name,
        _Player_account,
        _Clan_name,
        _Player_rank,
        _Player_rankName,
        _Player_exp,
        _Player_pccafe,
        _Player_gold,
        _Player_cash;
       
        public MainForm()
        {
            InitializeComponent();

            WEB_Announce.DocumentCompleted += WEB_Announce_DocumentCompleted;
            WEB_Ranking.DocumentCompleted += WEB_Ranking_DocumentCompleted;


            // Buscar informação de Jogador em segundo plano
            PlayerInfo.DoWork += new DoWorkEventHandler(PlayerInfo_DoWork);
            PlayerInfo.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PlayerInfo_RunWorkerCompleted);


            PlayerInfo.RunWorkerAsync();

            CheckLanguage();
            LBLupdater();
            ColorButton();
            CheckUrl();

        }




        private void PlayerInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            ProgressBarMyInfoStart(true);
            LabelMyInfoStart(false);
            RequiresMyInfo(UserLogin._TOKEN_);
        }

        private void PlayerInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBarMyInfoStart(false);
            LabelMyInfoStart(true);
            ProfileView();
        }
   
        private void ProgressBarMyInfoStart(bool status)
        {

            MyInfoProgressBar.Visible = status;
            MyInfoProgressBar.Enabled = status;

        }

        private void LabelMyInfoStart(bool status)
        {
            lbl_uid.Visible = status;
            lbl_uid.Enabled = status;
            lbl_name.Visible = status;
            lbl_name.Enabled = status;
            lbl_account.Visible = status;
            lbl_account.Enabled = status;
            lbl_rank.Visible = status;
            lbl_rank.Enabled = status;
            lbl_exp.Visible = status;
            lbl_exp.Enabled = status;
            lbl_pccafe.Visible = status;
            lbl_pccafe.Enabled = status;
            lbl_playerclan.Visible = status;
            lbl_playerclan.Enabled = status;

            lbl_playergold.Visible = status;
            lbl_playergold.Enabled = status;

            lbl_playercash.Visible = status;
            lbl_playercash.Enabled = status;

            // Informções carregadas
            lbl_PlayerID.Visible = status;
            lbl_PlayerID.Enabled = status;

            lbl_PlayerName.Visible = status;
            lbl_PlayerName.Enabled = status;

            lbl_PlayerAccount.Visible = status;
            lbl_PlayerAccount.Enabled = status;

            lbl_Player_Clan.Visible = status;
            lbl_Player_Clan.Enabled = status;
            lbl_PlayerRank.Visible = status;
            lbl_PlayerRank.Enabled = status;
            lbl_PlayerExp.Visible = status;
            lbl_PlayerExp.Enabled = status;

            lbl_PlayerPCCafe.Visible = status;
            lbl_PlayerPCCafe.Enabled = status;

            lbl_Player_Gold.Visible = status;
            lbl_Player_Gold.Enabled = status;

            lbl_Player_Cash.Visible = status;
            lbl_Player_Cash.Enabled = status;

            PictureRank.Visible = status;
            PictureRank.Enabled = status;

        }
        private void ProfileView()
        {
            string _rank;
            if (_Player_rank == null)
            {
                _rank = "0";
            }
            else
            {
                _rank = _Player_rank;
            }

            lbl_PlayerID.Text = Convert.ToString(_Player_id);
            lbl_Player_Clan.Text = _Clan_name;
            lbl_PlayerName.Text = _Player_name;
            lbl_PlayerAccount.Text = "Level " + _Player_account;
            lbl_PlayerRank.Text = _Player_rankName;
            lbl_PlayerExp.Text = _Player_exp;
            ImgRank(_rank);
            lbl_PlayerPCCafe.Text = _Player_pccafe;
            lbl_Player_Gold.Text = _Player_gold;
            lbl_Player_Cash.Text = _Player_cash;




        }
     
      


        private void LBLupdater()
        {

            LTitulo.Text = Instancia._strings.LOADING;
            LTotalFixo.Text = Instancia._strings.TOTAL;
            LAquivoFixo.Text = Instancia._strings.FILE;
            lbl_my_info.Text = Instancia._strings.INFO_PLAYER;
           
            StartPBox.Text = Instancia._strings.BTN_START_TEXT;
            UpdatePBox.Text = Instancia._strings.BTN_UPDATE_TEXT;
            CheckPBox.Text = Instancia._strings.BTN_CHECK_TEXT;

        }


        private void MainForm_Load(object sender, EventArgs e)
        {



            if (Connect._webbrowser)
            {
                WEB_Announce.Navigate(Connect._webURL);
                WEB_Announce.Refresh();
                WEB_Ranking.Navigate(Connect._webRank);
                WEB_Ranking.Refresh();
            }
            else
            {
                WEB_Announce.Visible = false;
                WEB_Ranking.Visible = false;
            }
            Buttons_Enable(false, false, false);
            Buttons_Visible(true, true, false);
            CheckUpdate(1);
            CheckAnnounce();




            Logger.Log("[<<] Verificação do sistema concluída.");

        }

        private void CheckLanguage()
        {
            // Obtenha o idioma selecionado pelo usuário


            if (Properties.Settings.Default.Language == "EN")
            {
                language_btn.Image = Resources.us_;
            }
            else if (Properties.Settings.Default.Language == "BR")
            {
                language_btn.Image = Resources.br_;
            }
            else
            {
                language_btn.Image = Resources.us_;
            }

        }


        private async void CheckAnnounce()
        {
            if (Connect._state == HostStatus.ONLINEALERT && !string.IsNullOrEmpty(Connect._message))
            {
                await Task.Delay(40);
                MessageBox.Show(Connect._message.Replace("\\n", Environment.NewLine), Connect.Conn.GameName);
            }
        }

        #region Buttons

        #endregion

        #region Start Game
        private async void StartPBox_Click(object sender, EventArgs e)
        {
            if (File.Exists(string.Concat(Application.StartupPath, "\\PointBlank.exe")))
            {

                StartPBox.Enabled = false;
                LTitulo.Update();
                await Task.Delay(10);

                try
                {

                    Process PointBlank = new Process();
                    PointBlank.StartInfo.FileName = "PointBlank.exe";
                    PointBlank.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    PointBlank.StartInfo.Arguments = $"/GameID:{UserLogin._LOGIN_} /Token:{UserLogin._TOKEN_}"; ;
                    // PointBlank.StartInfo.Arguments = "GameID:" + Instancia._LOGIN_ + " Token:" + Instancia._TOKEN_;\\
                    PointBlank.Start();

                    Logger.Log("[!] O Jogo foi iniciado com sucesso!");

                }
                catch (Exception arg)
                {
                    Logger.Log("[!] Jogo não iniciado! [" + arg.Message + "]");
                     MessageBoxForm.Mostrar("Game not started!  \n[" + arg.Message + "]", "error");
                    Close();
                    return;
                }

                await Task.Delay(5);
                Close();


            }
            else
            {

                 MessageBoxForm.Mostrar(Instancia._strings.GAME_NOT_FOUND, "error");
                Logger.Log("[!!] Não foi possível localizar PointBlank.exe");
                Close();
            }
        }
        #endregion

        #region Check Client
        private async void CheckPBox_Click(object sender, EventArgs e)
        {
            Verif = true;

            LTitulo.Text = Instancia._strings.CHECKING_FILES;
            LTitulo.Refresh();
            Logger.Log("[>] Verificação dos arquivos do jogo iniciada.");
            Buttons_Enable(false, false, false);
            Buttons_Visible(true, true, false);
            LArquivo.Visible = true;
            //LDownload.Visible = true;

            try
            {
                //string folderPath = Application.StartupPath;
                string xmlFilePath = Application.StartupPath + "\\UserFileList.dat";

                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);

                XmlNodeList files = doc.SelectNodes("//file");
                int AllPack = files.Count;
                int CountBar = 1;
                foreach (XmlNode file in files)
                {
                    //string filePath = Path.Combine(Application.StartupPath, file.Attributes["local"].Value);
                    string hash = file.Attributes["hash"].Value;
                    string fileName = Path.GetFileName(file.Attributes["local"].Value);
                    byte[] localFileBytes = File.ReadAllBytes(Application.StartupPath + file.Attributes["local"].Value);
                    string localFileHash = PublicUtils.GetHash(localFileBytes);

                    if (!File.Exists(Application.StartupPath + file.Attributes["local"].Value))
                    {

                        try
                        {
                            // Baixa o arquivo se ele não estiver presente na pasta
                            Connect.Conn.WebClient.Headers["User-Agent"] = Connect.Conn.usrAgent;
                            string str1 = string.Concat(new string[] { string.Concat(Connect._repairurl + file.Attributes["local"].Value) });
                            string str2 = Application.StartupPath + file.Attributes["local"].Value;
                            Connect.Conn.WebClient.DownloadFile(str1, str2);
                            Logger.Log("[>>] Baixando " + file.Attributes["local"].Value);
                            await Task.Delay(1);

                        }
                        catch
                        {
                            Logger.Log("[X] Error ao baixar [CHECK]" + file.Attributes["local"].Value + "\n");
                        }


                    }
                    else if (localFileHash != hash)
                    {
                        try
                        {
                            // Baixa o arquivo se ele não estiver presente na pasta
                            Connect.Conn.WebClient.Headers["User-Agent"] = Connect.Conn.usrAgent;
                            string str1 = string.Concat(new string[] { string.Concat(Connect._repairurl + file.Attributes["local"].Value) });
                            string str2 = Application.StartupPath + file.Attributes["local"].Value;
                            Connect.Conn.WebClient.DownloadFile(str1, str2);
                            Logger.Log("[>>] Atualizando " + file.Attributes["local"].Value);
                            await Task.Delay(1);

                        }
                        catch (WebException p) { Logger.Log("[X] Error ao baixar [HASH]" + file.Attributes["local"].Value + "\n" + Connect._repairurl + file.Attributes["local"].Value + "\n" + p); }
                    }


                    Bar1SetProgress(CountBar, AllPack);
                    await Task.Delay(1);
                    LArquivo.Text = fileName;
                    CountBar++;
                }

            }
            catch
            {

                LTitulo.Text = Instancia._strings.CHECK_ERROR;
                LTitulo.Refresh();
                await Task.Delay(5000);

                Logger.Log("[X] Erro no check");

            }



            Verif = false;
            // LDownload.Visible = false;
            Logger.Log("[<] Verificação dos arquivos do jogo finalizada.");
            await Clear.Trash();

            Buttons_Enable(true, true, false);
            Buttons_Visible(true, true, false);
            Arquivo_Bar.Width = Arquivo_BarFixo.Width;
            Total_Bar.Width = Total_BarFixo.Width;
            LTitulo.Text = Instancia._strings.GAME_IS_UPDATE;
            LArquivo.Visible = false;
            // LDownload.Visible = false;
        }

        #endregion

        #region Update
        private async void CheckUpdate(short start)
        {
            long LVersion;
            if (start == 1)
                LVersion = Connect._version;
            else
                LVersion = await Connect.GetVersionUP();
            await Clear.Trash();
            if (LVersion == -1)
            {
                Logger.Log("[>!] Não tem atualização disponível. [RECEIVE_COUNT_NULL]");

                 MessageBoxForm.Mostrar(Instancia._strings.GET_UPDATE_ERROR, "error");
            }
            AVersion = LerVersion();
            Arquivo_Bar.Width = Arquivo_BarFixo.Width;
            Total_Bar.Width = Total_BarFixo.Width;
            LArquivo.Visible = false;

            Updat = false;
            if (LVersion > AVersion)
            {
                Logger.Log("Aguardando atualização da cliente.");
                Logger.Log("Versão: " + AVersion + "/" + LVersion);
                Arquivo_Bar.Width = 0;
                Total_Bar.Width = 0;
                LTitulo.Text = Instancia._strings.UPDATE_REC;
                Buttons_Enable(false, false, true);
                Buttons_Visible(false, true, true);

            }
            else if (LVersion == AVersion)
            {
                Logger.Log("A cliente está atualizada.");
                Logger.Log("Versão: " + AVersion + "/" + LVersion);
                LArquivo.Visible = false;
                LTitulo.Text = Instancia._strings.GAME_IS_UPDATE;
                Buttons_Enable(true, true, false);
                Buttons_Visible(true, true, false);

            }
            else
            {
                Logger.Log("Versão da Cliente maior que a versão do servidor.");
                Logger.Log("Versão: " + AVersion + "/" + LVersion);
                Logger.Log("Resetando atualizações...");
                await Task.Delay(50);
                 MessageBoxForm.Mostrar(Instancia._strings.LARGER_VERSION, "error");

                File.Delete(string.Concat(Application.StartupPath, "\\config.zpt"));
                await Task.Delay(50);
                EscreverVersion(0);
                CheckUpdate(0);
            }
        }

        private void UpdatePBox_Click(object sender, EventArgs e)
        {
            Buttons_Enable(false, false, false);
            Updat = true;

            GameUpdate.DownloadFileCompleted += GameUpdate_DownloadFileCompleted;
            GameUpdate.DownloadProgressChanged += GameUpdate_DownloadProgressChanged;
            LTitulo.Text = Instancia._strings.GET_UPDATE_INFO;
            StartUpdate();
        }

        private void GameUpdate_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Bar1SetProgress(e.BytesReceived, e.TotalBytesToReceive);
            // LDownload.Text = string.Format("{0}/{1} MB", (e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), (e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
        }

        private async void GameUpdate_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                // LDownload.Visible = false;
                LTitulo.Text = Instancia._strings.EXTRACT_FILE_UPDATE;
                LTitulo.Update();
                Total_Bar.Width = 0;
                string startupPath = Application.StartupPath;
                object[] actualVersion = new object[] { Application.StartupPath, "\\_DownloadPatchFiles\\patch_", AVersion + 1, ".zip" };
                await Unzip(startupPath, string.Concat(actualVersion));
                Total_Bar.Width = Total_BarFixo.Width;
                StartUpdate();
            }
        }

        private void StartUpdate()
        {
            AVersion = LerVersion();
            int LVersion = Connect._version;
            if (LVersion != AVersion)
            {
                int newV = AVersion + 1;
                Arquivo_Bar.Width = 0;
                LArquivo.Text = string.Concat("Atualização_", newV, ".zip");
                LArquivo.Visible = true;
                Logger.Log("Iniciando atualização da cliente.");
                Logger.Log("Baixando " + LArquivo.Text);
                Bar2SetProgress(newV, LVersion);
                Directory.CreateDirectory(string.Concat(Application.StartupPath, "\\_DownloadPatchFiles"));
                try
                {
                    Uri uri = new Uri(Connect._upURL + "patch_" + newV + ".zip");
                    object[] startupPath = new object[] { Application.StartupPath, "\\_DownloadPatchFiles\\patch_", newV, ".zip" };
                    //  LDownload.Visible = true;
                    GameUpdate.DownloadFileAsync(uri, string.Concat(startupPath));
                }
                catch (Exception arg)
                {
                    Logger.Log("O arquivo [" + newV + "] não foi encontrado no servidor. \n[" + arg.Message + "]");

                     MessageBoxForm.Mostrar(Instancia._strings.DOWNLOAD_FILE_ERROR, "error");
                    Close();
                }
            }
            else
                CheckUpdate(0);
        }

        private int LerVersion()
        {
            IniFile fileini = new IniFile(Application.StartupPath + "\\config.zpt");
            return fileini.IniReadInt("UPDATE", "version");
        }

        private void EscreverVersion(int version)
        {
            IniFile fileini = new IniFile(Application.StartupPath + "\\config.zpt");
            fileini.IniWriteInt("UPDATE", "version", version);
        }

        #endregion



        #region Movimentação e saida do Form



        private void Launcher_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int left = Left;
                Point mousePosition = MousePosition;
                NewPoint.X = left - mousePosition.X;
                int top = Top;
                Point point = MousePosition;
                NewPoint.Y = top - point.Y;
            }
        }

        private void Launcher_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int x = NewPoint.X;
                Point mousePosition = MousePosition;
                Left = x + mousePosition.X;
                int y = NewPoint.Y;
                mousePosition = MousePosition;
                Top = y + mousePosition.Y;
            }
        }


        private void LauncherHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int left = Left;
                Point mousePosition = MousePosition;
                NewPoint.X = left - mousePosition.X;
                int top = Top;
                Point point = MousePosition;
                NewPoint.Y = top - point.Y;
            }
        }

        private void LauncherHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                int x = NewPoint.X;
                Point mousePosition = MousePosition;
                Left = x + mousePosition.X;
                int y = NewPoint.Y;
                mousePosition = MousePosition;
                Top = y + mousePosition.Y;
            }
        }

        private void Launcher_FormClosed(object sender, FormClosedEventArgs e) => Logger.Log("[><] PBLauncher foi finalizado.");


        #endregion

        #region Códigos base
        public async Task Unzip(string TargetDir, string ZipToUnpack)
        {
            try
            {
                int x = 0;
                ZipFile zipFile = ZipFile.Read(ZipToUnpack);
                try
                {
                    zipFile.ExtractProgress += new EventHandler<ExtractProgressEventArgs>(Unzip_ExtractProgressChanged);
                    LArquivo.Visible = true;
                    foreach (ZipEntry zipEntry in zipFile)
                    {
                        Arquivo_Bar.Width = 0;
                        Bar2SetProgress(x++, zipFile.Count);

                        //Pausa necessaria para atualizar os elementos visuais.
                        await Task.Delay(1);

                        string fileName = zipEntry.FileName;
                        if (fileName.Contains("/"))
                        {
                            int num2 = fileName.LastIndexOf("/");
                            fileName = fileName.Substring(num2 + 1);
                        }
                        if (!zipEntry.IsDirectory)
                        {
                            LArquivo.Text = fileName;
                            zipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                        }
                    }
                }
                finally
                {
                    Arquivo_Bar.Width = Arquivo_BarFixo.Width;
                    if (zipFile != null)
                        zipFile.Dispose();
                }
            }
            catch (Exception)
            {
            }
        }

        private void Unzip_ExtractProgressChanged(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer != 0)
            {
                Bar1SetProgress(e.BytesTransferred, e.TotalBytesToTransfer);
                Arquivo_Bar.Update();
            }

        }

        public void Bar1SetProgress(long received, long maximum) => Arquivo_Bar.Width = (int)(received * Arquivo_BarFixo.Width / maximum);

        public void Bar2SetProgress(int received, int maximum) => Total_Bar.Width = received * Total_BarFixo.Width / maximum;

        private void Buttons_Enable(bool Start, bool Check, bool Update)
        {
            StartPBox.Enabled = Start;
            CheckPBox.Enabled = Check;
            UpdatePBox.Enabled = Update;
        }

        private void WEB_Announce_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath == WEB_Announce.Url.AbsolutePath)
            {
                if (Connect._webURL == "0")
                {
                    WEB_Announce.Visible = false;

                }
                else
                {
                    WEB_Announce.Visible = true;

                }
                // Exiba o controle WebBrowser
               
            }

        }
        private void WEB_Ranking_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath == WEB_Ranking.Url.AbsolutePath)
            {
                if (Connect._webRank == "0")
                {
                    WEB_Ranking.Visible = false;

                }
                else
                {
                    // Exiba o controle WebBrowser
                    WEB_Ranking.Visible = true;
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Arquivo_Bar_Click(object sender, EventArgs e)
        {

        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buttons_Visible(bool Start, bool Check, bool Update)
        {
            StartPBox.Visible = Start;
            CheckPBox.Visible = Check;
            UpdatePBox.Visible = Update;
        }

        #endregion
        private void ImgRank(string cp)
        {

            Dictionary<string, Image> Rank = new Dictionary<string, Image>();
            for (int i = 0; i <= 54; i++)
            {
                string key = i.ToString();
                Image rankImage = (Image)Properties.Resources.ResourceManager.GetObject("rank_" + key);
                Rank.Add(key, rankImage);
            }

            Image img = Rank[cp];
            PictureRank.Image = img;
        }
        private async void RequiresMyInfo(string token)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Launcher-Header", Connect._Header);
                // Crie um objeto FormUrlEncodedContent com os parâmetros desejados

                var parameters = new List<KeyValuePair<string, string>>
                {
                new KeyValuePair<string, string>("_token", WebUtility.UrlEncode(token) ),
                 // adicione mais parâmetros, se necessário
                };

                HttpContent content = new FormUrlEncodedContent(parameters);
                HttpResponseMessage response = await client.PostAsync(Connect._HostURL + "/connection/inc.profile.php", content);


                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    UserData apiResponse = JsonConvert.DeserializeObject<UserData>(responseBody);
                    // Atribuir os valores da resposta às variáveis
                    _Player_id = apiResponse.Player_id;
                    _Player_name = apiResponse.Player_name;
                    _Player_account = apiResponse.Player_account;
                    _Clan_name = apiResponse.Clan_name;
                    _Player_rank = apiResponse.Player_rank;
                    _Player_rankName = apiResponse.Player_rankName;
                    _Player_exp = apiResponse.Player_exp;
                    _Player_pccafe = apiResponse.Player_pccafe;
                    _Player_gold = apiResponse.Player_gold;
                    _Player_cash = apiResponse.Player_cash;

                }
                else
                {
                     MessageBoxForm.Mostrar("[My Information] Unable to verify information", "warning");
                }
            }
            catch
            {
                
                 MessageBoxForm.Mostrar("[My Information] Unable to verify information", "warning");
            }

        }



        private void language_btn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Language == "EN")
            {
                Properties.Settings.Default.Language = "BR";

                MessageBox.Show(Instancia._strings.FORM_LANGUAGE + " Português", ProductName);
                Application.Restart();
            }
            else if (Properties.Settings.Default.Language == "BR")
            {
                Properties.Settings.Default.Language = "EN";

                MessageBox.Show(Instancia._strings.FORM_LANGUAGE + " English", ProductName);
                Application.Restart();
            }
            else
            {
                Properties.Settings.Default.Language = "EN";
                MessageBox.Show(Instancia._strings.FORM_LANGUAGE + " English");
                Application.Restart();
            }
            Properties.Settings.Default.Save();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Instancia._strings.EXIT_ASK, ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btn_minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_youtube_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Connect._youtube_link;
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                MessageBoxForm.Mostrar("[YOUTUBE] Error opening link", "warning");
            }
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            if (!Updat)
            {
                try
                {
                    Process.Start("PBConfig.exe");
                }
                catch
                {
                    MessageBox.Show(Instancia._strings.CONFIG_ERROR, Connect.Conn.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_discord_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Connect._discord_link;
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                 MessageBoxForm.Mostrar("[DISCORD] Error opening link", "warning");
            }
        }



        private void btn_facebook_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Connect._facebook_link;
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                 MessageBoxForm.Mostrar("[FACEBOOK] Error opening link", "warning");
            }
        }


        private void btn_site_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Connect._site_link;
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                 MessageBoxForm.Mostrar("[WEB] Error opening link", "warning");
            }
        }


        public void ColorButton()
        {
            
            Color color = ColorTranslator.FromHtml(Connect._color);
            StartPBox.BaseColor = color;
            CheckPBox.BaseColor = color;
            UpdatePBox.BaseColor = color;
            btn_close.BaseColor = color;
            btn_minimized.BaseColor = color;
            btn_config.BaseColor = color;
            btn_discord.BaseColor = color;
            btn_facebook.BaseColor = color;
            btn_site.BaseColor = color;
            btn_youtube.BaseColor = color;
            Arquivo_Bar.BackColor = color;
            Total_Bar.BackColor = color;
            MyInfoProgressBar.ProgressColor = color;
            Separator0.LineColor = color;
            Separator1.LineColor = color;
        }

        public void CheckUrl()
        {
            if(Connect._facebook_link == "0")
            {
                btn_facebook.Visible = false;
                btn_facebook.Enabled = false;
            }
            if (Connect._discord_link == "0")
            {
                btn_discord.Visible = false;
                btn_discord.Enabled = false;
            }
            if (Connect._site_link == "0")
            {
                btn_site.Visible = false;
                btn_site.Enabled = false;
            }
            if (Connect._youtube_link == "0")
            {
                btn_youtube.Visible = false;
                btn_youtube.Enabled = false;
            }




        }

    }
}
