using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки постобработки видео/аудио
    /// </summary>
    public class PostProcessingSettings
    {
        /// <summary>
        /// Извлекать аудио из видео
        /// </summary>
        public bool ExtractAudio { get; set; } = false;

        /// <summary>
        /// Формат аудио для извлечения
        /// </summary>
        public string AudioFormat { get; set; } = "mp3";

        /// <summary>
        /// Качество аудио (битрейт)
        /// </summary>
        public string AudioQuality { get; set; } = "192";

        /// <summary>
        /// Добавлять метаданные (название, исполнитель и т.д.)
        /// </summary>
        public bool AddMetadata { get; set; } = true;

        /// <summary>
        /// Обрезать видео (в секундах, 0 - не обрезать)
        /// </summary>
        public bool TrimVideo { get; set; } = false;

        /// <summary>
        /// Начало обрезки (в секундах)
        /// </summary>
        public int TrimStart { get; set; } = 0;

        /// <summary>
        /// Конец обрезки (в секундах)
        /// </summary>
        public int TrimEnd { get; set; } = 0;

        /// <summary>
        /// Конвертировать видео в другой формат
        /// </summary>
        public bool ConvertVideo { get; set; } = false;

        /// <summary>
        /// Формат для конвертации видео
        /// </summary>
        public string VideoFormat { get; set; } = "mp4";

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PostProcessingSettings() { }
    }
}
