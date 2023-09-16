/*
 * Arquivo: LanguageEN.cs
 * Criado em: 1-4-2021
 * https://github.com/ForceFK
 * ForceFK - Force&Kuraiyo Dev
 * Última modificação: 1-4-2021
 */
namespace PBLauncher.Localize
{
    public class LanguageEN : IStrings
    {
        public string LOADING { get; set; } = "Loading...";
        public string EXIT_ASK { get; set; } = "Do you really want to leave?";
        public string CHECK_IMPORTANT_FILES { get; set; } = "Checking important files...";
        public string GAME_RUNNING { get; set; } = "There is already a game window open.";
        public string LAUNCHER_RUNNING { get; set; } = "There is already a Launcher window open.";
        public string CONNECTING_TO_SERVER { get; set; } = "Connecting to the server...";
        public string SERVER_CONNECTION_UNKNOWN { get; set; } = "Unable to connect to server.\nLauncher will be terminated.";
        public string CHECK_LAUNCHER_UPDATE { get; set; } = "Checking for Updates...";
        public string LAUNCHER_UPDATE_ERROR { get; set; } = "An error occurred while downloading launcher update!";
        public string SERVER_UNKNOWN_PACKAGE { get; set; } = "Something wrong happened...\nContact support:\nwww.projectelite.net/suporte";
        public string AUTH_LOGIN { get; set; } = "Logging in, please wait...";
        public string AUTH_ACC_NO_STAFF { get; set; } = "Login available to staff members only.";
        public string AUTH_ACC_BANNED { get; set; } = "Your launcher is permanently banned.";
        public string AUTH_ACC_CREAT_ERROR { get; set; } = "We were unable to create your user on the server,\nyou are creating accounts too fast!";
        public string AUTH_ACC_NULL { get; set; } = "Unable to find your username on server.\nContact support for more information!\nwww.projectelite.net/suporte";
        public string CHECK_SERVER_STATUS { get; set; } = "Checking server status...";
        public string SERVER_MAINTENANCE { get; set; } = "The game is currently under maintenance.\nTry again later!";
        public string DOWNLOAD_USERLIST { get; set; } = "Downloading UserFileList: ";
        public string DOWNLOAD_LAUNCHER_UPDATE { get; set; } = "Downloading update: ";
        public string DOWNLOAD_USERLIST_ERROR { get; set; } = "An error occurred while downloading the UserFileList.";
        public string DELET_TRASH { get; set; } = "Deleting Useless Files...";
        public string EXTRACT_FILE_UPDATE { get; set; } = "Extracting and installing the update...";
        public string EXTRACT_FILE { get; set; } = "Extracting files...";
        public string FILE_CHECK_GET { get; set; } = "Updating ELITE SHIELD, please wait...";
        public string ACCESS_DENIED { get; set; } = "Access denied";
        public string BAN_TIME_LEFT { get; set; } = "Time left: {0}Days {1}Hours {2}Minutes {3}Seconds";
        public string GAME_NOT_AVAILABLE { get; set; } = "The game is not available at the moment.";
        public string UPDATE_REC { get; set; } = "Update your game version.";
        public string GAME_IS_UPDATE { get; set; } = "Your game is up to date. You can play now.";
        public string FILE { get; set; } = "File";
        public string TOTAL { get; set; } = "Total";
        public string CHECK_REC { get; set; } = "Invalid files detected. Verify Customer Integrity!";
        public string LARGER_VERSION { get; set; } = "Client version larger than server version.\nPerform updates again!";
        public string DOWNLOAD_FILE { get; set; } = "Downloading the files...";
        public string DOWNLOAD_FILE_ERROR { get; set; } = "An error occurred while downloading the file [{0}].\nTry again later!";
        public string CHECKING_FILES { get; set; } = "Checking the game files...";
        public string CHECK_ERROR { get; set; } = "An error occurred while trying to verify client files!";
        public string CONFIG_ERROR { get; set; } = "Could not find\nthe game configuration file.";
        public string CONNECTION_LOST { get; set; } = "Server connection broken.";
        public string LOADING_PRE_START { get; set; } = "Loading ELITE SHIELD...";
        public string GAME_NOT_FOUND { get; set; } = "Unable to find PointBlank.exe";
        public string START_ERROR { get; set; } = "Could not start the game.\nThe server has not validated your passkey.";
        public string USERLIST_ERROR { get; set; } = "An error occurred with the UserFileList.dat file.";
        public string GET_UPDATE_INFO { get; set; } = "Getting update information...";
        public string GET_UPDATE_ERROR { get; set; } = "It was not possible to get an update list from the server.";
        public string TOP_INFO { get; set; } = "Launcher: {0}\nPoints: {1}";
        public string CORE_NOTFOUND { get; set; } = "Launcher_core.dll not found.";

        public string DISCORDMSG_NOTFOUND { get; set; } = "DiscordMessenger.dll not found.";
        public string DISCORDRPC_NOTFOUND { get; set; } = "discord-rpc-w32.dll not found.";

        public string AUTH_SUCCESS_LOGIN { get; set; } = "Login successful!";
        public string AUTH_NULL_LOGIN { get; set; } = "Enter your login!";
        public string AUTH_NULL_PASSWORD { get; set; } = "Type your password!";
        public string AUTH_NULL_HWID { get; set; } = "Hwid not detected!";
        public string AUTH_MIN_LOGIN { get; set; } = "Login too short!";
        public string AUTH_MAX_LOGIN { get; set; } = "Login too long!";
        public string AUTH_MIN_PASSWORD { get; set; } = "Password too short!";
        public string AUTH_MAX_PASSWORD { get; set; } = "Password too long!";
        public string AUTH_BANNED { get; set; } = "Your account is banned!";
        public string AUTH_BLOCKED { get; set; } = "Sua conta está bloqueada!";
        public string AUTH_PENDING { get; set; } = "Unconfirmed account!";
        public string AUTH_INCORRET { get; set; } = "Incorrect username and password!";

        //Message default
        public string INFO_PLAYER { get; set; } = "My Information";
        public string INFO_SERVER { get; set; } = "Server Information";

        public string FORM_LANGUAGE { get; set; } = "PBLauncher will restart to apply the language";

        // Button - 
        public string BTN_LOGIN_TEXT { get; set; } = "LOGIN";
        public string BTN_REGISTER_TEXT { get; set; } = "REGISTER";
        public string CHECKED_SAVE_TEXT { get; set; } = "Remember login";

        // Button - 
        public string BTN_START_TEXT { get; set; } = "START";
        public string BTN_UPDATE_TEXT { get; set; } = "UPDATE";
        public string BTN_CHECK_TEXT { get; set; } = "CHECK";
    }
}
