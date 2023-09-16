using Newtonsoft.Json;
using PBLauncher.Utils.Enum;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PBLauncher
{
    public static class Connect
    {
        public static readonly string _HostURL = "http://development-area.sd/LauncherCombat/";
        public static readonly string _Header = "4B2AF156899AD3E0C90D90A785BA09CB80E78E085905A40AD6937647";

        internal class Conn
        {
            //public static WebClient Web = new WebClient();
            public static WebClient WebClient = new WebClient()
            {
                Encoding = Encoding.UTF8
            };

            public static string usrAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";

            public static string GameName = "Point Blank";

        }


        /// <summary>
        /// URL of the configuration file hosted on the site
        /// URL do arquivo configuração hospedado no site
        /// Recomendado: Arquivo de configuração estar com o encode em UTF-8
        /// </summary>
        /// 



        #region Modelo e processamento
        public static HostStatus _state = HostStatus.UNK;
        public static string _launcherVer, _message, _youtube_link, _webURL, _registeurl, _webRank, _upURL, _userList, _fileURL, _discord_link, _facebook_link, _site_link, _code, _paste, _repairurl, _color;
        public static int _version;
        public static bool _webbrowser;
        public static long _launcherKey;

        /// <summary>
        /// Leitura e processamento dos dados
        /// </summary>
        /// <returns></returns>

        public static async Task<HostStatus> GetHostInfo()
        { // inc.connect.php
            await Task.Delay(5);
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Launcher-Header", _Header);
                HttpResponseMessage response = await client.GetAsync(_HostURL + "/connection/inc.connect.php");


                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                    // Atribuir os valores da resposta às variáveis
                    _launcherVer = apiResponse.launcherversion;
                    _state = (HostStatus)Convert.ToInt32(apiResponse.status);
                    _message = apiResponse.message;
                    _webURL = apiResponse.webpage;
                    _fileURL = apiResponse.files;
                    _userList = apiResponse.userlist;
                    _upURL = apiResponse.updateurl;
                    _version = Convert.ToInt32(apiResponse.clientversion);
                    _webbrowser = Convert.ToBoolean(apiResponse.webbrowser);
                    _launcherKey = Convert.ToInt64(apiResponse.key);
                    _webRank = apiResponse.webrank;
                    _discord_link = apiResponse.discord_link;
                    _facebook_link = apiResponse.facebook_link;
                    _site_link = apiResponse.site_link;
                    _code = apiResponse.code;
                    _paste = apiResponse.paste;
                    _repairurl = apiResponse.repairurl;
                    _color = apiResponse.color;
                    _registeurl = apiResponse.registeurl;
                    _youtube_link = apiResponse.youtubeurl;

                }
            }
            catch
            {
                _state = HostStatus.UNK;
            }

            return _state;
        }

        public static async Task<long> GetVersionUP()
        {
            await Task.Delay(5);
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("X-Launcher-Header", _Header);
                HttpResponseMessage response = await client.GetAsync(_HostURL + "/connection/inc.connect.php");


                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                    // Atribuir os valores da resposta às variáveis

                    _version = apiResponse.clientversion;

                }

            }
            catch
            {
                _version = -1;
            }
            return _version;
        }
        #endregion



    }
}
