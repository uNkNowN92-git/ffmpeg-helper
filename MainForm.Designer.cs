namespace FFMPEG_Helper
{
    partial class MainForm
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
            this.browseFilesButton = new System.Windows.Forms.Button();
            this.inputListView = new System.Windows.Forms.ListView();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.resetCommandBtn = new System.Windows.Forms.Button();
            this.applyCommandBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ffmpegPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browseFilesButton
            // 
            this.browseFilesButton.Location = new System.Drawing.Point(13, 12);
            this.browseFilesButton.Name = "browseFilesButton";
            this.browseFilesButton.Size = new System.Drawing.Size(75, 23);
            this.browseFilesButton.TabIndex = 1;
            this.browseFilesButton.Text = "Select files";
            this.browseFilesButton.UseVisualStyleBackColor = true;
            // 
            // inputListView
            // 
            this.inputListView.HideSelection = false;
            this.inputListView.Location = new System.Drawing.Point(13, 41);
            this.inputListView.Name = "inputListView";
            this.inputListView.Size = new System.Drawing.Size(675, 244);
            this.inputListView.TabIndex = 2;
            this.inputListView.UseCompatibleStateImageBehavior = false;
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(154, 321);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(534, 23);
            this.commandTextBox.TabIndex = 3;
            // 
            // resetCommandBtn
            // 
            this.resetCommandBtn.Location = new System.Drawing.Point(532, 415);
            this.resetCommandBtn.Name = "resetCommandBtn";
            this.resetCommandBtn.Size = new System.Drawing.Size(75, 23);
            this.resetCommandBtn.TabIndex = 4;
            this.resetCommandBtn.Text = "Reset";
            this.resetCommandBtn.UseVisualStyleBackColor = true;
            // 
            // applyCommandBtn
            // 
            this.applyCommandBtn.Location = new System.Drawing.Point(613, 415);
            this.applyCommandBtn.Name = "applyCommandBtn";
            this.applyCommandBtn.Size = new System.Drawing.Size(75, 23);
            this.applyCommandBtn.TabIndex = 5;
            this.applyCommandBtn.Text = "Apply";
            this.applyCommandBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Command";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output Suffix";
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(154, 350);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(103, 23);
            this.suffixTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "FFmpeg Installation Path";
            // 
            // ffmpegPath
            // 
            this.ffmpegPath.Location = new System.Drawing.Point(154, 292);
            this.ffmpegPath.Name = "ffmpegPath";
            this.ffmpegPath.Size = new System.Drawing.Size(187, 23);
            this.ffmpegPath.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.ffmpegPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyCommandBtn);
            this.Controls.Add(this.resetCommandBtn);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.inputListView);
            this.Controls.Add(this.browseFilesButton);
            this.Name = "MainForm";
            this.Text = "FFmpeg Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button browseFilesButton;
        private System.Windows.Forms.ListView inputListView;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button resetCommandBtn;
        private System.Windows.Forms.Button applyCommandBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ffmpegPath;
    }
}