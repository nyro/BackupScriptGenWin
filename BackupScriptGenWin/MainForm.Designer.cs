namespace BackupScriptGenWin
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FolderList = new System.Windows.Forms.ListView();
            this.SourceFolderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetFolderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FolderAddButton = new System.Windows.Forms.ToolStripButton();
            this.FolderRemoveButton = new System.Windows.Forms.ToolStripButton();
            this.CreateScriptButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderAddButton,
            this.FolderRemoveButton,
            this.toolStripSeparator1,
            this.CreateScriptButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FolderList
            // 
            this.FolderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SourceFolderColumn,
            this.TargetFolderColumn});
            this.FolderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderList.FullRowSelect = true;
            this.FolderList.Location = new System.Drawing.Point(0, 25);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(584, 337);
            this.FolderList.TabIndex = 1;
            this.FolderList.UseCompatibleStateImageBehavior = false;
            this.FolderList.View = System.Windows.Forms.View.Details;
            // 
            // SourceFolderColumn
            // 
            this.SourceFolderColumn.Text = "Quellordner";
            this.SourceFolderColumn.Width = 280;
            // 
            // TargetFolderColumn
            // 
            this.TargetFolderColumn.Text = "Zielordner";
            this.TargetFolderColumn.Width = 280;
            // 
            // FolderAddButton
            // 
            this.FolderAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FolderAddButton.Image = global::BackupScriptGenWin.Properties.Resources.folder_add;
            this.FolderAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FolderAddButton.Name = "FolderAddButton";
            this.FolderAddButton.Size = new System.Drawing.Size(23, 22);
            this.FolderAddButton.Text = "Ordner hinzufügen";
            this.FolderAddButton.Click += new System.EventHandler(this.AddFolderButton_Click);
            // 
            // FolderRemoveButton
            // 
            this.FolderRemoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FolderRemoveButton.Enabled = false;
            this.FolderRemoveButton.Image = global::BackupScriptGenWin.Properties.Resources.folder_delete;
            this.FolderRemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FolderRemoveButton.Name = "FolderRemoveButton";
            this.FolderRemoveButton.Size = new System.Drawing.Size(23, 22);
            this.FolderRemoveButton.Text = "Ordner entfernen";
            this.FolderRemoveButton.Click += new System.EventHandler(this.FolderRemoveButton_Click);
            // 
            // CreateScriptButton
            // 
            this.CreateScriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateScriptButton.Image = global::BackupScriptGenWin.Properties.Resources.table_go;
            this.CreateScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateScriptButton.Name = "CreateScriptButton";
            this.CreateScriptButton.Size = new System.Drawing.Size(23, 22);
            this.CreateScriptButton.Text = "Script erstellen";
            this.CreateScriptButton.Click += new System.EventHandler(this.CreateScriptButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "BackupScriptGen";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FolderAddButton;
        private System.Windows.Forms.ToolStripButton FolderRemoveButton;
        private System.Windows.Forms.ListView FolderList;
        private System.Windows.Forms.ColumnHeader SourceFolderColumn;
        private System.Windows.Forms.ColumnHeader TargetFolderColumn;
        private System.Windows.Forms.ToolStripButton CreateScriptButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

