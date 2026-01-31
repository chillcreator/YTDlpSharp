using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Main application settings container.
    /// </summary>
    public class AppSettings
    {
        [JsonPropertyName("general")]
        public GeneralSettings General { get; set; } = new GeneralSettings();

        [JsonPropertyName("ytdlp")]
        public YtDlpSettings YtDlp { get; set; } = new YtDlpSettings();

        [JsonPropertyName("network")]
        public NetworkSettings Network { get; set; } = new NetworkSettings();

        [JsonPropertyName("other")]
        public OtherSettings Other { get; set; } = new OtherSettings();
    }
}
