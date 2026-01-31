using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Настройки интеграции с системой и внешними программами
    /// </summary>
    public class IntegrationSettings
    {
        /// <summary>
        /// Путь к внешнему редактору метаданных (пусто - не использовать)
        /// </summary>
        public string ExternalMetadataEditor { get; set; } = string.Empty;

        /// <summary>
        /// Автоматически открывать папку после загрузки
        /// </summary>
        public bool OpenFolderAfterDownload { get; set; } = true;

        /// <summary>
        /// Добавлять в контекстное меню проводника (требует прав администратора)
        /// </summary>
        public bool AddToExplorerContextMenu { get; set; } = false;

        /// <summary>
        /// Использовать горячие клавиши для быстрого вызова
        /// </summary>
        public bool UseHotkeys { get; set; } = false;

        /// <summary>
        /// Комбинация горячих клавиш (например: Ctrl+Shift+Y)
        /// </summary>
        public string HotkeyCombination { get; set; } = "Ctrl+Shift+Y";

        /// <summary>
        /// Автоматически добавлять URL из буфера обмена
        /// </summary>
        public bool AutoPasteFromClipboard { get; set; } = false;

        /// <summary>
        /// Интервал проверки буфера обмена (в секундах)
        /// </summary>
        public int ClipboardCheckInterval { get; set; } = 5;

        /// <summary>
        /// Интеграция с браузером (добавить кнопку "Скачать через YTDlpSharp")
        /// </summary>
        public bool BrowserIntegration { get; set; } = false;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public IntegrationSettings() { }
    }
}
