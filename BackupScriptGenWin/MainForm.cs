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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddFolderButton_Click(object sender, EventArgs e)
        {
            BackupFolderDialog NewFolderDialog = new BackupFolderDialog();
            if (NewFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ListViewItem NewFolder = new ListViewItem(NewFolderDialog.SourceFolder);
                NewFolder.SubItems.Add(NewFolderDialog.TargetFolder);
                FolderList.Items.Add(NewFolder);
                FolderRemoveButton.Enabled = true;
            }
        }

        private void FolderRemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem SelectedItem in FolderList.SelectedItems)
            {
                FolderList.Items.Remove(SelectedItem);
                if (FolderList.Items.Count == 0)
                    FolderRemoveButton.Enabled = false;
            }
        }

        private void CreateScriptButton_Click(object sender, EventArgs e)
        {
            StringBuilder ScriptStringBuilder = new StringBuilder();


            foreach (ListViewItem FolderItem in FolderList.Items)
            {
                ScriptStringBuilder.Append("robocopy \"");
                ScriptStringBuilder.Append(FolderItem.SubItems[0].Text);
                ScriptStringBuilder.Append("\" \"");
                ScriptStringBuilder.Append(FolderItem.SubItems[1].Text);
                ScriptStringBuilder.Append(" \" /MIR /NP /TEE\n");
            }

            SaveFileDialog ScriptSaveDialog = new SaveFileDialog();
            if (ScriptSaveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter ScriptFile  =File.CreateText(ScriptSaveDialog.FileName);
                ScriptFile.WriteLine(ScriptStringBuilder.ToString());
                ScriptFile.Close();
            }
        }
    }
}
