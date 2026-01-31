using System;

namespace YTDlpSharp.Settings
{
    /// <summary>
    /// Корневой контейнер для всех настроек приложения
    /// </summary>
    public class AppSettings
    {
        // Основные вкладки
        public GeneralSettings General { get; set; }
        public OutputSettings Output { get; set; }
        public YtDlpSettings YtDlp { get; set; }
        public PlaylistSettings Playlist { get; set; }
        public SubtitleSettings Subtitle { get; set; }
        public NetworkSettings Network { get; set; }
        public PostProcessingSettings PostProcessing { get; set; }
        public OtherSettings Other { get; set; }

        // Расширенные вкладки
        public AdvancedSettings Advanced { get; set; }
        public MonitorSettings Monitor { get; set; }
        public IntegrationSettings Integration { get; set; }

        // Будущие вкладки (заготовки)
        public ProfilesSettings Profiles { get; set; }
        public SchedulerSettings Scheduler { get; set; }

        /// <summary>
        /// Конструктор по умолчанию - инициализирует все настройки
        /// </summary>
        public AppSettings()
        {
            // Основные вкладки
            General = new GeneralSettings();
            Output = new OutputSettings();
            YtDlp = new YtDlpSettings();
            Playlist = new PlaylistSettings();
            Subtitle = new SubtitleSettings();
            Network = new NetworkSettings();
            PostProcessing = new PostProcessingSettings();
            Other = new OtherSettings();

            // Расширенные вкладки
            Advanced = new AdvancedSettings();
            Monitor = new MonitorSettings();
            Integration = new IntegrationSettings();

            // Будущие вкладки
            Profiles = new ProfilesSettings();
            Scheduler = new SchedulerSettings();
        }
    }
}
