/*

 */
using PBLauncher.Localize;

namespace PBLauncher
{
    public static class Instancia
    {
        internal static IStrings _strings;
        internal static MainForm _main;
        internal static LoginForm _login;
    }
    public static class UserLogin
    {
        public static string _HWID;
        public static string _TOKEN_;
        public static string _LOGIN_;
        public static string _PASSWORD_;
    }
    class ReceiveLogin
    {
        public bool Status { get; set; }
        public string Player_token { get; set; }
       
    }
    class UserData
    {
        public int Player_id { get; set; }
        public string Player_name { get; set; }
        public string Player_account { get; set; }
        public string Clan_name { get; set; }
        public string Player_rank { get; set; }
        public string Player_rankName { get; set; }
        public string Player_exp { get; set; }
        public string Player_pccafe { get; set; }
        public string Player_gold { get; set; }
        public string Player_cash { get; set; }
    }
    class HwidData
    {
        public string Message { get; set; }
    }

    class ApiResponse
    {

        public string launcherversion { get; set; }
        public int status { get; set; }
        public string message { get; set; }
        public string webpage { get; set; }
        public string webrank { get; set; }
        public string files { get; set; }
        public string userlist { get; set; }
        public string updateurl { get; set; }
        public int clientversion { get; set; }
        public bool webbrowser { get; set; }
        public string key { get; set; }
        public string checkurl { get; set; }
        public string discord_link { get; set; }
        public string facebook_link { get; set; }
        public string site_link { get; set; }
        public string code { get; set; }
        public string paste { get; set; }
        public string repairurl { get; set; }
        public string color { get; set; }
        public string registeurl { get; set; }
        public string youtubeurl { get; set; }
    }
}
