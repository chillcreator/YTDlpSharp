using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Прочие настройки, не вошедшие в другие категории
    /// </summary>
    public class OtherSettings
    {
        /// <summary>
        /// Показывать скрытые параметры (для опытных пользователей)
        /// </summary>
        public bool ShowHiddenOptions { get; set; } = false;

        /// <summary>
        /// Включить режим отладки (подробное логирование)
        /// </summary>
        public bool EnableDebugMode { get; set; } = false;

        /// <summary>
        /// Вести историю загрузок
        /// </summary>
        public bool KeepDownloadHistory { get; set; } = true;

        /// <summary>
        /// Максимальное количество записей в истории (0 - без ограничений)
        /// </summary>
        public int MaxHistoryEntries { get; set; } = 100;

        /// <summary>
        /// Очищать корзину после загрузки (удалять временные файлы)
        /// </summary>
        public bool CleanupTempFiles { get; set; } = true;

        /// <summary>
        /// Автоматически удалять файлы старше указанного количества дней
        /// </summary>
        public bool AutoDeleteOldFiles { get; set; } = false;

        /// <summary>
        /// Удалять файлы старше (дней)
        /// </summary>
        public int DeleteFilesOlderThanDays { get; set; } = 30;

        /// <summary>
        /// Использовать кастомные заголовки HTTP
        /// </summary>
        public bool UseCustomHeaders { get; set; } = false;

        /// <summary>
        /// Кастомные заголовки HTTP (JSON формат)
        /// </summary>
        public string CustomHeaders { get; set; } = "{}";

        /// <summary>
        /// Использовать кастомные параметры командной строки для всех загрузок
        /// </summary>
        public bool UseCustomCommandLine { get; set; } = false;

        /// <summary>
        /// Кастомные параметры командной строки
        /// </summary>
        public string CustomCommandLineArgs { get; set; } = string.Empty;

        /// <summary>
        /// Отправлять анонимную статистику использования
        /// </summary>
        public bool SendAnonymousUsageStats { get; set; } = false;

        /// <summary>
        /// Сохранять миниатюры в отдельную папку
        /// </summary>
        public bool SaveThumbnailsInSeparateFolder { get; set; } = false;

        /// <summary>
        /// Автоматически создавать .nfo файлы (для медиа-серверов)
        /// </summary>
        public bool CreateNfoFiles { get; set; } = false;

        /// <summary>
        /// Использовать гео-обход (VPN/прокси) для определенных сайтов
        /// </summary>
        public bool UseGeoBypass { get; set; } = false;

        /// <summary>
        /// Список сайтов для обхода (через запятую)
        /// </summary>
        public string GeoBypassSites { get; set; } = "youtube.com";

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public OtherSettings() { }
    }
}
