using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace BackupScriptGenWin
{
    public partial class BackupFolderDialog : Form
    {
        public String SourceFolder { get; set; }
        public String TargetFolder { get; set; }

        public BackupFolderDialog()
        {
            InitializeComponent();
        }

        private void SourceFolderBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog SourceFolderBrowser = new FolderBrowserDialog();
            if (SourceFolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SourceFolderTextBox.Text = SourceFolderBrowser.SelectedPath;
            }
        }

        private void TargetFolderBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog TargetFolderBrowser = new FolderBrowserDialog();
            if (TargetFolderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               TargetFolderTextBox.Text = TargetFolderBrowser.SelectedPath;
            }
        }

        private void DialogOkButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(SourceFolderTextBox.Text) && Directory.Exists(TargetFolderTextBox.Text))
            {
                this.SourceFolder = SourceFolderTextBox.Text;
                this.TargetFolder = TargetFolderTextBox.Text;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void AdvancedTabPage_Enter(object sender, EventArgs e)
        {
            this.Height = 300;
            SaveDefaultCheckBox.Visible = true;
        }

        private void BaseTabPage_Enter(object sender, EventArgs e)
        {
            this.Height = 180;
            SaveDefaultCheckBox.Visible = false;
        }

        private void BackupFolderDialog_Load(object sender, EventArgs e)
        {
            this.Height = 180;
        }
    }
}
