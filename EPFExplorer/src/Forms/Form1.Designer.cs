﻿namespace EPFExplorer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Toolstrip_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileExtractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massRDTExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.FileTree = new System.Windows.Forms.TreeView();
            this.archivedFileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedFolderContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.rdtSubfileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openRdtSubfile = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRdtFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.archivedFileContextMenu.SuspendLayout();
            this.archivedFolderContextMenu.SuspendLayout();
            this.rdtSubfileContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(981, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toolstrip_Open,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Toolstrip_Open
            // 
            this.Toolstrip_Open.Name = "Toolstrip_Open";
            this.Toolstrip_Open.Size = new System.Drawing.Size(128, 26);
            this.Toolstrip_Open.Text = "Open";
            this.Toolstrip_Open.Click += new System.EventHandler(this.Toolstrip_Open_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileExtractorToolStripMenuItem,
            this.massRDTExportToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // saveFileExtractorToolStripMenuItem
            // 
            this.saveFileExtractorToolStripMenuItem.Name = "saveFileExtractorToolStripMenuItem";
            this.saveFileExtractorToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.saveFileExtractorToolStripMenuItem.Text = "Save File Editor";
            this.saveFileExtractorToolStripMenuItem.Click += new System.EventHandler(this.saveFileExtractorToolStripMenuItem_Click);
            // 
            // massRDTExportToolStripMenuItem
            // 
            this.massRDTExportToolStripMenuItem.Name = "massRDTExportToolStripMenuItem";
            this.massRDTExportToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.massRDTExportToolStripMenuItem.Text = "Mass RDT Export";
            this.massRDTExportToolStripMenuItem.Click += new System.EventHandler(this.massRDTExportToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1097, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "palette tester";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileTree
            // 
            this.FileTree.Location = new System.Drawing.Point(12, 31);
            this.FileTree.Name = "FileTree";
            this.FileTree.Size = new System.Drawing.Size(471, 467);
            this.FileTree.TabIndex = 4;
            // 
            // archivedFileContextMenu
            // 
            this.archivedFileContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.archivedFileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.archivedFileContextMenu.Name = "contextMenuStrip1";
            this.archivedFileContextMenu.Size = new System.Drawing.Size(133, 76);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // archivedFolderContextMenu
            // 
            this.archivedFolderContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.archivedFolderContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.renameFolderToolStripMenuItem,
            this.exportToolStripMenuItem1,
            this.deleteFolder});
            this.archivedFolderContextMenu.Name = "archivedFolderContextMenu";
            this.archivedFolderContextMenu.Size = new System.Drawing.Size(133, 100);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToFolder,
            this.addFolderToFolder});
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // addFileToFolder
            // 
            this.addFileToFolder.Name = "addFileToFolder";
            this.addFileToFolder.Size = new System.Drawing.Size(134, 26);
            this.addFileToFolder.Text = "File";
            this.addFileToFolder.Click += new System.EventHandler(this.addFileToFolder_Click);
            // 
            // addFolderToFolder
            // 
            this.addFolderToFolder.Name = "addFolderToFolder";
            this.addFolderToFolder.Size = new System.Drawing.Size(134, 26);
            this.addFolderToFolder.Text = "Folder";
            this.addFolderToFolder.Click += new System.EventHandler(this.addFolderToFolder_Click);
            // 
            // renameFolderToolStripMenuItem
            // 
            this.renameFolderToolStripMenuItem.Name = "renameFolderToolStripMenuItem";
            this.renameFolderToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.renameFolderToolStripMenuItem.Text = "Rename";
            this.renameFolderToolStripMenuItem.Click += new System.EventHandler(this.renameFolderToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(132, 24);
            this.exportToolStripMenuItem1.Text = "Export";
            this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
            // 
            // deleteFolder
            // 
            this.deleteFolder.Name = "deleteFolder";
            this.deleteFolder.Size = new System.Drawing.Size(132, 24);
            this.deleteFolder.Text = "Delete";
            this.deleteFolder.Click += new System.EventHandler(this.deleteFolder_Click);
            // 
            // rdtSubfileContextMenu
            // 
            this.rdtSubfileContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rdtSubfileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRdtSubfile,
            this.replaceToolStripMenuItem1,
            this.exportRdtFileItem,
            this.deleteToolStripMenuItem});
            this.rdtSubfileContextMenu.Name = "rdtSubfileContextMenu";
            this.rdtSubfileContextMenu.Size = new System.Drawing.Size(132, 100);
            // 
            // openRdtSubfile
            // 
            this.openRdtSubfile.Name = "openRdtSubfile";
            this.openRdtSubfile.Size = new System.Drawing.Size(131, 24);
            this.openRdtSubfile.Text = "Open";
            this.openRdtSubfile.Click += new System.EventHandler(this.openRdtSubfile_Click);
            // 
            // replaceToolStripMenuItem1
            // 
            this.replaceToolStripMenuItem1.Name = "replaceToolStripMenuItem1";
            this.replaceToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.replaceToolStripMenuItem1.Text = "Replace";
            this.replaceToolStripMenuItem1.Visible = false;
            // 
            // exportRdtFileItem
            // 
            this.exportRdtFileItem.Name = "exportRdtFileItem";
            this.exportRdtFileItem.Size = new System.Drawing.Size(131, 24);
            this.exportRdtFileItem.Text = "Export";
            this.exportRdtFileItem.Click += new System.EventHandler(this.exportRdtFileItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 510);
            this.Controls.Add(this.FileTree);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "EPFExplorer";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.archivedFileContextMenu.ResumeLayout(false);
            this.archivedFolderContextMenu.ResumeLayout(false);
            this.rdtSubfileContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Toolstrip_Open;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileExtractorToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TreeView FileTree;
        private System.Windows.Forms.ContextMenuStrip archivedFileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip archivedFolderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addFileToFolder;
        private System.Windows.Forms.ToolStripMenuItem addFolderToFolder;
        private System.Windows.Forms.ToolStripMenuItem renameFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFolder;
        private System.Windows.Forms.ContextMenuStrip rdtSubfileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openRdtSubfile;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exportRdtFileItem;
        private System.Windows.Forms.ToolStripMenuItem massRDTExportToolStripMenuItem;
    }
}

