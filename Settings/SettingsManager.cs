using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Менеджер настроек приложения
    /// </summary>
    public static class SettingsManager
    {
        private static readonly string AppName = "YTDlpSharp";
        private static readonly string SettingsDirectory = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            AppName);

        private static readonly string SettingsFilePath = Path.Combine(
            SettingsDirectory,
            "settings.json");

        private static readonly string BackupDirectory = Path.Combine(
            SettingsDirectory,
            "backups");

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNameCaseInsensitive = true,
            Converters = { new JsonStringEnumConverter() }
        };

        /// <summary>
        /// Загружает настройки из файла или создает новые по умолчанию
        /// </summary>
        public static AppSettings LoadSettings()
        {
            try
            {
                if (!File.Exists(SettingsFilePath))
                {
                    var defaultSettings = CreateDefaultSettings();
                    SaveSettings(defaultSettings); // Создаем файл с настройками по умолчанию
                    return defaultSettings;
                }

                string json = File.ReadAllText(SettingsFilePath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json, JsonOptions);

                return settings ?? CreateDefaultSettings();
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"JSON error: {jsonEx.Message}");
                return CreateDefaultSettings();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading settings: {ex.Message}");
                return CreateDefaultSettings();
            }
        }

        /// <summary>
        /// Сохраняет настройки в файл
        /// </summary>
        public static bool SaveSettings(AppSettings settings)
        {
            try
            {
                // Создаем директорию, если ее нет
                if (!Directory.Exists(SettingsDirectory))
                {
                    Directory.CreateDirectory(SettingsDirectory);
                }

                // Создаем резервную копию
                CreateBackup();

                // Сериализуем и сохраняем настройки
                string json = JsonSerializer.Serialize(settings, JsonOptions);
                File.WriteAllText(SettingsFilePath, json);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving settings: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Восстанавливает настройки из последней резервной копии
        /// </summary>
        public static bool RestoreFromBackup()
        {
            try
            {
                var backupFiles = Directory.GetFiles(BackupDirectory, "settings_*.json");
                if (backupFiles.Length == 0)
                    return false;

                // Берем последний бэкап
                Array.Sort(backupFiles);
                string latestBackup = backupFiles[backupFiles.Length - 1];

                if (File.Exists(latestBackup))
                {
                    File.Copy(latestBackup, SettingsFilePath, true);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error restoring from backup: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Сбрасывает настройки к значениям по умолчанию
        /// </summary>
        public static AppSettings ResetToDefaults()
        {
            var defaultSettings = CreateDefaultSettings();
            SaveSettings(defaultSettings);
            return defaultSettings;
        }

        /// <summary>
        /// Экспортирует настройки в указанный файл
        /// </summary>
        public static bool ExportSettings(string filePath)
        {
            try
            {
                var settings = LoadSettings();
                string json = JsonSerializer.Serialize(settings, JsonOptions);
                File.WriteAllText(filePath, json);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error exporting settings: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Импортирует настройки из указанного файла
        /// </summary>
        public static bool ImportSettings(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return false;

                string json = File.ReadAllText(filePath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json, JsonOptions);

                if (settings != null)
                {
                    SaveSettings(settings);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error importing settings: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Создает резервную копию текущих настроек
        /// </summary>
        private static void CreateBackup()
        {
            try
            {
                if (!File.Exists(SettingsFilePath))
                    return;

                if (!Directory.Exists(BackupDirectory))
                    Directory.CreateDirectory(BackupDirectory);

                // Создаем имя файла с временной меткой
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string backupPath = Path.Combine(BackupDirectory, $"settings_{timestamp}.json");

                File.Copy(SettingsFilePath, backupPath, true);

                // Удаляем старые бэкапы (оставляем последние 10)
                CleanupOldBackups();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating backup: {ex.Message}");
            }
        }

        /// <summary>
        /// Удаляет старые резервные копии
        /// </summary>
        private static void CleanupOldBackups()
        {
            try
            {
                var backupFiles = Directory.GetFiles(BackupDirectory, "settings_*.json");
                if (backupFiles.Length > 10)
                {
                    Array.Sort(backupFiles);

                    // Удаляем все, кроме последних 10 файлов
                    for (int i = 0; i < backupFiles.Length - 10; i++)
                    {
                        File.Delete(backupFiles[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error cleaning up backups: {ex.Message}");
            }
        }

        /// <summary>
        /// Создает настройки по умолчанию
        /// </summary>
        private static AppSettings CreateDefaultSettings()
        {
            return new AppSettings();
        }
    }
}
