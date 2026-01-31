using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Network-related settings.
    /// </summary>
    public class NetworkSettings
    {
        [JsonPropertyName("use_proxy")]
        public bool UseProxy { get; set; } = false;

        [JsonPropertyName("proxy_url")]
        public string ProxyUrl { get; set; } = "";

        [JsonPropertyName("proxy_username")]
        public string ProxyUsername { get; set; } = "";

        [JsonPropertyName("proxy_password")]
        public string ProxyPassword { get; set; } = "";

        [JsonPropertyName("speed_limit_kbps")]
        public int SpeedLimitKbps { get; set; } = 0; // 0 = no limit
    }
}
