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

            // Проверка зависимостей при запуске
            CheckDependencies();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

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
            // Базовые аргументы: скачать видео со звуком в лучшем качестве, в указанную папку
            string arguments = $"-o \"{folderTextBox.Text}/%(title)s.%(ext)s\" --merge-output-format mkv --encoding utf-8 --no-windows-filenames \"{urlTextBox.Text}\"";

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

    }
}
