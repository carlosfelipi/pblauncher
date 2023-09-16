/*
 * Arquivo: IStrings.cs
 * Criado em: 1-4-2021
 * https://github.com/ForceFK
 * ForceFK - Force&Kuraiyo Dev
 * Última modificação: 1-4-2021
 */
namespace PBLauncher.Localize
{
    public interface IStrings
    {
        string GET_UPDATE_ERROR { get; set; }
        string GET_UPDATE_INFO { get; set; }
        string USERLIST_ERROR { get; set; }
        string START_ERROR { get; set; }
        string GAME_NOT_FOUND { get; set; }
        string LOADING_PRE_START { get; set; }
        string CONNECTION_LOST { get; set; }
        string CONFIG_ERROR { get; set; }
        string CHECK_ERROR { get; set; }
        string CHECKING_FILES { get; set; }
        string DOWNLOAD_FILE_ERROR { get; set; }
        string DOWNLOAD_FILE { get; set; }
        string LARGER_VERSION { get; set; }
        string CHECK_REC { get; set; }
        string TOTAL { get; set; }
        string FILE { get; set; }
        string GAME_IS_UPDATE { get; set; }
        string UPDATE_REC { get; set; }
        string GAME_NOT_AVAILABLE { get; set; }
        string BAN_TIME_LEFT { get; set; }
        string ACCESS_DENIED { get; set; }
        string FILE_CHECK_GET { get; set; }
        string EXIT_ASK { get; set; }
        string EXTRACT_FILE { get; set; }
        string EXTRACT_FILE_UPDATE { get; set; }
        string DOWNLOAD_LAUNCHER_UPDATE { get; set; }
        string DELET_TRASH { get; set; }
        string DOWNLOAD_USERLIST_ERROR { get; set; }
        string DOWNLOAD_USERLIST { get; set; }
        string SERVER_MAINTENANCE { get; set; }
        string CHECK_SERVER_STATUS { get; set; }
        string AUTH_ACC_NULL { get; set; }
        string AUTH_ACC_CREAT_ERROR { get; set; }
        string AUTH_ACC_BANNED { get; set; }
        string AUTH_ACC_NO_STAFF { get; set; }
        string AUTH_LOGIN { get; set; }
        string LOADING { get; set; }
        string CHECK_IMPORTANT_FILES { get; set; }
        string GAME_RUNNING { get; set; }
        string LAUNCHER_RUNNING { get; set; }
        string CONNECTING_TO_SERVER { get; set; }
        string CHECK_LAUNCHER_UPDATE { get; set; }
        string SERVER_CONNECTION_UNKNOWN { get; set; }
        string LAUNCHER_UPDATE_ERROR { get; set; }
        string SERVER_UNKNOWN_PACKAGE { get; set; }
        string TOP_INFO { get; set; }
        string CORE_NOTFOUND { get; set; }
        string DISCORDMSG_NOTFOUND { get; set; }
        string DISCORDRPC_NOTFOUND { get; set; }

        string AUTH_SUCCESS_LOGIN { get; set; }
        string AUTH_NULL_LOGIN { get; set; }
        string AUTH_NULL_PASSWORD { get; set; }
        string AUTH_NULL_HWID { get; set; }
        string AUTH_MIN_LOGIN { get; set; }
        string AUTH_MAX_LOGIN { get; set; }
        string AUTH_MIN_PASSWORD { get; set; }
        string AUTH_MAX_PASSWORD { get; set; }
        string AUTH_BANNED { get; set; }
        string AUTH_BLOCKED { get; set; }
        string AUTH_PENDING { get; set; }
        string AUTH_INCORRET { get; set; }

        string INFO_PLAYER { get; set; }
        string INFO_SERVER { get; set; }

        string FORM_LANGUAGE { get; set; }

        string BTN_LOGIN_TEXT { get; set; }
        string BTN_REGISTER_TEXT { get; set; }
        string CHECKED_SAVE_TEXT { get; set; }
        string BTN_START_TEXT { get; set; }
        string BTN_UPDATE_TEXT { get; set; }
        string BTN_CHECK_TEXT { get; set; }
    }
}
