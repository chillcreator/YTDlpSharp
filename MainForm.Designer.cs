namespace YTDlpSharp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            urlTextBox = new TextBox();
            downloadButton = new Button();
            folderTextBox = new TextBox();
            browseButton = new Button();
            logTextBox = new TextBox();
            formatComboBox = new ComboBox();
            formatLabel = new Label();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(12, 58);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "Paste video URL here...";
            urlTextBox.Size = new Size(772, 27);
            urlTextBox.TabIndex = 0;
            urlTextBox.TextChanged += textBox1_TextChanged;
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(16, 409);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(139, 29);
            downloadButton.TabIndex = 1;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // folderTextBox
            // 
            folderTextBox.Location = new Point(12, 91);
            folderTextBox.Name = "folderTextBox";
            folderTextBox.PlaceholderText = "Select download folder...";
            folderTextBox.Size = new Size(327, 27);
            folderTextBox.TabIndex = 2;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(345, 91);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(113, 29);
            browseButton.TabIndex = 3;
            browseButton.Text = "Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // logTextBox
            // 
            logTextBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            logTextBox.Location = new Point(16, 168);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(772, 235);
            logTextBox.TabIndex = 4;
            logTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // formatComboBox
            // 
            formatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatComboBox.FormattingEnabled = true;
            formatComboBox.Location = new Point(79, 134);
            formatComboBox.Name = "formatComboBox";
            formatComboBox.Size = new Size(260, 28);
            formatComboBox.TabIndex = 5;
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.Location = new Point(12, 134);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(0, 20);
            formatLabel.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "&Settings";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formatLabel);
            Controls.Add(formatComboBox);
            Controls.Add(logTextBox);
            Controls.Add(browseButton);
            Controls.Add(folderTextBox);
            Controls.Add(downloadButton);
            Controls.Add(urlTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "YTDlpSharp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextBox;
        private Button downloadButton;
        private TextBox folderTextBox;
        private Button browseButton;
        private TextBox logTextBox;
        private ComboBox formatComboBox;
        private Label formatLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
