using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки, связанные с yt-dlp
    /// </summary>
    public class YtDlpSettings
    {
        /// <summary>
        /// Путь к исполняемому файлу yt-dlp (пусто - использовать из PATH)
        /// </summary>
        public string YtDlpPath { get; set; } = string.Empty;

        /// <summary>
        /// Автоматически обновлять yt-dlp при запуске
        /// </summary>
        public bool AutoUpdateYtDlp { get; set; } = true;

        /// <summary>
        /// Использовать aria2c для загрузки (если установлен)
        /// </summary>
        public bool UseAria2c { get; set; } = false;

        /// <summary>
        /// Путь к aria2c (если не в PATH)
        /// </summary>
        public string Aria2cPath { get; set; } = string.Empty;

        /// <summary>
        /// Количество параллельных загрузок (0 для автоматического)
        /// </summary>
        public int ConcurrentDownloads { get; set; } = 3;

        /// <summary>
        /// Ограничение скорости загрузки (в Кбит/с, 0 - без ограничений)
        /// </summary>
        public int DownloadRateLimit { get; set; } = 0;

        /// <summary>
        /// Таймаут загрузки в секундах
        /// </summary>
        public int DownloadTimeout { get; set; } = 30;

        /// <summary>
        /// Пробовать обходить ограничения (age-gate, региональные блокировки)
        /// </summary>
        public bool BypassRestrictions { get; set; } = true;

        /// <summary>
        /// Извлекать аудио без перекодирования, если возможно
        /// </summary>
        public bool ExtractAudioWithoutRecoding { get; set; } = true;

        /// <summary>
        /// Записывать метаданные (название, описание, теги) в файл
        /// </summary>
        public bool WriteMetadata { get; set; } = true;

        /// <summary>
        /// Записывать информацию о видео в JSON файл
        /// </summary>
        public bool WriteInfoJson { get; set; } = false;

        /// <summary>
        /// Сохранять миниатюру (обложку) видео
        /// </summary>
        public bool WriteThumbnail { get; set; } = true;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public YtDlpSettings() { }
    }
}
