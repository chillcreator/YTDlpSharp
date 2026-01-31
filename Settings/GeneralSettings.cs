using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// General application settings.
    /// </summary>
    public class GeneralSettings
    {
        [JsonPropertyName("language")]
        public string Language { get; set; } = "auto"; // "auto", "ru", "en"

        [JsonPropertyName("download_folder")]
        public string DownloadFolder { get; set; } = "";

        [JsonPropertyName("always_ask_location")]
        public bool AlwaysAskLocation { get; set; } = false;

        [JsonPropertyName("auto_paste_url")]
        public bool AutoPasteUrl { get; set; } = true;

        [JsonPropertyName("max_concurrent_downloads")]
        public int MaxConcurrentDownloads { get; set; } = 1; // Default: 1 (no multi-download yet)
    }
}
