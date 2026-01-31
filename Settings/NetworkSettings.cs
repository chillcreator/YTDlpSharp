using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Сетевые настройки
    /// </summary>
    public class NetworkSettings
    {
        /// <summary>
        /// Использовать прокси-сервер
        /// </summary>
        public bool UseProxy { get; set; } = false;

        /// <summary>
        /// Адрес прокси-сервера (например: http://proxy.example.com:8080)
        /// </summary>
        public string ProxyAddress { get; set; } = string.Empty;

        /// <summary>
        /// Использовать аутентификацию для прокси
        /// </summary>
        public bool UseProxyAuthentication { get; set; } = false;

        /// <summary>
        /// Имя пользователя для прокси
        /// </summary>
        public string ProxyUsername { get; set; } = string.Empty;

        /// <summary>
        /// Пароль для прокси
        /// </summary>
        public string ProxyPassword { get; set; } = string.Empty;

        /// <summary>
        /// Использовать SOCKS прокси вместо HTTP
        /// </summary>
        public bool UseSocksProxy { get; set; } = false;

        /// <summary>
        /// Таймаут подключения в секундах
        /// </summary>
        public int ConnectionTimeout { get; set; } = 10;

        /// <summary>
        /// Таймаут чтения данных в секундах
        /// </summary>
        public int ReadTimeout { get; set; } = 30;

        /// <summary>
        /// Количество повторных попыток при ошибках сети
        /// </summary>
        public int NetworkRetries { get; set; } = 3;

        /// <summary>
        /// Использовать IPv6 вместо IPv4
        /// </summary>
        public bool PreferIPv6 { get; set; } = false;

        /// <summary>
        /// Использовать системные настройки прокси
        /// </summary>
        public bool UseSystemProxy { get; set; } = true;

        /// <summary>
        /// Разрешить небезопасные SSL-соединения (самоподписанные сертификаты)
        /// </summary>
        public bool AllowInsecureSSL { get; set; } = false;

        /// <summary>
        /// Отключать кэширование DNS
        /// </summary>
        public bool DisableDNSCache { get; set; } = false;

        /// <summary>
        /// Использовать DNS-серверы Google (8.8.8.8, 8.8.4.4)
        /// </summary>
        public bool UseGoogleDNS { get; set; } = false;

        /// <summary>
        /// Ограничение скорости загрузки (в Кбит/с, 0 - без ограничения)
        /// </summary>
        public int SpeedLimit { get; set; } = 0;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public NetworkSettings() { }
    }
}
