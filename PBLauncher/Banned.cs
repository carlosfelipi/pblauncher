using Microsoft.Win32;
using Newtonsoft.Json;
using PBLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace PBLauncher
{
    public class Banned
    {
        public static string _Message;
        public static bool _Banned = false;
        public static void HWID()
        {

            RegistryKey chave = Registry.CurrentUser.OpenSubKey("Software\\" + Connect._paste, true);
            if (chave == null || chave.GetValue("Hwid") == null)
            {
                string NewKey = Guid.NewGuid().ToString();
                RegistryKey GerarKey = Registry.CurrentUser.CreateSubKey("Software\\" + Connect._paste);
                GerarKey.SetValue("Hwid", NewKey);

                CheckBanned(NewKey);
                UserLogin._HWID = NewKey;
            }
            else
            {
                string Key = chave.GetValue("Hwid").ToString();
                CheckBanned(Key);
                UserLogin._HWID = Key;

            }

        }

        private static async void CheckBanned(string token)
        {

            try
            {
                if (string.IsNullOrEmpty(token))
                {

                     MessageBoxForm.Mostrar("Error null [Hw] ", "error");
                    Logger.Log("[>>] ID não vazio");
                    Environment.Exit(0);

                }
                else
                {


                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Add("X-Launcher-Header", Connect._Header);

                    // Crie um objeto FormUrlEncodedContent com os parâmetros desejados
                    var parameters = new List<KeyValuePair<string, string>>
                    {
                        new KeyValuePair<string, string>("_hwid", token),
                       
                        // adicione mais parâmetros, se necessário
                    };
                    HttpContent content = new FormUrlEncodedContent(parameters);

                    HttpResponseMessage response = await client.PostAsync(Connect._HostURL + "/connection/inc.hwid.php", content);


                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        HwidData apiResponse = JsonConvert.DeserializeObject<HwidData>(responseBody);

                        // Atribuir os valores da resposta às variáveis

                        _Message = Convert.ToString(apiResponse.Message);
                        if (_Message == "banned")
                        {

                             MessageBoxForm.Mostrar(Instancia._strings.AUTH_ACC_BANNED, "warning");
                            Logger.Log("[!]" + Instancia._strings.AUTH_ACC_BANNED);
                            Environment.Exit(1);

                        }
                        else if (_Message == "released")
                        {
                            _Banned = true;
                        }
                        else if (_Message == "adding")
                        {
                            _Banned = true;
                        }
                        else
                        {

                             MessageBoxForm.Mostrar("[Server Information] Unable to verify information", "warning");
                            Environment.Exit(1);
                        }

                    }
                    else
                    {

                         MessageBoxForm.Mostrar("[Server Information] Unable to verify information", "warning");
                        Environment.Exit(1);
                    }


                }

            }
            catch
            {

                 MessageBoxForm.Mostrar("[Server Information] Unable to verify information", "warning");
                Environment.Exit(1);

            }


        }


    }
}
