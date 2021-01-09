using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FFMPEG_Helper
{
    public partial class MainForm : Form
    {
        private readonly OpenFileDialog _openFileDialog;

        public MainForm()
        {
            InitializeComponent();

            _openFileDialog = new OpenFileDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            _openFileDialog.Multiselect = true;

            browseFilesButton.Click += InputListBox_Click;
            resetCommandBtn.Click += (s, e) => ResetCommandText();
            applyCommandBtn.Click += (s, e) => ApplyCommand();

            InitializeInputListView();
            ResetCommandText();
        }

        private void ApplyCommand()
        {
            var exeFullPath = $"{ffmpegPath.Text}\\ffmpeg.exe";

            if (!File.Exists(exeFullPath))
                MessageBox.Show($"File not found! {exeFullPath}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            foreach (ListViewItem item in inputListView.Items)
            {
                var filename = item.Text;
                var ext = Path.GetExtension(filename);
                var fileWithoutExt = filename.Substring(0, filename.Length - ext.Length);
                var suffix = string.IsNullOrWhiteSpace(suffixTextBox.Text) ? " - Copy" : suffixTextBox.Text;
                var outputFileName = $"{fileWithoutExt}{suffix}{ext}";

                Process.Start(exeFullPath, string.Format($"{commandTextBox.Text}", filename, outputFileName));
            }
        }

        private void ResetCommandText()
        {
            ffmpegPath.Text = @"F:\Program Files\ffmpeg\bin";
            commandTextBox.Text = @"-i ""{0}"" -bsf:v h264_metadata=video_full_range_flag=1 -c:v copy -c:a copy ""{1}""";
            suffixTextBox.Text = " Copy";
        }

        private void InitializeInputListView()
        {
            inputListView.View = View.Details;
            inputListView.GridLines = true;
            inputListView.Columns.Add("Filename", -2);
        }

        private void InputListBox_Click(object sender, EventArgs e)
        {
            var dr = _openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                inputListView.Items.Clear();

                foreach (var filename in _openFileDialog.FileNames)
                {
                    var item = new ListViewItem(filename);
                    item.SubItems.Add(filename);

                    inputListView.Items.Add(item);
                }
            }
        }
    }
}