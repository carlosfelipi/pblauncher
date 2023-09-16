using Newtonsoft.Json;
using PBLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher
{
    public partial class LoginForm : Form
    {
        public Point NewPoint;
        public LoginForm()
        {
            InitializeComponent();
            lblButton();
            ColorButton();
            CheckUrl();
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
            Logger.Log("[>>] PBLauncher - Login");
            txtUsername.KeyDown += TxtUsername_KeyDown;
            txtPassword.KeyDown += TxtPassword_KeyDown;
            if (Properties.Settings.Default.RememberMe)
            {
                checkboxID.Checked = true;
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
        }
        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReadyLogin(txtUsername.Text.ToLower(), txtPassword.Text, UserLogin._HWID);
                e.SuppressKeyPress = true; // Suprimir o som padrão do sistema ao pressionar Enter
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReadyLogin(txtUsername.Text.ToLower(), txtPassword.Text, UserLogin._HWID);
                e.SuppressKeyPress = true; // Suprimir o som padrão do sistema ao pressionar Enter
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
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

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
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


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e) => Logger.Log("[><] PBLauncher foi finalizado.");



        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }



        private async void ReadyLogin(string username, string password, string hwid)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {

                    lblmessage(Instancia._strings.AUTH_NULL_LOGIN, "Orange");

                }
                else if (string.IsNullOrEmpty(password))
                {

                    lblmessage(Instancia._strings.AUTH_NULL_PASSWORD, "Orange");
                }
                else if (string.IsNullOrEmpty(hwid))
                {
                    lblmessage(Instancia._strings.AUTH_NULL_HWID, "Orange");
                }
                else
                {

                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Launcher-Header", Connect._Header);
                    // Crie um objeto FormUrlEncodedContent com os parâmetros desejados

                    var parameters = new List<KeyValuePair<string, string>>
                {
                new KeyValuePair<string, string>("_username", WebUtility.UrlEncode(username) ),
                new KeyValuePair<string, string>("_password", WebUtility.UrlEncode(password) ),
                new KeyValuePair<string, string>("_hwid", WebUtility.UrlEncode(hwid) ),
                 // adicione mais parâmetros, se necessário
                };

                    HttpContent content = new FormUrlEncodedContent(parameters);
                    HttpResponseMessage response = await client.PostAsync(Connect._HostURL + "/connection/inc.login.php", content);


                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        ReceiveLogin apiResponse = JsonConvert.DeserializeObject<ReceiveLogin>(responseBody);
                        // Atribuir os valores da resposta às variáveis


                        if (apiResponse.Status == true)
                        {
                            statusLoadind(true);
                            statusLabelBtn(false, false);

                            await Task.Delay(500);

                            UserLogin._TOKEN_ = apiResponse.Player_token;
                            UserLogin._LOGIN_ = username;
                            UserLogin._PASSWORD_ = password;

                            await Task.Delay(500);
                            // Salva o nome de usuário na configuração do usuário
                            Properties.Settings.Default.Username = txtUsername.Text;
                            Properties.Settings.Default.Password = txtPassword.Text;

                            // Verifica se a opção "Lembrar de mim" está marcada
                            if (checkboxID.Checked)
                            {
                                Properties.Settings.Default.RememberMe = true;
                            }
                            else
                            {
                                Properties.Settings.Default.RememberMe = false;
                            }
                            Properties.Settings.Default.Save();
                            statusLoadind(false);

                            OpenMain();
                        }
                        else
                        {
                            statusLoadind(false);
                            statusLabelBtn(true, false);
                            lblmessage(Instancia._strings.AUTH_INCORRET, "Orange");
                        }
                    }
                    else
                    {
                        statusLoadind(false);
                        statusLabelBtn(true, false);

                        lblmessage(Instancia._strings.AUTH_INCORRET, "Orange");
                    }

                }
            }
            catch
            {
                MessageBoxForm.Mostrar("Error connect ", "Red");
                Close();
            }
        }
        private void statusLabelBtn(bool sts, bool register)
        {
            txtPassword.Enabled = sts;
            txtUsername.Enabled = sts;
            checkboxID.Enabled = sts;
            btn_login.Enabled = sts;
            btn_register.Enabled = register;
            btn_close.Enabled = sts;
            label1.Enabled = sts;
            label2.Enabled = sts;
            lbl_checked_id.Enabled = sts;
            btn_minimized.Enabled = sts;

            txtPassword.Visible = sts;
            txtUsername.Visible = sts;
            checkboxID.Visible = sts;
            btn_login.Visible = sts;
            btn_register.Visible = register;
            btn_close.Visible = sts;
            btn_minimized.Visible = sts;
            label1.Visible = sts;
            label2.Visible = sts;
            lbl_checked_id.Visible = sts;
            status_barra.Visible = sts;
        }

        private void statusLoadind(bool sts)
        {
            pLoading.Enabled = sts;
            pLoading.Visible = sts;
        }
        private void lblmessage(string txt, string color)
        {
            status_barra.Visible = true;
            lbl_message_barra.Text = txt;
            lbl_message_barra.ForeColor = Color.FromName(color);
        }
        private void OpenMain()
        {
            Instancia._main = new MainForm()
            {
                //BackgroundImage = Core.Properties.Resources.bg
            };
            Instancia._main.Closed += (s, args) => Close();
            Hide();
            Instancia._main.Show();

        }
        private void lblButton()
        {
            btn_login.Text = Instancia._strings.BTN_LOGIN_TEXT;
            btn_register.Text = Instancia._strings.BTN_REGISTER_TEXT;
            lbl_checked_id.Text = Instancia._strings.CHECKED_SAVE_TEXT;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ReadyLogin(txtUsername.Text.ToLower(), txtPassword.Text, UserLogin._HWID);
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                string url = Connect._registeurl;
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                MessageBoxForm.Mostrar("[REGISTER] Error opening link", "warning");
            }
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
        public void ColorButton()
        {

            Color color = ColorTranslator.FromHtml(Connect._color);
            btn_login.BaseColor = color;
            btn_register.BaseColor = color;
            checkboxID.CheckedOnColor = color;
            btn_close.BaseColor = color;
            btn_minimized.BaseColor = color;
            pLoading.ProgressColor = color;
            
        }
        public void CheckUrl()
        {

            if(Connect._registeurl == "0")
            {
                btn_register.Visible = false;
                btn_register.Enabled = false;

            }

        }
    }
}
