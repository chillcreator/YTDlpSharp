using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Расширенные настройки для опытных пользователей
    /// </summary>
    public class AdvancedSettings
    {
        /// <summary>
        /// Дополнительные аргументы командной строки для yt-dlp
        /// </summary>
        public string AdditionalArguments { get; set; } = string.Empty;

        /// <summary>
        /// Игнорировать ошибки при загрузке
        /// </summary>
        public bool IgnoreErrors { get; set; } = false;

        /// <summary>
        /// Максимальное количество попыток загрузки
        /// </summary>
        public int MaxRetries { get; set; } = 3;

        /// <summary>
        /// Использовать файл cookie для аутентификации
        /// </summary>
        public bool UseCookies { get; set; } = false;

        /// <summary>
        /// Путь к файлу cookie
        /// </summary>
        public string CookiesFilePath { get; set; } = string.Empty;

        /// <summary>
        /// Использовать прокси-сервер
        /// </summary>
        public bool UseProxy { get; set; } = false;

        /// <summary>
        /// Адрес прокси-сервера (например: http://proxy:port)
        /// </summary>
        public string ProxyAddress { get; set; } = string.Empty;

        /// <summary>
        /// Использовать аутентификацию на прокси
        /// </summary>
        public bool UseProxyAuth { get; set; } = false;

        /// <summary>
        /// Имя пользователя для прокси
        /// </summary>
        public string ProxyUsername { get; set; } = string.Empty;

        /// <summary>
        /// Пароль для прокси
        /// </summary>
        public string ProxyPassword { get; set; } = string.Empty;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public AdvancedSettings() { }
    }
}
