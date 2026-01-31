using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки мониторинга, логирования и уведомлений
    /// </summary>
    public class MonitorSettings
    {
        /// <summary>
        /// Вести лог операций
        /// </summary>
        public bool EnableLogging { get; set; } = true;

        /// <summary>
        /// Уровень детализации логирования
        /// </summary>
        public string LogLevel { get; set; } = "Info";

        /// <summary>
        /// Путь к файлу лога (пусто - использовать папку приложения)
        /// </summary>
        public string LogFilePath { get; set; } = string.Empty;

        /// <summary>
        /// Максимальный размер лог-файла в МБ
        /// </summary>
        public int MaxLogSizeMB { get; set; } = 10;

        /// <summary>
        /// Показывать уведомления Windows
        /// </summary>
        public bool ShowWindowsNotifications { get; set; } = true;

        /// <summary>
        /// Проигрывать звуковые уведомления
        /// </summary>
        public bool PlaySoundNotifications { get; set; } = false;

        /// <summary>
        /// Автоматически проверять обновления при запуске
        /// </summary>
        public bool CheckForUpdatesOnStart { get; set; } = true;

        /// <summary>
        /// Автозапуск приложения при старте системы
        /// </summary>
        public bool RunAtStartup { get; set; } = false;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MonitorSettings() { }
    }
}
