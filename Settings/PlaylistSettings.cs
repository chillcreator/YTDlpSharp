using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки для загрузки плейлистов
    /// </summary>
    public class PlaylistSettings
    {
        /// <summary>
        /// Скачивать весь плейлист
        /// </summary>
        public bool DownloadEntirePlaylist { get; set; } = true;

        /// <summary>
        /// Начать загрузку с номера (1 - первый)
        /// </summary>
        public int StartFromItem { get; set; } = 1;

        /// <summary>
        /// Завершить загрузку на номере (0 - до конца)
        /// </summary>
        public int EndAtItem { get; set; } = 0;

        /// <summary>
        /// Максимальное количество видео для загрузки (0 - без ограничений)
        /// </summary>
        public int MaxDownloads { get; set; } = 0;

        /// <summary>
        /// Загружать в обратном порядке
        /// </summary>
        public bool ReverseOrder { get; set; } = false;

        /// <summary>
        /// Не загружать дубликаты
        /// </summary>
        public bool SkipDuplicates { get; set; } = true;

        /// <summary>
        /// Шаблон имени для файлов в плейлисте
        /// </summary>
        public string PlaylistFileTemplate { get; set; } = "%(playlist_title)s/%(title)s.%(ext)s";

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PlaylistSettings() { }
    }
}
