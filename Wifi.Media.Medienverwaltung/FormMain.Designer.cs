namespace Wifi.Media.Medienverwaltung
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListTreeview = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderTrack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListListview = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlayPauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.changeImportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxMenuImportSettings = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.treeView1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageListTreeview;
            this.treeView1.Location = new System.Drawing.Point(9, 32);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(218, 325);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageListTreeview
            // 
            this.imageListTreeview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeview.ImageStream")));
            this.imageListTreeview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeview.Images.SetKeyName(0, "folder_Closed_16xLG.png");
            this.imageListTreeview.Images.SetKeyName(1, "FolderOpen_16x.png");
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTrack,
            this.columnHeaderName,
            this.columnHeaderDuration,
            this.columnHeaderLanguage});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.LargeImageList = this.imageListListview;
            this.listView1.Location = new System.Drawing.Point(236, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 325);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderTrack
            // 
            this.columnHeaderTrack.Text = "Track";
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 137;
            // 
            // columnHeaderDuration
            // 
            this.columnHeaderDuration.Text = "Duration";
            this.columnHeaderDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDuration.Width = 58;
            // 
            // columnHeaderLanguage
            // 
            this.columnHeaderLanguage.Text = "Language";
            this.columnHeaderLanguage.Width = 101;
            // 
            // imageListListview
            // 
            this.imageListListview.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListListview.ImageStream")));
            this.imageListListview.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListListview.Images.SetKeyName(0, "Note.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSongsToolStripMenuItem,
            this.editSongsToolStripMenuItem,
            this.MenuItemSaveAs,
            this.MenuItemSave,
            this.MenuItemLoad,
            this.toolStripMenuItem2,
            this.MenuItemExit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistToolStripMenuItem,
            this.newSongsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem1.Text = "Add";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // newSongsToolStripMenuItem
            // 
            this.newSongsToolStripMenuItem.Name = "newSongsToolStripMenuItem";
            this.newSongsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.newSongsToolStripMenuItem.Text = "New Songs";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeImportSettingsToolStripMenuItem,
            this.changeColoursToolStripMenuItem,
            this.showPlayPauseToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeColoursToolStripMenuItem
            // 
            this.changeColoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.changeColoursToolStripMenuItem.Name = "changeColoursToolStripMenuItem";
            this.changeColoursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeColoursToolStripMenuItem.Text = "Change Colours";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // showPlayPauseToolStripMenuItem
            // 
            this.showPlayPauseToolStripMenuItem.Name = "showPlayPauseToolStripMenuItem";
            this.showPlayPauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showPlayPauseToolStripMenuItem.Text = "Show Play/Pause";
            // 
            // importSongsToolStripMenuItem
            // 
            this.importSongsToolStripMenuItem.Image = global::Wifi.Media.Medienverwaltung.Properties.Resources.Import_16x;
            this.importSongsToolStripMenuItem.Name = "importSongsToolStripMenuItem";
            this.importSongsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importSongsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.importSongsToolStripMenuItem.Text = "Import Songs";
            this.importSongsToolStripMenuItem.Click += new System.EventHandler(this.importSongsToolStripMenuItem_Click);
            // 
            // editSongsToolStripMenuItem
            // 
            this.editSongsToolStripMenuItem.Image = global::Wifi.Media.Medienverwaltung.Properties.Resources.Cut_16x;
            this.editSongsToolStripMenuItem.Name = "editSongsToolStripMenuItem";
            this.editSongsToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.editSongsToolStripMenuItem.Text = "Edit Songs Details";
            this.editSongsToolStripMenuItem.Click += new System.EventHandler(this.editSongsToolStripMenuItem_Click);
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Image = global::Wifi.Media.Medienverwaltung.Properties.Resources.SaveAs_16x;
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.MenuItemSaveAs.Size = new System.Drawing.Size(199, 26);
            this.MenuItemSaveAs.Text = "Save As...";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Enabled = false;
            this.MenuItemSave.Image = global::Wifi.Media.Medienverwaltung.Properties.Resources.Save_16x;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(199, 26);
            this.MenuItemSave.Text = "Save";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemLoad
            // 
            this.MenuItemLoad.Image = global::Wifi.Media.Medienverwaltung.Properties.Resources.FileEncodingDialog_16x;
            this.MenuItemLoad.Name = "MenuItemLoad";
            this.MenuItemLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemLoad.Size = new System.Drawing.Size(199, 26);
            this.MenuItemLoad.Text = "Load";
            this.MenuItemLoad.Click += new System.EventHandler(this.MenuItemLoad_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Image = global::Wifi.Media.Medienverwaltung.Properties.Resources.Close_16x;
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(199, 26);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // changeImportSettingsToolStripMenuItem
            // 
            this.changeImportSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxMenuImportSettings});
            this.changeImportSettingsToolStripMenuItem.Name = "changeImportSettingsToolStripMenuItem";
            this.changeImportSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeImportSettingsToolStripMenuItem.Text = "Import Settings";
            // 
            // toolStripComboBoxMenuImportSettings
            // 
            this.toolStripComboBoxMenuImportSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripComboBoxMenuImportSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxMenuImportSettings.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripComboBoxMenuImportSettings.Items.AddRange(new object[] {
            "normal",
            "Auto-Edit"});
            this.toolStripComboBoxMenuImportSettings.Name = "toolStripComboBoxMenuImportSettings";
            this.toolStripComboBoxMenuImportSettings.Size = new System.Drawing.Size(121, 23);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medienverwaltung";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageListListview;
        private System.Windows.Forms.ImageList imageListTreeview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPlayPauseToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderTrack;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderDuration;
        private System.Windows.Forms.ColumnHeader columnHeaderLanguage;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem importSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeImportSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxMenuImportSettings;
    }
}

