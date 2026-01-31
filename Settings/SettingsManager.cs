using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Manages application settings: loading, saving, and providing access.
    /// </summary>
    public static class SettingsManager
    {
        private static readonly string AppDataFolder;
        private static readonly string SettingsFilePath;
        private static AppSettings _currentSettings;

        static SettingsManager()
        {
            // Путь: %APPDATA%\YTDlpSharp
            AppDataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "YTDlpSharp");

            SettingsFilePath = Path.Combine(AppDataFolder, "settings.json");

            // Загружаем настройки при первом обращении
            _currentSettings = LoadInternal();
        }

        /// <summary>
        /// Gets the current application settings.
        /// </summary>
        public static AppSettings Current => _currentSettings;

        /// <summary>
        /// Gets the path to the settings file.
        /// </summary>
        public static string SettingsPath => SettingsFilePath;

        /// <summary>
        /// Loads settings from the configuration file.
        /// If the file doesn't exist, returns default settings.
        /// </summary>
        private static AppSettings LoadInternal()
        {
            try
            {
                if (!File.Exists(SettingsFilePath))
                {
                    return CreateDefaultSettings();
                }

                string json = File.ReadAllText(SettingsFilePath);

                // Настройки сериализатора
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    WriteIndented = true // Для удобочитаемости
                };

                var settings = JsonSerializer.Deserialize<AppSettings>(json, options);

                // Проверка на null (если файл повреждён)
                return settings ?? CreateDefaultSettings();
            }
            catch (Exception)
            {
                // В случае ошибки возвращаем настройки по умолчанию
                // В будущем можно добавить логирование
                return CreateDefaultSettings();
            }
        }

        /// <summary>
        /// Reloads settings from the configuration file.
        /// </summary>
        public static void Reload()
        {
            _currentSettings = LoadInternal();
        }

        /// <summary>
        /// Saves the current settings to the configuration file.
        /// </summary>
        public static void Save()
        {
            try
            {
                // Создаём папку, если её нет
                Directory.CreateDirectory(AppDataFolder);

                // Настройки сериализатора
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                };

                string json = JsonSerializer.Serialize(_currentSettings, options);
                File.WriteAllText(SettingsFilePath, json);
            }
            catch (Exception ex)
            {
                // В будущем добавить логирование ошибок
                throw new InvalidOperationException($"Failed to save settings: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// Creates a new instance with default settings.
        /// </summary>
        private static AppSettings CreateDefaultSettings()
        {
            return new AppSettings
            {
                General = new GeneralSettings(),
                YtDlp = new YtDlpSettings(),
                Network = new NetworkSettings(),
                Other = new OtherSettings()
            };
        }

        /// <summary>
        /// Resets all settings to default values.
        /// </summary>
        public static void ResetToDefaults()
        {
            _currentSettings = CreateDefaultSettings();
            Save();
        }

        /// <summary>
        /// Creates a backup of the current settings file.
        /// </summary>
        /// <param name="backupName">Optional backup name. If not specified, uses timestamp.</param>
        public static void CreateBackup(string? backupName = null)
        {
            if (!File.Exists(SettingsFilePath))
                return;

            string backupFileName = backupName ?? $"settings_backup_{DateTime.Now:yyyyMMdd_HHmmss}.json";
            string backupPath = Path.Combine(AppDataFolder, backupFileName);

            File.Copy(SettingsFilePath, backupPath, true);
        }

        /// <summary>
        /// Gets the directory where settings backups are stored.
        /// </summary>
        public static string GetBackupsDirectory()
        {
            string backupsDir = Path.Combine(AppDataFolder, "backups");
            Directory.CreateDirectory(backupsDir);
            return backupsDir;
        }
    }
}
