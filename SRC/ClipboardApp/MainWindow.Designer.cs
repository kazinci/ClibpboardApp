namespace ClipboardApp
{
    partial class MainWindow
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
            ChangeClipboardChain(this.Handle, _nextClipboardViewer);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToGoogleDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCurrentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.enterGoogleDriveInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableGoogleDriveLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.disableLoggingEnableLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.clipSavingLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.syncWithGoogleLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.syncTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            authorizedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.exportBtn = new System.Windows.Forms.ToolStripButton();
            this.uploadBtn = new System.Windows.Forms.ToolStripButton();
            this.viewHistoryBtn = new System.Windows.Forms.ToolStripButton();
            this.clearBtn = new System.Windows.Forms.ToolStripButton();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.enableGoogleBtn = new System.Windows.Forms.ToolStripButton();
            this.disableGoogleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.enableLoggingBtn = new System.Windows.Forms.ToolStripButton();
            this.disableLoggingBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clipboardDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.menuStrip.SuspendLayout();
            this.trayRightClickMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableRightClickMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(819, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLogToolStripMenuItem,
            this.exportCurrentHistoryToolStripMenuItem,
            this.saveToGoogleDriveToolStripMenuItem,
            this.toolStripSeparator8,
            this.minimizeToTrayToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newLogToolStripMenuItem
            // 
            this.newLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newLogToolStripMenuItem.Image")));
            this.newLogToolStripMenuItem.Name = "newLogToolStripMenuItem";
            this.newLogToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.newLogToolStripMenuItem.Text = "New Log";
            this.newLogToolStripMenuItem.Click += new System.EventHandler(this.newLogToolStripMenuItem_Click);
            // 
            // exportCurrentHistoryToolStripMenuItem
            // 
            this.exportCurrentHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportCurrentHistoryToolStripMenuItem.Image")));
            this.exportCurrentHistoryToolStripMenuItem.Name = "exportCurrentHistoryToolStripMenuItem";
            this.exportCurrentHistoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exportCurrentHistoryToolStripMenuItem.Text = "Export Current History";
            this.exportCurrentHistoryToolStripMenuItem.Click += new System.EventHandler(this.exportCurrentHistoryToolStripMenuItem_Click);
            // 
            // saveToGoogleDriveToolStripMenuItem
            // 
            this.saveToGoogleDriveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToGoogleDriveToolStripMenuItem.Image")));
            this.saveToGoogleDriveToolStripMenuItem.Name = "saveToGoogleDriveToolStripMenuItem";
            this.saveToGoogleDriveToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveToGoogleDriveToolStripMenuItem.Text = "Save To Google Drive";
            this.saveToGoogleDriveToolStripMenuItem.Click += new System.EventHandler(this.saveToGoogleDriveToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(188, 6);
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizeToTrayToolStripMenuItem.Image")));
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize To Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryLogsToolStripMenuItem,
            this.clearCurrentHistoryToolStripMenuItem,
            this.toolStripSeparator2,
            this.enterGoogleDriveInformationToolStripMenuItem,
            this.enableGoogleDriveLoggingToolStripMenuItem,
            this.toolStripSeparator3,
            this.disableLoggingEnableLoggingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // viewHistoryLogsToolStripMenuItem
            // 
            this.viewHistoryLogsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHistoryLogsToolStripMenuItem.Image")));
            this.viewHistoryLogsToolStripMenuItem.Name = "viewHistoryLogsToolStripMenuItem";
            this.viewHistoryLogsToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.viewHistoryLogsToolStripMenuItem.Text = "View History Logs";
            this.viewHistoryLogsToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryLogsToolStripMenuItem_Click);
            // 
            // clearCurrentHistoryToolStripMenuItem
            // 
            this.clearCurrentHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearCurrentHistoryToolStripMenuItem.Image")));
            this.clearCurrentHistoryToolStripMenuItem.Name = "clearCurrentHistoryToolStripMenuItem";
            this.clearCurrentHistoryToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.clearCurrentHistoryToolStripMenuItem.Text = "Clear Current History";
            this.clearCurrentHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearCurrentHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // enterGoogleDriveInformationToolStripMenuItem
            // 
            this.enterGoogleDriveInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enterGoogleDriveInformationToolStripMenuItem.Image")));
            this.enterGoogleDriveInformationToolStripMenuItem.Name = "enterGoogleDriveInformationToolStripMenuItem";
            this.enterGoogleDriveInformationToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.enterGoogleDriveInformationToolStripMenuItem.Text = "Enter Google Drive Information/Settings ";
            this.enterGoogleDriveInformationToolStripMenuItem.Click += new System.EventHandler(this.enterGoogleDriveInformationToolStripMenuItem_Click);
            // 
            // enableGoogleDriveLoggingToolStripMenuItem
            // 
            this.enableGoogleDriveLoggingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enableGoogleDriveLoggingToolStripMenuItem.Image")));
            this.enableGoogleDriveLoggingToolStripMenuItem.Name = "enableGoogleDriveLoggingToolStripMenuItem";
            this.enableGoogleDriveLoggingToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.enableGoogleDriveLoggingToolStripMenuItem.Text = "Enable/Disable Google Drive Logging";
            this.enableGoogleDriveLoggingToolStripMenuItem.Click += new System.EventHandler(this.enableGoogleDriveLoggingToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(285, 6);
            // 
            // disableLoggingEnableLoggingToolStripMenuItem
            // 
            this.disableLoggingEnableLoggingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disableLoggingEnableLoggingToolStripMenuItem.Image")));
            this.disableLoggingEnableLoggingToolStripMenuItem.Name = "disableLoggingEnableLoggingToolStripMenuItem";
            this.disableLoggingEnableLoggingToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.disableLoggingEnableLoggingToolStripMenuItem.Text = "Enable/Disable Logging";
            this.disableLoggingEnableLoggingToolStripMenuItem.Click += new System.EventHandler(this.disableLoggingEnableLoggingToolStripMenuItem_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayRightClickMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Clipboard App";
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayRightClickMenu
            // 
            this.trayRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem,
            this.disableLoggingToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem1});
            this.trayRightClickMenu.Name = "rightClickMenu";
            this.trayRightClickMenu.Size = new System.Drawing.Size(200, 98);
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewHistoryToolStripMenuItem.Image")));
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.viewHistoryToolStripMenuItem.Text = "View History";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryToolStripMenuItem_Click);
            // 
            // disableLoggingToolStripMenuItem
            // 
            this.disableLoggingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disableLoggingToolStripMenuItem.Image")));
            this.disableLoggingToolStripMenuItem.Name = "disableLoggingToolStripMenuItem";
            this.disableLoggingToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.disableLoggingToolStripMenuItem.Text = "Enable/Disable Logging";
            this.disableLoggingToolStripMenuItem.Click += new System.EventHandler(this.disableLoggingToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem1.Image")));
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xlsx";
            this.saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
            this.saveFileDialog.InitialDirectory = "C:\\";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // timer
            // 
            this.timer.Interval = 30000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clipSavingLabel,
            this.syncWithGoogleLabel,
            this.syncTimeLabel,
            authorizedLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 304);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(819, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // clipSavingLabel
            // 
            this.clipSavingLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.clipSavingLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.clipSavingLabel.Name = "clipSavingLabel";
            this.clipSavingLabel.Size = new System.Drawing.Size(149, 19);
            this.clipSavingLabel.Text = "Clipboard Saving: Enabled";
            // 
            // syncWithGoogleLabel
            // 
            this.syncWithGoogleLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.syncWithGoogleLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.syncWithGoogleLabel.Name = "syncWithGoogleLabel";
            this.syncWithGoogleLabel.Size = new System.Drawing.Size(244, 19);
            this.syncWithGoogleLabel.Text = "Synchronization with Google Drive: Disabled";
            // 
            // syncTimeLabel
            // 
            this.syncTimeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.syncTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.syncTimeLabel.Name = "syncTimeLabel";
            this.syncTimeLabel.Size = new System.Drawing.Size(4, 19);
            // 
            // authorizedLabel
            // 
            authorizedLabel.Name = "authorizedLabel";
            authorizedLabel.Size = new System.Drawing.Size(0, 19);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportBtn,
            this.uploadBtn,
            this.viewHistoryBtn,
            this.clearBtn,
            this.settingsBtn,
            this.toolStripSeparator5,
            this.enableGoogleBtn,
            this.disableGoogleBtn,
            this.toolStripSeparator6,
            this.enableLoggingBtn,
            this.disableLoggingBtn,
            this.toolStripSeparator7,
            this.exitBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(819, 51);
            this.toolStrip.TabIndex = 12;
            this.toolStrip.Text = "toolStrip1";
            // 
            // exportBtn
            // 
            this.exportBtn.AutoSize = false;
            this.exportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exportBtn.Image = ((System.Drawing.Image)(resources.GetObject("exportBtn.Image")));
            this.exportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(41, 41);
            this.exportBtn.ToolTipText = "Export Current History";
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.AutoSize = false;
            this.uploadBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uploadBtn.Image = ((System.Drawing.Image)(resources.GetObject("uploadBtn.Image")));
            this.uploadBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.uploadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(41, 41);
            this.uploadBtn.Text = "Save to Google Drive";
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // viewHistoryBtn
            // 
            this.viewHistoryBtn.AutoSize = false;
            this.viewHistoryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.viewHistoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("viewHistoryBtn.Image")));
            this.viewHistoryBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewHistoryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewHistoryBtn.Name = "viewHistoryBtn";
            this.viewHistoryBtn.Size = new System.Drawing.Size(41, 41);
            this.viewHistoryBtn.Text = "View History Logs";
            this.viewHistoryBtn.Click += new System.EventHandler(this.viewHistoryBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = false;
            this.clearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearBtn.Image = ((System.Drawing.Image)(resources.GetObject("clearBtn.Image")));
            this.clearBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(41, 41);
            this.clearBtn.Text = "Clear Current History";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.AutoSize = false;
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(41, 41);
            this.settingsBtn.Text = "Enter Google Drive Information  / Options";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 51);
            // 
            // enableGoogleBtn
            // 
            this.enableGoogleBtn.AutoSize = false;
            this.enableGoogleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enableGoogleBtn.Image = ((System.Drawing.Image)(resources.GetObject("enableGoogleBtn.Image")));
            this.enableGoogleBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.enableGoogleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enableGoogleBtn.Name = "enableGoogleBtn";
            this.enableGoogleBtn.Size = new System.Drawing.Size(41, 41);
            this.enableGoogleBtn.Text = "Enable Google Drive Logging";
            this.enableGoogleBtn.Click += new System.EventHandler(this.enableGoogleBtn_Click);
            // 
            // disableGoogleBtn
            // 
            this.disableGoogleBtn.AutoSize = false;
            this.disableGoogleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disableGoogleBtn.Enabled = false;
            this.disableGoogleBtn.Image = ((System.Drawing.Image)(resources.GetObject("disableGoogleBtn.Image")));
            this.disableGoogleBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.disableGoogleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disableGoogleBtn.Name = "disableGoogleBtn";
            this.disableGoogleBtn.Size = new System.Drawing.Size(41, 41);
            this.disableGoogleBtn.Text = "Disable Google Drive Logging";
            this.disableGoogleBtn.Click += new System.EventHandler(this.disableGoogleBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 51);
            // 
            // enableLoggingBtn
            // 
            this.enableLoggingBtn.AutoSize = false;
            this.enableLoggingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.enableLoggingBtn.Enabled = false;
            this.enableLoggingBtn.Image = ((System.Drawing.Image)(resources.GetObject("enableLoggingBtn.Image")));
            this.enableLoggingBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.enableLoggingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enableLoggingBtn.Name = "enableLoggingBtn";
            this.enableLoggingBtn.Size = new System.Drawing.Size(41, 41);
            this.enableLoggingBtn.Text = "Enable Logging";
            this.enableLoggingBtn.Click += new System.EventHandler(this.enableLoggingBtn_Click);
            // 
            // disableLoggingBtn
            // 
            this.disableLoggingBtn.AutoSize = false;
            this.disableLoggingBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disableLoggingBtn.Image = ((System.Drawing.Image)(resources.GetObject("disableLoggingBtn.Image")));
            this.disableLoggingBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.disableLoggingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.disableLoggingBtn.Name = "disableLoggingBtn";
            this.disableLoggingBtn.Size = new System.Drawing.Size(41, 41);
            this.disableLoggingBtn.Text = "Disable Logging";
            this.disableLoggingBtn.Click += new System.EventHandler(this.disableLoggingBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 51);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = false;
            this.exitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(41, 41);
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.clipboardDataDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dataGridView.ContextMenuStrip = this.tableRightClickMenu;
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 78);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(819, 225);
            this.dataGridView.StandardTab = true;
            this.dataGridView.TabIndex = 13;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 50;
            // 
            // clipboardDataDataGridViewTextBoxColumn
            // 
            this.clipboardDataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clipboardDataDataGridViewTextBoxColumn.DataPropertyName = "Clipboard Data";
            this.clipboardDataDataGridViewTextBoxColumn.HeaderText = "Clipboard Data";
            this.clipboardDataDataGridViewTextBoxColumn.Name = "clipboardDataDataGridViewTextBoxColumn";
            this.clipboardDataDataGridViewTextBoxColumn.Width = 566;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // tableRightClickMenu
            // 
            this.tableRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.tableRightClickMenu.Name = "tableRightClickMenu";
            this.tableRightClickMenu.Size = new System.Drawing.Size(155, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToolStripMenuItem.Text = "Copy Selected";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.deleteToolStripMenuItem.Text = "Delete Selected";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Table1";
            this.bindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Number";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Clipboard Data";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Date";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Time";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 328);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboard App";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.trayRightClickMenu.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableRightClickMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToGoogleDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCurrentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem enterGoogleDriveInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableGoogleDriveLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem disableLoggingEnableLoggingToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel clipSavingLabel;
        private System.Windows.Forms.ToolStripStatusLabel syncWithGoogleLabel;
        private System.Windows.Forms.ToolStripStatusLabel syncTimeLabel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton exportBtn;
        private System.Windows.Forms.ToolStripButton uploadBtn;
        private System.Windows.Forms.ToolStripButton viewHistoryBtn;
        private System.Windows.Forms.ToolStripButton clearBtn;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton enableGoogleBtn;
        private System.Windows.Forms.ToolStripButton disableGoogleBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton enableLoggingBtn;
        private System.Windows.Forms.ToolStripButton disableLoggingBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton exitBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem newLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ContextMenuStrip tableRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clipboardDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        public static System.Windows.Forms.ToolStripStatusLabel authorizedLabel;
        //public static System.Windows.Forms.ToolStripStatusLabel authorizedLabel;
        //maybe overvrited
    }
}

