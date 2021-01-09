using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            // Set the file dialog to filter for graphics files.
            //this.openFileDialog1.Filter =
            //    "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            //    "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this._openFileDialog.Multiselect = true;
            //this.openFileDialog1.Title = "My Image Browser";

            browseFilesButton.Click += InputListBox_Click;
            resetCommandBtn.Click += (s, e) => ResetCommandText();
            applyCommandBtn.Click += (s, e) => ApplyCommand();
            //inputListView.View = View.Details;

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
                var outputFileName = $"{fileWithoutExt}{(string.IsNullOrWhiteSpace(suffixTextBox.Text) ? " - Copy" : suffixTextBox.Text)}{ext}";

                var cmdText = string.Format($"{commandTextBox.Text}", filename, outputFileName);
                //var cmdText = string.Format($"/C {exeFullPath} {commandTextBox.Text}", filename, outputFileName);
                //"/C C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe " +
                //"--load-extension=\"C:\\Program Files (x86)\\Google\\Chrome\\Application\\toolbar-GC\"";

                System.Diagnostics.Process.Start(exeFullPath, cmdText);
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
            var dr = this._openFileDialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                inputListView.Items.Clear();

                foreach (var filename in _openFileDialog.FileNames)
                {
                    ListViewItem item = new ListViewItem(filename);
                    // Place a check mark next to the item.
                    //item3.Checked = true;
                    item.SubItems.Add(filename);

                    inputListView.Items.Add(item);
                }
            }
        }
    }
}