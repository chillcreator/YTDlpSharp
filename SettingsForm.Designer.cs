namespace YTDlpSharp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTableLayoutPanel = new TableLayoutPanel();
            tabControlSettings = new TabControl();
            tabPageGeneral = new TabPage();
            tabPageOutput = new TabPage();
            tabPageYtDlp = new TabPage();
            tabPagePlaylist = new TabPage();
            tabPageSubtitle = new TabPage();
            tabPageNetwork = new TabPage();
            tabPagePostProcessing = new TabPage();
            tabPageAdvanced = new TabPage();
            tabPageMonitor = new TabPage();
            tabPageIntegration = new TabPage();
            tabPageOther = new TabPage();
            tabPageProfiles = new TabPage();
            tabPageScheduler = new TabPage();
            panelButtons = new Panel();
            buttonSave = new Button();
            buttonCancel = new Button();
            mainTableLayoutPanel.SuspendLayout();
            tabControlSettings.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(tabControlSettings, 0, 0);
            mainTableLayoutPanel.Controls.Add(panelButtons, 0, 1);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(10);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(5);
            mainTableLayoutPanel.RowCount = 2;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainTableLayoutPanel.Size = new Size(882, 603);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // tabControlSettings
            // 
            tabControlSettings.Controls.Add(tabPageGeneral);
            tabControlSettings.Controls.Add(tabPageOutput);
            tabControlSettings.Controls.Add(tabPageYtDlp);
            tabControlSettings.Controls.Add(tabPagePlaylist);
            tabControlSettings.Controls.Add(tabPageSubtitle);
            tabControlSettings.Controls.Add(tabPageNetwork);
            tabControlSettings.Controls.Add(tabPagePostProcessing);
            tabControlSettings.Controls.Add(tabPageAdvanced);
            tabControlSettings.Controls.Add(tabPageMonitor);
            tabControlSettings.Controls.Add(tabPageIntegration);
            tabControlSettings.Controls.Add(tabPageOther);
            tabControlSettings.Controls.Add(tabPageProfiles);
            tabControlSettings.Controls.Add(tabPageScheduler);
            tabControlSettings.Dock = DockStyle.Fill;
            tabControlSettings.Location = new Point(5, 5);
            tabControlSettings.Margin = new Padding(0);
            tabControlSettings.Name = "tabControlSettings";
            tabControlSettings.Padding = new Point(10, 10);
            tabControlSettings.SelectedIndex = 0;
            tabControlSettings.Size = new Size(872, 543);
            tabControlSettings.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            tabPageGeneral.BackColor = Color.White;
            tabPageGeneral.Location = new Point(4, 43);
            tabPageGeneral.Name = "tabPageGeneral";
            tabPageGeneral.Padding = new Padding(3);
            tabPageGeneral.Size = new Size(864, 496);
            tabPageGeneral.TabIndex = 0;
            tabPageGeneral.Text = "General";
            // 
            // tabPageOutput
            // 
            tabPageOutput.BackColor = Color.White;
            tabPageOutput.Location = new Point(4, 43);
            tabPageOutput.Name = "tabPageOutput";
            tabPageOutput.Padding = new Padding(3);
            tabPageOutput.Size = new Size(864, 496);
            tabPageOutput.TabIndex = 1;
            tabPageOutput.Text = "Output";
            // 
            // tabPageYtDlp
            // 
            tabPageYtDlp.BackColor = Color.White;
            tabPageYtDlp.Location = new Point(4, 43);
            tabPageYtDlp.Name = "tabPageYtDlp";
            tabPageYtDlp.Size = new Size(864, 496);
            tabPageYtDlp.TabIndex = 2;
            tabPageYtDlp.Text = "yt-dlp";
            // 
            // tabPagePlaylist
            // 
            tabPagePlaylist.BackColor = Color.White;
            tabPagePlaylist.Location = new Point(4, 43);
            tabPagePlaylist.Name = "tabPagePlaylist";
            tabPagePlaylist.Size = new Size(864, 496);
            tabPagePlaylist.TabIndex = 3;
            tabPagePlaylist.Text = "Playlist";
            // 
            // tabPageSubtitle
            // 
            tabPageSubtitle.BackColor = Color.White;
            tabPageSubtitle.Location = new Point(4, 43);
            tabPageSubtitle.Name = "tabPageSubtitle";
            tabPageSubtitle.Size = new Size(864, 496);
            tabPageSubtitle.TabIndex = 4;
            tabPageSubtitle.Text = "Subtitle";
            // 
            // tabPageNetwork
            // 
            tabPageNetwork.BackColor = Color.White;
            tabPageNetwork.Location = new Point(4, 43);
            tabPageNetwork.Name = "tabPageNetwork";
            tabPageNetwork.Size = new Size(864, 496);
            tabPageNetwork.TabIndex = 5;
            tabPageNetwork.Text = "Network";
            // 
            // tabPagePostProcessing
            // 
            tabPagePostProcessing.BackColor = Color.White;
            tabPagePostProcessing.Location = new Point(4, 43);
            tabPagePostProcessing.Name = "tabPagePostProcessing";
            tabPagePostProcessing.Size = new Size(864, 496);
            tabPagePostProcessing.TabIndex = 6;
            tabPagePostProcessing.Text = "Post-processing";
            // 
            // tabPageAdvanced
            // 
            tabPageAdvanced.BackColor = Color.White;
            tabPageAdvanced.Location = new Point(4, 43);
            tabPageAdvanced.Name = "tabPageAdvanced";
            tabPageAdvanced.Size = new Size(864, 496);
            tabPageAdvanced.TabIndex = 7;
            tabPageAdvanced.Text = "Advanced";
            // 
            // tabPageMonitor
            // 
            tabPageMonitor.BackColor = Color.White;
            tabPageMonitor.Location = new Point(4, 43);
            tabPageMonitor.Name = "tabPageMonitor";
            tabPageMonitor.Size = new Size(864, 496);
            tabPageMonitor.TabIndex = 8;
            tabPageMonitor.Text = "Monitor";
            // 
            // tabPageIntegration
            // 
            tabPageIntegration.BackColor = Color.White;
            tabPageIntegration.Location = new Point(4, 43);
            tabPageIntegration.Name = "tabPageIntegration";
            tabPageIntegration.Size = new Size(864, 496);
            tabPageIntegration.TabIndex = 9;
            tabPageIntegration.Text = "Integration";
            // 
            // tabPageOther
            // 
            tabPageOther.BackColor = Color.White;
            tabPageOther.Location = new Point(4, 43);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Size = new Size(864, 496);
            tabPageOther.TabIndex = 10;
            tabPageOther.Text = "Other";
            // 
            // tabPageProfiles
            // 
            tabPageProfiles.BackColor = Color.White;
            tabPageProfiles.Location = new Point(4, 43);
            tabPageProfiles.Name = "tabPageProfiles";
            tabPageProfiles.Size = new Size(864, 496);
            tabPageProfiles.TabIndex = 11;
            tabPageProfiles.Text = "Profiles";
            // 
            // tabPageScheduler
            // 
            tabPageScheduler.BackColor = Color.White;
            tabPageScheduler.Location = new Point(4, 43);
            tabPageScheduler.Name = "tabPageScheduler";
            tabPageScheduler.Size = new Size(864, 496);
            tabPageScheduler.TabIndex = 12;
            tabPageScheduler.Text = "Scheduler";
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonCancel);
            panelButtons.Controls.Add(buttonSave);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(5, 548);
            panelButtons.Margin = new Padding(0);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(0, 5, 10, 5);
            panelButtons.Size = new Size(872, 50);
            panelButtons.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Location = new Point(665, 8);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.Location = new Point(765, 8);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 603);
            Controls.Add(mainTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(700, 500);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "YTDlpSharp - Settings";
            mainTableLayoutPanel.ResumeLayout(false);
            tabControlSettings.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TabControl tabControlSettings;
        private TabPage tabPageGeneral;
        private TabPage tabPageOutput;
        private TabPage tabPageYtDlp;
        private TabPage tabPagePlaylist;
        private TabPage tabPageSubtitle;
        private TabPage tabPageNetwork;
        private TabPage tabPagePostProcessing;
        private TabPage tabPageAdvanced;
        private TabPage tabPageMonitor;
        private TabPage tabPageIntegration;
        private TabPage tabPageOther;
        private TabPage tabPageProfiles;
        private TabPage tabPageScheduler;
        private Panel panelButtons;
        private Button buttonCancel;
        private Button buttonSave;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}