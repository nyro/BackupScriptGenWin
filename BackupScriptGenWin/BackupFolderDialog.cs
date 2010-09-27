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

        private void BaseTabPage_Enter(object sender, EventArgs e)
        {
            this.Height = 180;
            SaveDefaultCheckBox.Visible = false;
        }

        private void BlacklistTabPage_Enter(object sender, EventArgs e)
        {
            this.Height = 380;
            SaveDefaultCheckBox.Visible = false;
        }

        private void AdvancedTabPage_Enter(object sender, EventArgs e)
        {
            this.Height = 286;
            SaveDefaultCheckBox.Visible = true;
        }

        private void BackupFolderDialog_Load(object sender, EventArgs e)
        {
            this.Height = 180;
        }

        private void MirrorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MirrorCheckBox.Checked)
            {
                SubfoldersCheckBox.Enabled = false;
                SubfoldersCheckBox.Checked = true;

                PurgeCheckBox.Enabled = false;
                PurgeCheckBox.Checked = true;
            }
            else
            {
                SubfoldersCheckBox.Enabled = true;

                PurgeCheckBox.Enabled = true;
                PurgeCheckBox.Checked = false;
            }
        }

        private void SubfoldersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubfoldersCheckBox.Checked)
            {
                EmptySubfoldersCheckBox.Enabled = true;
                EmptySubfoldersCheckBox.Checked = true;
            }
            else
            {
                EmptySubfoldersCheckBox.Enabled = false;
                EmptySubfoldersCheckBox.Checked = false;
            }
        }

        private void SubfoldersCheckBox_EnabledChanged(object sender, EventArgs e)
        {
            if (SubfoldersCheckBox.Enabled)
            {
                EmptySubfoldersCheckBox.Enabled = true;
            }
            else
            {
                EmptySubfoldersCheckBox.Enabled = false;
            }
        }

        private void MovCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MovCheckBox.Checked)
            {
                MoveCheckBox.Enabled = true;
            }
            else
            {
                MoveCheckBox.Enabled = false;
                MoveCheckBox.Checked = false;
            }
        }

        private void HybridCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (HybridCheckBox.Checked)
            {
                BackupCheckBox.Enabled = false;
                BackupCheckBox.Checked = true;
                ResumeCheckBox.Enabled = false;
                ResumeCheckBox.Checked = true;
            }
            else
            {
                BackupCheckBox.Enabled = true;
                ResumeCheckBox.Enabled = true;
            }
        }
    }
}
