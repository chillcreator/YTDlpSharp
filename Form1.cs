using YTDlpSharp.Resources;
namespace YTDlpSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Load localized strings for UI elements
            urlTextBox.PlaceholderText = Strings.UrlTextBox_PlaceholderText;
            downloadButton.Text = Strings.DownloadButton_Text;
            folderTextBox.PlaceholderText = Strings.FolderTextBox_PlaceholderText;
            browseButton.Text = Strings.BrowseButton_Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

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
    }
}
