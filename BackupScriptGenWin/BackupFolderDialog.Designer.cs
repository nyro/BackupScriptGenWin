namespace BackupScriptGenWin
{
    partial class BackupFolderDialog
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
            this.DialogOkButton = new System.Windows.Forms.Button();
            this.DialogCancelButton = new System.Windows.Forms.Button();
            this.FolderAddTabControl = new System.Windows.Forms.TabControl();
            this.BaseTabPage = new System.Windows.Forms.TabPage();
            this.SourceFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetFolderBrowseButton = new System.Windows.Forms.Button();
            this.SourceFolderBrowseButton = new System.Windows.Forms.Button();
            this.TargetFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdvancedTabPage = new System.Windows.Forms.TabPage();
            this.CopyGroupBox = new System.Windows.Forms.GroupBox();
            this.MirrorCheckBox = new System.Windows.Forms.CheckBox();
            this.SubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.EmptySubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.MovCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.MoveCheckBox = new System.Windows.Forms.CheckBox();
            this.PurgeCheckBox = new System.Windows.Forms.CheckBox();
            this.ResumeCheckBox = new System.Windows.Forms.CheckBox();
            this.BackupCheckBox = new System.Windows.Forms.CheckBox();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.FolderAddTabControl.SuspendLayout();
            this.BaseTabPage.SuspendLayout();
            this.AdvancedTabPage.SuspendLayout();
            this.CopyGroupBox.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogOkButton
            // 
            this.DialogOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogOkButton.Location = new System.Drawing.Point(396, 237);
            this.DialogOkButton.Name = "DialogOkButton";
            this.DialogOkButton.Size = new System.Drawing.Size(75, 23);
            this.DialogOkButton.TabIndex = 80;
            this.DialogOkButton.Text = "OK";
            this.DialogOkButton.UseVisualStyleBackColor = true;
            this.DialogOkButton.Click += new System.EventHandler(this.DialogOkButton_Click);
            // 
            // DialogCancelButton
            // 
            this.DialogCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogCancelButton.Location = new System.Drawing.Point(315, 237);
            this.DialogCancelButton.Name = "DialogCancelButton";
            this.DialogCancelButton.Size = new System.Drawing.Size(75, 23);
            this.DialogCancelButton.TabIndex = 90;
            this.DialogCancelButton.Text = "Abbrechen";
            this.DialogCancelButton.UseVisualStyleBackColor = true;
            // 
            // FolderAddTabControl
            // 
            this.FolderAddTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderAddTabControl.Controls.Add(this.BaseTabPage);
            this.FolderAddTabControl.Controls.Add(this.AdvancedTabPage);
            this.FolderAddTabControl.Location = new System.Drawing.Point(0, 0);
            this.FolderAddTabControl.Name = "FolderAddTabControl";
            this.FolderAddTabControl.SelectedIndex = 0;
            this.FolderAddTabControl.Size = new System.Drawing.Size(485, 231);
            this.FolderAddTabControl.TabIndex = 92;
            // 
            // BaseTabPage
            // 
            this.BaseTabPage.Controls.Add(this.SourceFolderTextBox);
            this.BaseTabPage.Controls.Add(this.label1);
            this.BaseTabPage.Controls.Add(this.TargetFolderBrowseButton);
            this.BaseTabPage.Controls.Add(this.SourceFolderBrowseButton);
            this.BaseTabPage.Controls.Add(this.TargetFolderTextBox);
            this.BaseTabPage.Controls.Add(this.label2);
            this.BaseTabPage.Location = new System.Drawing.Point(4, 22);
            this.BaseTabPage.Name = "BaseTabPage";
            this.BaseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BaseTabPage.Size = new System.Drawing.Size(477, 205);
            this.BaseTabPage.TabIndex = 0;
            this.BaseTabPage.Text = "Basiseinstellungen";
            this.BaseTabPage.UseVisualStyleBackColor = true;
            this.BaseTabPage.Enter += new System.EventHandler(this.BaseTabPage_Enter);
            // 
            // SourceFolderTextBox
            // 
            this.SourceFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceFolderTextBox.Location = new System.Drawing.Point(87, 17);
            this.SourceFolderTextBox.Name = "SourceFolderTextBox";
            this.SourceFolderTextBox.Size = new System.Drawing.Size(285, 20);
            this.SourceFolderTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quellordner";
            // 
            // TargetFolderBrowseButton
            // 
            this.TargetFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetFolderBrowseButton.Location = new System.Drawing.Point(378, 41);
            this.TargetFolderBrowseButton.Name = "TargetFolderBrowseButton";
            this.TargetFolderBrowseButton.Size = new System.Drawing.Size(89, 23);
            this.TargetFolderBrowseButton.TabIndex = 10;
            this.TargetFolderBrowseButton.Text = "Durchsuchen";
            this.TargetFolderBrowseButton.UseVisualStyleBackColor = true;
            this.TargetFolderBrowseButton.Click += new System.EventHandler(this.TargetFolderBrowseButton_Click);
            // 
            // SourceFolderBrowseButton
            // 
            this.SourceFolderBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceFolderBrowseButton.Location = new System.Drawing.Point(378, 15);
            this.SourceFolderBrowseButton.Name = "SourceFolderBrowseButton";
            this.SourceFolderBrowseButton.Size = new System.Drawing.Size(89, 23);
            this.SourceFolderBrowseButton.TabIndex = 8;
            this.SourceFolderBrowseButton.Text = "Durchsuchen";
            this.SourceFolderBrowseButton.UseVisualStyleBackColor = true;
            this.SourceFolderBrowseButton.Click += new System.EventHandler(this.SourceFolderBrowseButton_Click);
            // 
            // TargetFolderTextBox
            // 
            this.TargetFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetFolderTextBox.Location = new System.Drawing.Point(87, 43);
            this.TargetFolderTextBox.Name = "TargetFolderTextBox";
            this.TargetFolderTextBox.Size = new System.Drawing.Size(285, 20);
            this.TargetFolderTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zielordner";
            // 
            // AdvancedTabPage
            // 
            this.AdvancedTabPage.Controls.Add(this.FileGroupBox);
            this.AdvancedTabPage.Controls.Add(this.CopyGroupBox);
            this.AdvancedTabPage.Location = new System.Drawing.Point(4, 22);
            this.AdvancedTabPage.Name = "AdvancedTabPage";
            this.AdvancedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdvancedTabPage.Size = new System.Drawing.Size(477, 205);
            this.AdvancedTabPage.TabIndex = 1;
            this.AdvancedTabPage.Text = "Erweitert";
            this.AdvancedTabPage.UseVisualStyleBackColor = true;
            this.AdvancedTabPage.Enter += new System.EventHandler(this.AdvancedTabPage_Enter);
            // 
            // CopyGroupBox
            // 
            this.CopyGroupBox.Controls.Add(this.BackupCheckBox);
            this.CopyGroupBox.Controls.Add(this.ResumeCheckBox);
            this.CopyGroupBox.Controls.Add(this.PurgeCheckBox);
            this.CopyGroupBox.Controls.Add(this.MoveCheckBox);
            this.CopyGroupBox.Controls.Add(this.MovCheckBox);
            this.CopyGroupBox.Controls.Add(this.EmptySubfoldersCheckBox);
            this.CopyGroupBox.Controls.Add(this.SubfoldersCheckBox);
            this.CopyGroupBox.Controls.Add(this.MirrorCheckBox);
            this.CopyGroupBox.Location = new System.Drawing.Point(8, 6);
            this.CopyGroupBox.Name = "CopyGroupBox";
            this.CopyGroupBox.Size = new System.Drawing.Size(200, 193);
            this.CopyGroupBox.TabIndex = 0;
            this.CopyGroupBox.TabStop = false;
            this.CopyGroupBox.Text = "Kopieroptionen";
            // 
            // MirrorCheckBox
            // 
            this.MirrorCheckBox.AutoSize = true;
            this.MirrorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.MirrorCheckBox.Name = "MirrorCheckBox";
            this.MirrorCheckBox.Size = new System.Drawing.Size(157, 17);
            this.MirrorCheckBox.TabIndex = 0;
            this.MirrorCheckBox.Text = "Verzeichnisstruktur spiegeln";
            this.MirrorCheckBox.UseVisualStyleBackColor = true;
            // 
            // SubfoldersCheckBox
            // 
            this.SubfoldersCheckBox.AutoSize = true;
            this.SubfoldersCheckBox.Checked = true;
            this.SubfoldersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SubfoldersCheckBox.Location = new System.Drawing.Point(6, 42);
            this.SubfoldersCheckBox.Name = "SubfoldersCheckBox";
            this.SubfoldersCheckBox.Size = new System.Drawing.Size(160, 17);
            this.SubfoldersCheckBox.TabIndex = 1;
            this.SubfoldersCheckBox.Text = "Unterverzeichnisse kopieren";
            this.SubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmptySubfoldersCheckBox
            // 
            this.EmptySubfoldersCheckBox.AutoSize = true;
            this.EmptySubfoldersCheckBox.Checked = true;
            this.EmptySubfoldersCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EmptySubfoldersCheckBox.Location = new System.Drawing.Point(22, 65);
            this.EmptySubfoldersCheckBox.Name = "EmptySubfoldersCheckBox";
            this.EmptySubfoldersCheckBox.Size = new System.Drawing.Size(132, 17);
            this.EmptySubfoldersCheckBox.TabIndex = 2;
            this.EmptySubfoldersCheckBox.Text = "Leere Unterveichnisse";
            this.EmptySubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // MovCheckBox
            // 
            this.MovCheckBox.AutoSize = true;
            this.MovCheckBox.Location = new System.Drawing.Point(6, 88);
            this.MovCheckBox.Name = "MovCheckBox";
            this.MovCheckBox.Size = new System.Drawing.Size(124, 17);
            this.MovCheckBox.TabIndex = 3;
            this.MovCheckBox.Text = "Dateien verschieben";
            this.MovCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveDefaultCheckBox
            // 
            this.SaveDefaultCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveDefaultCheckBox.AutoSize = true;
            this.SaveDefaultCheckBox.Location = new System.Drawing.Point(12, 243);
            this.SaveDefaultCheckBox.Name = "SaveDefaultCheckBox";
            this.SaveDefaultCheckBox.Size = new System.Drawing.Size(135, 17);
            this.SaveDefaultCheckBox.TabIndex = 95;
            this.SaveDefaultCheckBox.Text = "Als Standard speichern";
            this.SaveDefaultCheckBox.UseVisualStyleBackColor = true;
            this.SaveDefaultCheckBox.Visible = false;
            // 
            // MoveCheckBox
            // 
            this.MoveCheckBox.AutoSize = true;
            this.MoveCheckBox.Location = new System.Drawing.Point(22, 111);
            this.MoveCheckBox.Name = "MoveCheckBox";
            this.MoveCheckBox.Size = new System.Drawing.Size(119, 17);
            this.MoveCheckBox.TabIndex = 4;
            this.MoveCheckBox.Text = "Ordner verschieben";
            this.MoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // PurgeCheckBox
            // 
            this.PurgeCheckBox.AutoSize = true;
            this.PurgeCheckBox.Location = new System.Drawing.Point(6, 134);
            this.PurgeCheckBox.Name = "PurgeCheckBox";
            this.PurgeCheckBox.Size = new System.Drawing.Size(107, 17);
            this.PurgeCheckBox.TabIndex = 5;
            this.PurgeCheckBox.Text = "Dateien Spiegeln";
            this.PurgeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResumeCheckBox
            // 
            this.ResumeCheckBox.AutoSize = true;
            this.ResumeCheckBox.Location = new System.Drawing.Point(6, 157);
            this.ResumeCheckBox.Name = "ResumeCheckBox";
            this.ResumeCheckBox.Size = new System.Drawing.Size(33, 17);
            this.ResumeCheckBox.TabIndex = 6;
            this.ResumeCheckBox.Text = "Z";
            this.ResumeCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackupCheckBox
            // 
            this.BackupCheckBox.AutoSize = true;
            this.BackupCheckBox.Location = new System.Drawing.Point(45, 157);
            this.BackupCheckBox.Name = "BackupCheckBox";
            this.BackupCheckBox.Size = new System.Drawing.Size(33, 17);
            this.BackupCheckBox.TabIndex = 7;
            this.BackupCheckBox.Text = "B";
            this.BackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.checkBox7);
            this.FileGroupBox.Controls.Add(this.checkBox6);
            this.FileGroupBox.Controls.Add(this.checkBox5);
            this.FileGroupBox.Controls.Add(this.checkBox4);
            this.FileGroupBox.Controls.Add(this.checkBox3);
            this.FileGroupBox.Controls.Add(this.checkBox2);
            this.FileGroupBox.Controls.Add(this.checkBox1);
            this.FileGroupBox.Location = new System.Drawing.Point(214, 6);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(200, 193);
            this.FileGroupBox.TabIndex = 1;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "Dateiauswahloptionen";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Geänderte Dateien ausschließen";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(166, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Neuere Dateien ausschließen";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 65);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(158, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Ältere Dateien ausschließen";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 88);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(197, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Zusätzliche Dat./Verz. ausschließen";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 111);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(183, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Einsame Dat./Verz. ausschließen";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 134);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(177, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Identische Dateien einschließen";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 157);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(175, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Optimierte Dateien einschließen";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // BackupFolderDialog
            // 
            this.AcceptButton = this.DialogOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogCancelButton;
            this.ClientSize = new System.Drawing.Size(483, 272);
            this.Controls.Add(this.SaveDefaultCheckBox);
            this.Controls.Add(this.FolderAddTabControl);
            this.Controls.Add(this.DialogCancelButton);
            this.Controls.Add(this.DialogOkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BackupFolderDialog";
            this.Text = "Job Einstellungen";
            this.Load += new System.EventHandler(this.BackupFolderDialog_Load);
            this.FolderAddTabControl.ResumeLayout(false);
            this.BaseTabPage.ResumeLayout(false);
            this.BaseTabPage.PerformLayout();
            this.AdvancedTabPage.ResumeLayout(false);
            this.CopyGroupBox.ResumeLayout(false);
            this.CopyGroupBox.PerformLayout();
            this.FileGroupBox.ResumeLayout(false);
            this.FileGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DialogOkButton;
        private System.Windows.Forms.Button DialogCancelButton;
        private System.Windows.Forms.TabControl FolderAddTabControl;
        private System.Windows.Forms.TabPage BaseTabPage;
        private System.Windows.Forms.TextBox SourceFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TargetFolderBrowseButton;
        private System.Windows.Forms.Button SourceFolderBrowseButton;
        private System.Windows.Forms.TextBox TargetFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage AdvancedTabPage;
        private System.Windows.Forms.GroupBox CopyGroupBox;
        private System.Windows.Forms.CheckBox MovCheckBox;
        private System.Windows.Forms.CheckBox EmptySubfoldersCheckBox;
        private System.Windows.Forms.CheckBox SubfoldersCheckBox;
        private System.Windows.Forms.CheckBox MirrorCheckBox;
        private System.Windows.Forms.CheckBox SaveDefaultCheckBox;
        private System.Windows.Forms.CheckBox MoveCheckBox;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox BackupCheckBox;
        private System.Windows.Forms.CheckBox ResumeCheckBox;
        private System.Windows.Forms.CheckBox PurgeCheckBox;
    }
}