using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Settings related to yt-dlp and FFmpeg.
    /// </summary>
    public class YtDlpSettings
    {
        [JsonPropertyName("default_format")]
        public string DefaultFormat { get; set; } = "Video + audio (best quality)";

        [JsonPropertyName("custom_arguments")]
        public string CustomArguments { get; set; } = "";

        [JsonPropertyName("retry_on_error")]
        public bool RetryOnError { get; set; } = true;

        [JsonPropertyName("max_retries")]
        public int MaxRetries { get; set; } = 3;

        [JsonPropertyName("retry_delay_seconds")]
        public int RetryDelaySeconds { get; set; } = 5;
    }
}
