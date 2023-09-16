using PBLauncher.Localize;
using System;
using System.IO;
using System.Windows.Forms;


namespace PBLauncher
{
    static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]


        static void Main()
        {

            /// PublicUtils.ExecutarCMD("ipconfig/flushdns");

            /// PublicUtils.ExecutarCMD("DEL /q %WINDIR%\\Prefetch\\*.*");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CheckFiles();

            if (Properties.Settings.Default.Language == "EN")
            {
                Instancia._strings = new LanguageEN();
            }
            else if (Properties.Settings.Default.Language == "BR")
            {
                Instancia._strings = new LanguagePTBR();
            }
            else
            {
                Instancia._strings = new LanguageEN();
            }


            Application.Run(new PleaseWait());

        }
        static void CheckFiles()
        {

            string LauncherCore = Application.StartupPath  + "/launcher_core.dll";
            string NewtonsoftJson = Application.StartupPath +  "/Newtonsoft.Json.dll";
            string GunaUI = Application.StartupPath + "/Guna.UI.dll";

         
                if (!File.Exists(LauncherCore))
                {
                    string mensagemErro = $"O arquivo de referência '{LauncherCore}' está faltando.";
                    throw new FileNotFoundException(mensagemErro);
                }
        
           
                if (!File.Exists(NewtonsoftJson))
                {
                    string mensagemErro = $"O arquivo de referência '{NewtonsoftJson}' está faltando.";
                    throw new FileNotFoundException(mensagemErro);
                }
         
           
                if (!File.Exists(GunaUI))
                {
                    string mensagemErro = $"O arquivo de referência '{GunaUI}' está faltando.";
                    throw new FileNotFoundException(mensagemErro);
                }
           


        }
        // Exceção personalizada para arquivo de referência faltando
        class FileNotFoundException : Exception
        {
            public FileNotFoundException(string mensagem) : base(mensagem)
            {
                MessageBox.Show(mensagem);
            }
        }
    }
}
