using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Общие настройки приложения
    /// </summary>
    public class GeneralSettings
    {
        /// <summary>
        /// Язык интерфейса: "auto", "en", "ru"
        /// </summary>
        public string Language { get; set; } = "auto";

        /// <summary>
        /// Папка для загрузок по умолчанию
        /// </summary>
        public string DownloadFolder { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

        /// <summary>
        /// Всегда спрашивать папку перед загрузкой
        /// </summary>
        public bool AlwaysAskForFolder { get; set; } = true;

        /// <summary>
        /// Автоматически вставлять URL из буфера обмена при открытии
        /// </summary>
        public bool AutoPasteUrl { get; set; } = true;

        /// <summary>
        /// Использовать темную тему интерфейса
        /// </summary>
        public bool UseDarkTheme { get; set; } = false;

        /// <summary>
        /// Проверять обновления при запуске
        /// </summary>
        public bool CheckForUpdates { get; set; } = true;

        /// <summary>
        /// Запускать приложение при старте Windows
        /// </summary>
        public bool RunAtWindowsStartup { get; set; } = false;

        /// <summary>
        /// Минимизировать в системный трей вместо закрытия
        /// </summary>
        public bool MinimizeToTray { get; set; } = true;

        /// <summary>
        /// Показывать уведомления в системном трее
        /// </summary>
        public bool ShowTrayNotifications { get; set; } = true;

        /// <summary>
        /// Подтверждать перед удалением загрузок
        /// </summary>
        public bool ConfirmBeforeDeleting { get; set; } = true;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public GeneralSettings() { }
    }
}
