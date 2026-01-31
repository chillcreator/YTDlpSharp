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
            mainTableLayout = new TableLayoutPanel();
            settingsTabControl = new TabControl();
            generalTabPage = new TabPage();
            ytdlpTabPage = new TabPage();
            networkTabPage = new TabPage();
            otherTabPage = new TabPage();
            buttonsPanel = new Panel();
            saveButton = new Button();
            cancelButton = new Button();
            mainTableLayout.SuspendLayout();
            settingsTabControl.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(settingsTabControl, 0, 0);
            mainTableLayout.Controls.Add(buttonsPanel, 0, 1);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 2;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainTableLayout.Size = new Size(582, 403);
            mainTableLayout.TabIndex = 0;
            // 
            // settingsTabControl
            // 
            settingsTabControl.Controls.Add(generalTabPage);
            settingsTabControl.Controls.Add(ytdlpTabPage);
            settingsTabControl.Controls.Add(networkTabPage);
            settingsTabControl.Controls.Add(otherTabPage);
            settingsTabControl.Dock = DockStyle.Fill;
            settingsTabControl.Location = new Point(3, 3);
            settingsTabControl.Name = "settingsTabControl";
            settingsTabControl.SelectedIndex = 0;
            settingsTabControl.Size = new Size(576, 347);
            settingsTabControl.TabIndex = 0;
            // 
            // generalTabPage
            // 
            generalTabPage.Location = new Point(4, 29);
            generalTabPage.Name = "generalTabPage";
            generalTabPage.Padding = new Padding(3);
            generalTabPage.Size = new Size(568, 314);
            generalTabPage.TabIndex = 0;
            generalTabPage.Text = "General";
            generalTabPage.UseVisualStyleBackColor = true;
            // 
            // ytdlpTabPage
            // 
            ytdlpTabPage.Location = new Point(4, 29);
            ytdlpTabPage.Name = "ytdlpTabPage";
            ytdlpTabPage.Padding = new Padding(3);
            ytdlpTabPage.Size = new Size(568, 314);
            ytdlpTabPage.TabIndex = 1;
            ytdlpTabPage.Text = "yt-dlp";
            ytdlpTabPage.UseVisualStyleBackColor = true;
            // 
            // networkTabPage
            // 
            networkTabPage.Location = new Point(4, 29);
            networkTabPage.Name = "networkTabPage";
            networkTabPage.Size = new Size(568, 314);
            networkTabPage.TabIndex = 2;
            networkTabPage.Text = "Network";
            networkTabPage.UseVisualStyleBackColor = true;
            // 
            // otherTabPage
            // 
            otherTabPage.Location = new Point(4, 29);
            otherTabPage.Name = "otherTabPage";
            otherTabPage.Size = new Size(568, 314);
            otherTabPage.TabIndex = 3;
            otherTabPage.Text = "Other";
            otherTabPage.UseVisualStyleBackColor = true;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(cancelButton);
            buttonsPanel.Controls.Add(saveButton);
            buttonsPanel.Dock = DockStyle.Fill;
            buttonsPanel.Location = new Point(3, 356);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(576, 44);
            buttonsPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(400, 10);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 30);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(485, 10);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 30);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 403);
            Controls.Add(mainTableLayout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            mainTableLayout.ResumeLayout(false);
            settingsTabControl.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private TabControl settingsTabControl;
        private TabPage generalTabPage;
        private TabPage ytdlpTabPage;
        private TabPage networkTabPage;
        private TabPage otherTabPage;
        private Panel buttonsPanel;
        private Button cancelButton;
        private Button saveButton;
    }
}