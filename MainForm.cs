using System.Diagnostics;
using YTDlpSharp.Resources;
using System.Collections.Generic; // для List<string>
using System.Windows.Forms;       // для MessageBox

namespace YTDlpSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Load localized strings for UI elements
            urlTextBox.PlaceholderText = Strings.UrlTextBox_PlaceholderText;
            downloadButton.Text = Strings.DownloadButton_Text;
            folderTextBox.PlaceholderText = Strings.FolderTextBox_PlaceholderText;
            browseButton.Text = Strings.BrowseButton_Text;

            // Загрузка локализованных строк для выбора формата
            formatLabel.Text = Strings.FormatLabel_Text;

            // Заполнение ComboBox вариантами формата из ресурсов
            formatComboBox.Items.Clear();
            formatComboBox.Items.Add(Strings.FormatOption_VideoAudioBest);
            formatComboBox.Items.Add(Strings.FormatOption_AudioOnly);
            formatComboBox.Items.Add(Strings.FormatOption_VideoOnly1080);
            formatComboBox.Items.Add(Strings.FormatOption_VideoOnly720);
            formatComboBox.Items.Add(Strings.FormatOption_VideoOnly480);

            // Установка выбора по умолчанию
            if (formatComboBox.Items.Count > 0)
            {
                formatComboBox.SelectedIndex = 0;
            }

            // Проверка зависимостей при запуске
            CheckDependencies();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

        private void AppendLog(string message)
        {
            if (logTextBox.InvokeRequired)
            {
                logTextBox.Invoke(new Action<string>(AppendLog), message);
            }
            else
            {
                logTextBox.AppendText(message + Environment.NewLine);
                logTextBox.ScrollToCaret(); // Автопрокрутка
            }
        }

        /// <summary>
        /// Gets the yt-dlp format arguments based on user selection in ComboBox.
        /// </summary>
        /// <returns>Format string for yt-dlp command line arguments.</returns>
        private string GetFormatArguments()
        {
            // Если ComboBox пустой или ничего не выбрано, возвращаем значение по умолчанию
            if (formatComboBox.Items.Count == 0 || formatComboBox.SelectedIndex == -1)
                return "-f best"; // значение по умолчанию

            object? selectedItem = formatComboBox.SelectedItem;

            // Проверка на null
            if (selectedItem is null)
                return "-f best";

            string? selectedFormat = selectedItem.ToString();

            // Дополнительная проверка на null или пустую строку
            if (string.IsNullOrEmpty(selectedFormat))
                return "-f best";

            // Определяем аргументы в зависимости от выбранного варианта
            if (selectedFormat == Strings.FormatOption_VideoAudioBest)
                return "-f best";
            else if (selectedFormat == Strings.FormatOption_AudioOnly)
                return "-f bestaudio";
            else if (selectedFormat == Strings.FormatOption_VideoOnly1080)
                return "-f \"bestvideo[height<=1080]\"";
            else if (selectedFormat == Strings.FormatOption_VideoOnly720)
                return "-f \"bestvideo[height<=720]\"";
            else if (selectedFormat == Strings.FormatOption_VideoOnly480)
                return "-f \"bestvideo[height<=480]\"";
            else
                return "-f best"; // резервный вариант
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = Strings.FolderDialog_Title;
                folderDialog.UseDescriptionForTitle = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {
            // Проверка ввода URL
            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                AppendLog($"{Strings.Log_ErrorPrefix} {Strings.Validation_UrlRequired}");
                return;
            }

            // Проверка выбора папки
            if (string.IsNullOrWhiteSpace(folderTextBox.Text))
            {
                AppendLog($"{Strings.Log_ErrorPrefix} {Strings.Validation_FolderRequired}");
                return;
            }

            // Отключим кнопку на время загрузки
            downloadButton.Enabled = false;

            // Выведем сообщение о начале загрузки
            AppendLog(Strings.Log_StartingDownload);

            // Формируем аргументы для yt-dlp
            // Базовые аргументы: скачать в указанную папку
            string formatArgs = GetFormatArguments();
            string arguments = $"-o \"{folderTextBox.Text}/%(title)s.%(ext)s\" {formatArgs} --merge-output-format mkv --encoding utf-8 --no-windows-filenames \"{urlTextBox.Text}\"";

            // Создаём процесс
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "yt-dlp"; // Исполняемый файл (должен быть в PATH)
                process.StartInfo.Arguments = arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
                process.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8;

                // Обработчики асинхронного чтения вывода
                process.OutputDataReceived += (sender, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data))
                    {
                        AppendLog(args.Data);
                    }
                };
                process.ErrorDataReceived += (sender, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data))
                    {
                        AppendLog($"{Strings.Log_ErrorPrefix} {args.Data}");
                    }
                };

                try
                {
                    // Запускаем процесс
                    process.StartInfo.EnvironmentVariables["PYTHONIOENCODING"] = "utf-8";
                    process.Start();

                    // Начинаем асинхронное чтение вывода
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    // Ждём завершения асинхронно
                    await process.WaitForExitAsync();

                    // Проверяем код завершения
                    if (process.ExitCode == 0)
                    {
                        AppendLog(Strings.Log_DownloadComplete);
                    }
                    else
                    {
                        AppendLog(Strings.Log_DownloadFailed);
                    }
                }
                catch (Exception ex)
                {
                    AppendLog($"{Strings.Log_ErrorPrefix} {ex.Message}");
                }
                finally
                {
                    // Включаем кнопку обратно
                    downloadButton.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Checks if a command is available in the system PATH.
        /// </summary>
        /// <param name="command">The command to check (e.g., "yt-dlp", "ffmpeg").</param>
        /// <returns>True if the command is found, false otherwise.</returns>
        private bool IsCommandAvailable(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    // На Windows используем 'where', на Unix-системах — 'which'
                    process.StartInfo.FileName = (Environment.OSVersion.Platform == PlatformID.Win32NT) ? "where" : "which";
                    process.StartInfo.Arguments = command;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;
                    process.Start();

                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Если вывод не пустой и содержит имя команды — значит, команда найдена
                    return !string.IsNullOrEmpty(output) && output.Contains(command);
                }
            }
            catch
            {
                // Если произошла ошибка (например, команда 'where' недоступна), считаем, что команда не найдена
                return false;
            }
        }

        /// <summary>
        /// Checks for required external dependencies (yt-dlp, FFmpeg).
        /// Shows a warning message if any are missing.
        /// </summary>
        private void CheckDependencies()
        {
            List<string> missingCommands = new List<string>();

            if (!IsCommandAvailable("yt-dlp"))
                missingCommands.Add(Strings.DependencyCheck_YtdlpNotFound);

            if (!IsCommandAvailable("ffmpeg"))
                missingCommands.Add(Strings.DependencyCheck_FfmpegNotFound);

            if (missingCommands.Count > 0)
            {
                string message = string.Join(Environment.NewLine + Environment.NewLine, missingCommands);
                MessageBox.Show(
                    message,
                    Strings.DependencyCheck_Title,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы настроек
            SettingsForm settingsForm = new SettingsForm();

            // Устанавливаем владельца формы (чтобы оставаться поверх MainForm)
            settingsForm.Owner = this;

            // Показываем форму как диалоговое окно (модальное)
            DialogResult result = settingsForm.ShowDialog();

            // Если нужно обработать результат после закрытия формы
            // Например, если настройки были сохранены
            if (result == DialogResult.OK)
            {
                // Здесь можно обновить что-то в MainForm
                // Например, перезагрузить настройки
                MessageBox.Show("Настройки сохранены!", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                // Пользователь нажал Cancel или закрыл форму
                // Можно ничего не делать
            }
        }
    }
}
