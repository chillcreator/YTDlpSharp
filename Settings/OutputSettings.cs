using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки вывода и шаблонов имен файлов
    /// </summary>
    public class OutputSettings
    {
        /// <summary>
        /// Шаблон имени файла по умолчанию
        /// </summary>
        public string OutputTemplate { get; set; } = "%(title)s.%(ext)s";

        /// <summary>
        /// Всегда заменять небезопасные символы в именах файлов
        /// </summary>
        public bool AlwaysReplaceUnsafeCharacters { get; set; } = true;

        /// <summary>
        /// Сохранять миниатюру (обложку) видео
        /// </summary>
        public bool SaveThumbnail { get; set; } = true;

        /// <summary>
        /// Формат сохраняемой миниатюры
        /// </summary>
        public string ThumbnailFormat { get; set; } = "jpg";

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public OutputSettings() { }
    }
}
