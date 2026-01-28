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
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.Location = new Point(16, 16);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "Paste video URL here...";
            urlTextBox.Size = new Size(772, 27);
            urlTextBox.TabIndex = 0;
            urlTextBox.TextChanged += textBox1_TextChanged;
            // 
            // downloadButton
            // 
            downloadButton.Location = new Point(16, 140);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(139, 29);
            downloadButton.TabIndex = 1;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = true;
            downloadButton.Click += downloadButton_Click;
            // 
            // folderTextBox
            // 
            folderTextBox.Location = new Point(16, 80);
            folderTextBox.Name = "folderTextBox";
            folderTextBox.PlaceholderText = "Select download folder...";
            folderTextBox.Size = new Size(327, 27);
            folderTextBox.TabIndex = 2;
            // 
            // browseButton
            // 
            browseButton.Location = new Point(349, 80);
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
            logTextBox.Location = new Point(16, 203);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.ScrollBars = ScrollBars.Vertical;
            logTextBox.Size = new Size(772, 235);
            logTextBox.TabIndex = 4;
            logTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logTextBox);
            Controls.Add(browseButton);
            Controls.Add(folderTextBox);
            Controls.Add(downloadButton);
            Controls.Add(urlTextBox);
            Name = "Form1";
            Text = "YTDlpSharp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox urlTextBox;
        private Button downloadButton;
        private TextBox folderTextBox;
        private Button browseButton;
        private TextBox logTextBox;
    }
}
