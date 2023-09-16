using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBLauncher
{

    public partial class MessageBoxForm : Form
    {
        public Point NewPoint;
        public MessageBoxForm()
        {
            InitializeComponent();
            ColorButton();
        }

        public DialogResult Resultado { get; private set; }

        public static string Type(string p)
        {
            string m = "Black";
            if (p == "success")
            {
                m = "Green";
            }
            else if (p == "warning")
            {
                m = "Orange";
            }
            else if (p == "error")
            {
                m = "Red";
            }
            return m;

        }
        public static DialogResult Mostrar(string mensagem, string type)
        {

            var msgBox = new MessageBoxForm();
            msgBox.lblText.Text = mensagem.Replace("\\n", Environment.NewLine);

            msgBox.lblText.ForeColor = Color.FromName(Type(type));

            msgBox.ShowDialog();
            return msgBox.Resultado;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Resultado = DialogResult.Yes;
            Close();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupForm_MouseDown(object sender, MouseEventArgs e)
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

        private void groupForm_MouseMove(object sender, MouseEventArgs e)
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

        public void ColorButton()
        {

            Color color = ColorTranslator.FromHtml(Connect._color);
            Grup1.LineColor = color;
            btnOK.BaseColor = color;

        }
    }

}
