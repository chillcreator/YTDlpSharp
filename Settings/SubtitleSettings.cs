using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки субтитров
    /// </summary>
    public class SubtitleSettings
    {
        /// <summary>
        /// Загружать субтитры
        /// </summary>
        public bool DownloadSubtitles { get; set; } = false;

        /// <summary>
        /// Язык субтитров (код языка, например "en", "ru")
        /// </summary>
        public string SubtitleLanguage { get; set; } = "en";

        /// <summary>
        /// Автоматически переводить субтитры
        /// </summary>
        public bool TranslateSubtitles { get; set; } = false;

        /// <summary>
        /// Язык перевода субтитров
        /// </summary>
        public string TranslationLanguage { get; set; } = "ru";

        /// <summary>
        /// Формат субтитров
        /// </summary>
        public string SubtitleFormat { get; set; } = "srt";

        /// <summary>
        /// Встраивать субтитры в видео (только для поддерживаемых форматов)
        /// </summary>
        public bool EmbedSubtitles { get; set; } = false;

        /// <summary>
        /// Сохранять субтитры как отдельный файл
        /// </summary>
        public bool SaveSubtitlesAsFile { get; set; } = true;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public SubtitleSettings() { }
    }
}
