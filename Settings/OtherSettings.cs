using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Miscellaneous settings.
    /// </summary>
    public class OtherSettings
    {
        [JsonPropertyName("show_notifications")]
        public bool ShowNotifications { get; set; } = true;

        [JsonPropertyName("open_folder_after_download")]
        public bool OpenFolderAfterDownload { get; set; } = false;

        [JsonPropertyName("save_logs_to_file")]
        public bool SaveLogsToFile { get; set; } = false;

        [JsonPropertyName("log_level")]
        public string LogLevel { get; set; } = "normal"; // "minimal", "normal", "debug"
    }
}
