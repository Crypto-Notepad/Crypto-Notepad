namespace Crypto_Notepad
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileLocationMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFileMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.findMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.clearMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeKeyMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lockMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.debugMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.variablesMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.redoContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.searchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchFindNextButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchWholeWordCheckBox = new System.Windows.Forms.CheckBox();
            this.searchCaseSensitiveCheckBox = new System.Windows.Forms.CheckBox();
            this.searchCloseButton = new System.Windows.Forms.PictureBox();
            this.toolbarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lockToolbarButton = new System.Windows.Forms.PictureBox();
            this.newToolbarButton = new System.Windows.Forms.PictureBox();
            this.changeKeyToolbarButton = new System.Windows.Forms.PictureBox();
            this.openToolbarButton = new System.Windows.Forms.PictureBox();
            this.pasteToolbarButton = new System.Windows.Forms.PictureBox();
            this.saveToolbarButton = new System.Windows.Forms.PictureBox();
            this.copyToolbarButton = new System.Windows.Forms.PictureBox();
            this.fileLocationToolbarButton = new System.Windows.Forms.PictureBox();
            this.cutToolbarButton = new System.Windows.Forms.PictureBox();
            this.deleteFileToolbarButton = new System.Windows.Forms.PictureBox();
            this.closeToolbarButton = new System.Windows.Forms.PictureBox();
            this.settingsToolbarButton = new System.Windows.Forms.PictureBox();
            this.alwaysOnTopToolbarButton = new System.Windows.Forms.PictureBox();
            this.statusPanel = new System.Windows.Forms.StatusStrip();
            this.statusPanelLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPanelLengthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPaneLinesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPaneLnLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPaneColLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTrayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLockedPanel = new System.Windows.Forms.Panel();
            this.encryptionKeyPlaceholder = new System.Windows.Forms.Label();
            this.fileLockedCloseButton = new System.Windows.Forms.Button();
            this.fileLockedOkButton = new System.Windows.Forms.Button();
            this.fileLockedKeyTextBox = new System.Windows.Forms.TextBox();
            this.fileLockedShowKey = new System.Windows.Forms.PictureBox();
            this.fileLockedLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBoxPanel = new System.Windows.Forms.Panel();
            this.richTextBox = new Crypto_Notepad.ExRichTextBox();
            this.lineNumbers = new LineNumbers.LineNumbers();
            this.mainMenu.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCloseButton)).BeginInit();
            this.toolbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeKeyToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileLocationToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFileToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsToolbarButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alwaysOnTopToolbarButton)).BeginInit();
            this.statusPanel.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.fileLockedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileLockedShowKey)).BeginInit();
            this.richTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMainMenu,
            this.editMainMenu,
            this.toolsMainMenu,
            this.helpMainMenu,
            this.debugMainMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.mainMenu.Size = new System.Drawing.Size(484, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMainMenu
            // 
            this.fileMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMainMenu,
            this.openMainMenu,
            this.mainMenuSeparator1,
            this.saveMainMenu,
            this.saveAsMainMenu,
            this.mainMenuSeparator2,
            this.openFileLocationMainMenu,
            this.deleteFileMainMenu,
            this.mainMenuSeparator3,
            this.exitMainMenu});
            this.fileMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileMainMenu.Name = "fileMainMenu";
            this.fileMainMenu.Size = new System.Drawing.Size(37, 24);
            this.fileMainMenu.Text = "File";
            this.fileMainMenu.DropDownOpened += new System.EventHandler(this.FileMainMenu_DropDownOpened);
            // 
            // newMainMenu
            // 
            this.newMainMenu.Name = "newMainMenu";
            this.newMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMainMenu.Size = new System.Drawing.Size(195, 22);
            this.newMainMenu.Text = "New";
            this.newMainMenu.Click += new System.EventHandler(this.NewMainMenu_Click);
            // 
            // openMainMenu
            // 
            this.openMainMenu.Name = "openMainMenu";
            this.openMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMainMenu.Size = new System.Drawing.Size(195, 22);
            this.openMainMenu.Text = "Open...";
            this.openMainMenu.Click += new System.EventHandler(this.OpenMainMenu_Click);
            // 
            // mainMenuSeparator1
            // 
            this.mainMenuSeparator1.Name = "mainMenuSeparator1";
            this.mainMenuSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // saveMainMenu
            // 
            this.saveMainMenu.Name = "saveMainMenu";
            this.saveMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMainMenu.Size = new System.Drawing.Size(195, 22);
            this.saveMainMenu.Text = "Save";
            this.saveMainMenu.Click += new System.EventHandler(this.SaveMainMenu_Click);
            // 
            // saveAsMainMenu
            // 
            this.saveAsMainMenu.Name = "saveAsMainMenu";
            this.saveAsMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMainMenu.Size = new System.Drawing.Size(195, 22);
            this.saveAsMainMenu.Text = "Save As...";
            this.saveAsMainMenu.Click += new System.EventHandler(this.SaveAsMainMenu_Click);
            // 
            // mainMenuSeparator2
            // 
            this.mainMenuSeparator2.Name = "mainMenuSeparator2";
            this.mainMenuSeparator2.Size = new System.Drawing.Size(192, 6);
            // 
            // openFileLocationMainMenu
            // 
            this.openFileLocationMainMenu.Name = "openFileLocationMainMenu";
            this.openFileLocationMainMenu.Size = new System.Drawing.Size(195, 22);
            this.openFileLocationMainMenu.Text = "Open File Location";
            this.openFileLocationMainMenu.Click += new System.EventHandler(this.OpenFileLocationMainMenu_Click);
            // 
            // deleteFileMainMenu
            // 
            this.deleteFileMainMenu.Name = "deleteFileMainMenu";
            this.deleteFileMainMenu.Size = new System.Drawing.Size(195, 22);
            this.deleteFileMainMenu.Text = "Delete File";
            this.deleteFileMainMenu.Click += new System.EventHandler(this.DeleteFileToolStripMenuItem_Click);
            // 
            // mainMenuSeparator3
            // 
            this.mainMenuSeparator3.Name = "mainMenuSeparator3";
            this.mainMenuSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // exitMainMenu
            // 
            this.exitMainMenu.Name = "exitMainMenu";
            this.exitMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitMainMenu.Size = new System.Drawing.Size(195, 22);
            this.exitMainMenu.Text = "Exit";
            this.exitMainMenu.Click += new System.EventHandler(this.ExitMainMenu_Click);
            // 
            // editMainMenu
            // 
            this.editMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMainMenu,
            this.redoMainMenu,
            this.mainMenuSeparator4,
            this.cutMainMenu,
            this.copyMainMenu,
            this.pasteMainMenu,
            this.deleteMainMenu,
            this.mainMenuSeparator5,
            this.findMainMenu,
            this.mainMenuSeparator6,
            this.selectAllMainMenu,
            this.wordWrapMainMenu,
            this.mainMenuSeparator7,
            this.clearMainMenu});
            this.editMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editMainMenu.Name = "editMainMenu";
            this.editMainMenu.Size = new System.Drawing.Size(39, 24);
            this.editMainMenu.Text = "Edit";
            this.editMainMenu.DropDownOpened += new System.EventHandler(this.EditMainMenu_DropDownOpened);
            // 
            // undoMainMenu
            // 
            this.undoMainMenu.Name = "undoMainMenu";
            this.undoMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMainMenu.Size = new System.Drawing.Size(164, 22);
            this.undoMainMenu.Text = "Undo";
            this.undoMainMenu.Click += new System.EventHandler(this.UndoMainMenu_Click);
            // 
            // redoMainMenu
            // 
            this.redoMainMenu.Name = "redoMainMenu";
            this.redoMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMainMenu.Size = new System.Drawing.Size(164, 22);
            this.redoMainMenu.Text = "Redo";
            this.redoMainMenu.Click += new System.EventHandler(this.RedoMainMenu_Click);
            // 
            // mainMenuSeparator4
            // 
            this.mainMenuSeparator4.Name = "mainMenuSeparator4";
            this.mainMenuSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // cutMainMenu
            // 
            this.cutMainMenu.Enabled = false;
            this.cutMainMenu.Name = "cutMainMenu";
            this.cutMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMainMenu.Size = new System.Drawing.Size(164, 22);
            this.cutMainMenu.Text = "Cut";
            this.cutMainMenu.Click += new System.EventHandler(this.CutMainMenu_Click);
            // 
            // copyMainMenu
            // 
            this.copyMainMenu.Enabled = false;
            this.copyMainMenu.Name = "copyMainMenu";
            this.copyMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMainMenu.Size = new System.Drawing.Size(164, 22);
            this.copyMainMenu.Text = "Copy";
            this.copyMainMenu.Click += new System.EventHandler(this.CopyMainMenu_Click);
            // 
            // pasteMainMenu
            // 
            this.pasteMainMenu.Name = "pasteMainMenu";
            this.pasteMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMainMenu.Size = new System.Drawing.Size(164, 22);
            this.pasteMainMenu.Text = "Paste";
            this.pasteMainMenu.Click += new System.EventHandler(this.PasteMainMenu_Click);
            // 
            // deleteMainMenu
            // 
            this.deleteMainMenu.Enabled = false;
            this.deleteMainMenu.Name = "deleteMainMenu";
            this.deleteMainMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMainMenu.Size = new System.Drawing.Size(164, 22);
            this.deleteMainMenu.Text = "Delete";
            this.deleteMainMenu.Click += new System.EventHandler(this.DeleteMainMenu_Click);
            // 
            // mainMenuSeparator5
            // 
            this.mainMenuSeparator5.Name = "mainMenuSeparator5";
            this.mainMenuSeparator5.Size = new System.Drawing.Size(161, 6);
            // 
            // findMainMenu
            // 
            this.findMainMenu.Name = "findMainMenu";
            this.findMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findMainMenu.Size = new System.Drawing.Size(164, 22);
            this.findMainMenu.Text = "Find";
            this.findMainMenu.Click += new System.EventHandler(this.FindMainMenu_Click);
            // 
            // mainMenuSeparator6
            // 
            this.mainMenuSeparator6.Name = "mainMenuSeparator6";
            this.mainMenuSeparator6.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllMainMenu
            // 
            this.selectAllMainMenu.Name = "selectAllMainMenu";
            this.selectAllMainMenu.ShortcutKeyDisplayString = "";
            this.selectAllMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMainMenu.Size = new System.Drawing.Size(164, 22);
            this.selectAllMainMenu.Text = "Select All";
            this.selectAllMainMenu.Click += new System.EventHandler(this.SelectAllMainMenu_Click);
            // 
            // wordWrapMainMenu
            // 
            this.wordWrapMainMenu.Checked = true;
            this.wordWrapMainMenu.CheckOnClick = true;
            this.wordWrapMainMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wordWrapMainMenu.Name = "wordWrapMainMenu";
            this.wordWrapMainMenu.Size = new System.Drawing.Size(164, 22);
            this.wordWrapMainMenu.Text = "Word Wrap";
            this.wordWrapMainMenu.Click += new System.EventHandler(this.WordWrapMainMenu_Click);
            // 
            // mainMenuSeparator7
            // 
            this.mainMenuSeparator7.Name = "mainMenuSeparator7";
            this.mainMenuSeparator7.Size = new System.Drawing.Size(161, 6);
            // 
            // clearMainMenu
            // 
            this.clearMainMenu.Name = "clearMainMenu";
            this.clearMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.clearMainMenu.Size = new System.Drawing.Size(164, 22);
            this.clearMainMenu.Text = "Clear";
            this.clearMainMenu.Click += new System.EventHandler(this.ClearMainMenu_Click);
            // 
            // toolsMainMenu
            // 
            this.toolsMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopMainMenu,
            this.changeKeyMainMenu,
            this.lockMainMenu,
            this.settingsMainMenu});
            this.toolsMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolsMainMenu.Name = "toolsMainMenu";
            this.toolsMainMenu.Size = new System.Drawing.Size(46, 24);
            this.toolsMainMenu.Text = "Tools";
            this.toolsMainMenu.DropDownOpened += new System.EventHandler(this.ToolsMainMenu_DropDownOpened);
            // 
            // alwaysOnTopMainMenu
            // 
            this.alwaysOnTopMainMenu.CheckOnClick = true;
            this.alwaysOnTopMainMenu.Name = "alwaysOnTopMainMenu";
            this.alwaysOnTopMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.alwaysOnTopMainMenu.Size = new System.Drawing.Size(201, 22);
            this.alwaysOnTopMainMenu.Text = "Always on Top";
            this.alwaysOnTopMainMenu.Click += new System.EventHandler(this.AlwaysOnTopMainMenu_Click);
            // 
            // changeKeyMainMenu
            // 
            this.changeKeyMainMenu.Name = "changeKeyMainMenu";
            this.changeKeyMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.K)));
            this.changeKeyMainMenu.Size = new System.Drawing.Size(201, 22);
            this.changeKeyMainMenu.Text = "Change Key";
            this.changeKeyMainMenu.Click += new System.EventHandler(this.ChangeKeyMainMenu_Click);
            // 
            // lockMainMenu
            // 
            this.lockMainMenu.Name = "lockMainMenu";
            this.lockMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lockMainMenu.Size = new System.Drawing.Size(201, 22);
            this.lockMainMenu.Text = "Lock";
            this.lockMainMenu.Click += new System.EventHandler(this.LockMainMenu_Click);
            // 
            // settingsMainMenu
            // 
            this.settingsMainMenu.Name = "settingsMainMenu";
            this.settingsMainMenu.ShortcutKeyDisplayString = "";
            this.settingsMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.settingsMainMenu.Size = new System.Drawing.Size(201, 22);
            this.settingsMainMenu.Text = "Settings";
            this.settingsMainMenu.Click += new System.EventHandler(this.SettingsMainMenu_Click);
            // 
            // helpMainMenu
            // 
            this.helpMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationMainMenu,
            this.checkForUpdatesMainMenu,
            this.mainMenuSeparator8,
            this.aboutMainMenu});
            this.helpMainMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpMainMenu.Name = "helpMainMenu";
            this.helpMainMenu.Size = new System.Drawing.Size(44, 24);
            this.helpMainMenu.Text = "Help";
            // 
            // documentationMainMenu
            // 
            this.documentationMainMenu.Name = "documentationMainMenu";
            this.documentationMainMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.documentationMainMenu.Size = new System.Drawing.Size(180, 22);
            this.documentationMainMenu.Text = "Documentation";
            this.documentationMainMenu.Click += new System.EventHandler(this.DocumentationMainMenu_Click);
            // 
            // checkForUpdatesMainMenu
            // 
            this.checkForUpdatesMainMenu.Name = "checkForUpdatesMainMenu";
            this.checkForUpdatesMainMenu.RightToLeftAutoMirrorImage = true;
            this.checkForUpdatesMainMenu.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdatesMainMenu.Text = "Сheck for Updates...";
            this.checkForUpdatesMainMenu.Click += new System.EventHandler(this.CheckForUpdatesMainMenu_Click);
            // 
            // mainMenuSeparator8
            // 
            this.mainMenuSeparator8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainMenuSeparator8.Name = "mainMenuSeparator8";
            this.mainMenuSeparator8.Size = new System.Drawing.Size(177, 6);
            // 
            // aboutMainMenu
            // 
            this.aboutMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.aboutMainMenu.Name = "aboutMainMenu";
            this.aboutMainMenu.ShortcutKeyDisplayString = "";
            this.aboutMainMenu.Size = new System.Drawing.Size(180, 22);
            this.aboutMainMenu.Text = "About";
            this.aboutMainMenu.Click += new System.EventHandler(this.AboutMainMenu_Click);
            // 
            // debugMainMenu
            // 
            this.debugMainMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.debugMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variablesMainMenu,
            this.insertMainMenu});
            this.debugMainMenu.Name = "debugMainMenu";
            this.debugMainMenu.Size = new System.Drawing.Size(54, 24);
            this.debugMainMenu.Text = "Debug";
            this.debugMainMenu.Visible = false;
            // 
            // variablesMainMenu
            // 
            this.variablesMainMenu.Name = "variablesMainMenu";
            this.variablesMainMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.variablesMainMenu.Size = new System.Drawing.Size(215, 22);
            this.variablesMainMenu.Text = "Main variables";
            this.variablesMainMenu.Click += new System.EventHandler(this.VariablesMainMenu_Click);
            // 
            // insertMainMenu
            // 
            this.insertMainMenu.Name = "insertMainMenu";
            this.insertMainMenu.Size = new System.Drawing.Size(215, 22);
            this.insertMainMenu.Text = "Insert";
            this.insertMainMenu.Visible = false;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoContextMenu,
            this.redoContextMenu,
            this.contextMenuSeparator1,
            this.cutContextMenu,
            this.copyContextMenu,
            this.pasteContextMenu,
            this.deleteContextMenu,
            this.contextMenuSeparator2,
            this.selectAllContextMenu,
            this.rightToLeftContextMenu,
            this.clearContextMenu});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(185, 214);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_Opening);
            // 
            // undoContextMenu
            // 
            this.undoContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.undoContextMenu.Name = "undoContextMenu";
            this.undoContextMenu.Size = new System.Drawing.Size(184, 22);
            this.undoContextMenu.Text = "Undo";
            this.undoContextMenu.Click += new System.EventHandler(this.UndoContextMenu_Click);
            // 
            // redoContextMenu
            // 
            this.redoContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.redoContextMenu.Name = "redoContextMenu";
            this.redoContextMenu.Size = new System.Drawing.Size(184, 22);
            this.redoContextMenu.Text = "Redo";
            this.redoContextMenu.Click += new System.EventHandler(this.RedoContextMenu_Click);
            // 
            // contextMenuSeparator1
            // 
            this.contextMenuSeparator1.Name = "contextMenuSeparator1";
            this.contextMenuSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // cutContextMenu
            // 
            this.cutContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cutContextMenu.Name = "cutContextMenu";
            this.cutContextMenu.Size = new System.Drawing.Size(184, 22);
            this.cutContextMenu.Text = "Cut";
            this.cutContextMenu.Click += new System.EventHandler(this.CutContextMenu_Click);
            // 
            // copyContextMenu
            // 
            this.copyContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.copyContextMenu.Name = "copyContextMenu";
            this.copyContextMenu.Size = new System.Drawing.Size(184, 22);
            this.copyContextMenu.Text = "Copy";
            this.copyContextMenu.Click += new System.EventHandler(this.CopyContextMenu_Click);
            // 
            // pasteContextMenu
            // 
            this.pasteContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pasteContextMenu.Name = "pasteContextMenu";
            this.pasteContextMenu.Size = new System.Drawing.Size(184, 22);
            this.pasteContextMenu.Text = "Paste";
            this.pasteContextMenu.Click += new System.EventHandler(this.PasteContextMenu_Click);
            // 
            // deleteContextMenu
            // 
            this.deleteContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteContextMenu.Name = "deleteContextMenu";
            this.deleteContextMenu.Size = new System.Drawing.Size(184, 22);
            this.deleteContextMenu.Text = "Delete";
            this.deleteContextMenu.Click += new System.EventHandler(this.DeleteContextMenu_Click);
            // 
            // contextMenuSeparator2
            // 
            this.contextMenuSeparator2.Name = "contextMenuSeparator2";
            this.contextMenuSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // selectAllContextMenu
            // 
            this.selectAllContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectAllContextMenu.Name = "selectAllContextMenu";
            this.selectAllContextMenu.Size = new System.Drawing.Size(184, 22);
            this.selectAllContextMenu.Text = "Select All";
            this.selectAllContextMenu.Click += new System.EventHandler(this.SelectAllContextMenu_Click);
            // 
            // rightToLeftContextMenu
            // 
            this.rightToLeftContextMenu.CheckOnClick = true;
            this.rightToLeftContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rightToLeftContextMenu.Name = "rightToLeftContextMenu";
            this.rightToLeftContextMenu.Size = new System.Drawing.Size(184, 22);
            this.rightToLeftContextMenu.Text = "Right-to-left reading";
            this.rightToLeftContextMenu.Click += new System.EventHandler(this.RightToLeftContextMenu_Click);
            // 
            // clearContextMenu
            // 
            this.clearContextMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearContextMenu.Name = "clearContextMenu";
            this.clearContextMenu.Size = new System.Drawing.Size(184, 22);
            this.clearContextMenu.Text = "Clear";
            this.clearContextMenu.Click += new System.EventHandler(this.ClearContextMenu_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Crypto Notepad (*.cnp)|*.cnp|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Crypto Notepad (*.cnp)|*.cnp";
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.ColumnCount = 5;
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.searchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.searchPanel.Controls.Add(this.searchFindNextButton, 3, 0);
            this.searchPanel.Controls.Add(this.searchTextBox, 0, 0);
            this.searchPanel.Controls.Add(this.searchWholeWordCheckBox, 2, 0);
            this.searchPanel.Controls.Add(this.searchCaseSensitiveCheckBox, 1, 0);
            this.searchPanel.Controls.Add(this.searchCloseButton, 4, 0);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchPanel.ForeColor = System.Drawing.Color.Black;
            this.searchPanel.Location = new System.Drawing.Point(0, 214);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.RowCount = 1;
            this.searchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.searchPanel.Size = new System.Drawing.Size(484, 25);
            this.searchPanel.TabIndex = 17;
            this.searchPanel.Visible = false;
            // 
            // searchFindNextButton
            // 
            this.searchFindNextButton.BackColor = System.Drawing.Color.Transparent;
            this.searchFindNextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchFindNextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchFindNextButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchFindNextButton.FlatAppearance.BorderSize = 0;
            this.searchFindNextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchFindNextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.searchFindNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchFindNextButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchFindNextButton.ForeColor = System.Drawing.Color.Black;
            this.searchFindNextButton.Location = new System.Drawing.Point(393, 3);
            this.searchFindNextButton.Name = "searchFindNextButton";
            this.searchFindNextButton.Size = new System.Drawing.Size(66, 19);
            this.searchFindNextButton.TabIndex = 15;
            this.searchFindNextButton.TabStop = false;
            this.searchFindNextButton.Text = "Find Next";
            this.searchFindNextButton.UseMnemonic = false;
            this.searchFindNextButton.UseVisualStyleBackColor = false;
            this.searchFindNextButton.Click += new System.EventHandler(this.SearchFindNextButton_Click);
            this.searchFindNextButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchFindNextButton_MouseDown);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.ForeColor = System.Drawing.Color.Black;
            this.searchTextBox.Location = new System.Drawing.Point(3, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(180, 15);
            this.searchTextBox.TabIndex = 9;
            this.searchTextBox.TabStop = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // searchWholeWordCheckBox
            // 
            this.searchWholeWordCheckBox.AutoSize = true;
            this.searchWholeWordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.searchWholeWordCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchWholeWordCheckBox.ForeColor = System.Drawing.Color.Black;
            this.searchWholeWordCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchWholeWordCheckBox.Location = new System.Drawing.Point(293, 3);
            this.searchWholeWordCheckBox.Name = "searchWholeWordCheckBox";
            this.searchWholeWordCheckBox.Size = new System.Drawing.Size(94, 19);
            this.searchWholeWordCheckBox.TabIndex = 12;
            this.searchWholeWordCheckBox.TabStop = false;
            this.searchWholeWordCheckBox.Text = "Whole word";
            this.searchWholeWordCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchWholeWordCheckBox.UseVisualStyleBackColor = false;
            this.searchWholeWordCheckBox.CheckedChanged += new System.EventHandler(this.SearchWholeWordCheckBox_CheckedChanged);
            // 
            // searchCaseSensitiveCheckBox
            // 
            this.searchCaseSensitiveCheckBox.AutoSize = true;
            this.searchCaseSensitiveCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.searchCaseSensitiveCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCaseSensitiveCheckBox.ForeColor = System.Drawing.Color.Black;
            this.searchCaseSensitiveCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchCaseSensitiveCheckBox.Location = new System.Drawing.Point(189, 3);
            this.searchCaseSensitiveCheckBox.Name = "searchCaseSensitiveCheckBox";
            this.searchCaseSensitiveCheckBox.Size = new System.Drawing.Size(98, 19);
            this.searchCaseSensitiveCheckBox.TabIndex = 11;
            this.searchCaseSensitiveCheckBox.TabStop = false;
            this.searchCaseSensitiveCheckBox.Text = "Case sensitive";
            this.searchCaseSensitiveCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchCaseSensitiveCheckBox.UseVisualStyleBackColor = false;
            this.searchCaseSensitiveCheckBox.CheckedChanged += new System.EventHandler(this.SearchCaseSensitiveCheckBox_CheckedChanged);
            // 
            // searchCloseButton
            // 
            this.searchCloseButton.BackColor = System.Drawing.Color.Transparent;
            this.searchCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCloseButton.Image")));
            this.searchCloseButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchCloseButton.Location = new System.Drawing.Point(465, 3);
            this.searchCloseButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.searchCloseButton.Name = "searchCloseButton";
            this.searchCloseButton.Size = new System.Drawing.Size(15, 19);
            this.searchCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchCloseButton.TabIndex = 14;
            this.searchCloseButton.TabStop = false;
            this.searchCloseButton.Click += new System.EventHandler(this.SearchCloseButton_Click);
            this.searchCloseButton.MouseLeave += new System.EventHandler(this.SearchCloseButton_MouseLeave);
            this.searchCloseButton.MouseHover += new System.EventHandler(this.SearchCloseButton_MouseHover);
            // 
            // toolbarPanel
            // 
            this.toolbarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.toolbarPanel.ColumnCount = 14;
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.toolbarPanel.Controls.Add(this.lockToolbarButton, 9, 0);
            this.toolbarPanel.Controls.Add(this.newToolbarButton, 0, 0);
            this.toolbarPanel.Controls.Add(this.changeKeyToolbarButton, 8, 0);
            this.toolbarPanel.Controls.Add(this.openToolbarButton, 1, 0);
            this.toolbarPanel.Controls.Add(this.pasteToolbarButton, 7, 0);
            this.toolbarPanel.Controls.Add(this.saveToolbarButton, 2, 0);
            this.toolbarPanel.Controls.Add(this.copyToolbarButton, 6, 0);
            this.toolbarPanel.Controls.Add(this.fileLocationToolbarButton, 3, 0);
            this.toolbarPanel.Controls.Add(this.cutToolbarButton, 5, 0);
            this.toolbarPanel.Controls.Add(this.deleteFileToolbarButton, 4, 0);
            this.toolbarPanel.Controls.Add(this.closeToolbarButton, 13, 0);
            this.toolbarPanel.Controls.Add(this.settingsToolbarButton, 11, 0);
            this.toolbarPanel.Controls.Add(this.alwaysOnTopToolbarButton, 10, 0);
            this.toolbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.toolbarPanel.Location = new System.Drawing.Point(0, 24);
            this.toolbarPanel.Name = "toolbarPanel";
            this.toolbarPanel.RowCount = 1;
            this.toolbarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbarPanel.Size = new System.Drawing.Size(484, 24);
            this.toolbarPanel.TabIndex = 17;
            this.toolbarPanel.MouseEnter += new System.EventHandler(this.ToolbarPanel_MouseEnter);
            // 
            // lockToolbarButton
            // 
            this.lockToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lockToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("lockToolbarButton.Image")));
            this.lockToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lockToolbarButton.Location = new System.Drawing.Point(219, 3);
            this.lockToolbarButton.Name = "lockToolbarButton";
            this.lockToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.lockToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lockToolbarButton.TabIndex = 15;
            this.lockToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.lockToolbarButton, "Lock");
            this.lockToolbarButton.Click += new System.EventHandler(this.LockToolbarButton_Click);
            // 
            // newToolbarButton
            // 
            this.newToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolbarButton.Image")));
            this.newToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.newToolbarButton.Location = new System.Drawing.Point(3, 3);
            this.newToolbarButton.Name = "newToolbarButton";
            this.newToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.newToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.newToolbarButton.TabIndex = 15;
            this.newToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.newToolbarButton, "New");
            this.newToolbarButton.Click += new System.EventHandler(this.NewToolbarButton_Click);
            // 
            // changeKeyToolbarButton
            // 
            this.changeKeyToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeKeyToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("changeKeyToolbarButton.Image")));
            this.changeKeyToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.changeKeyToolbarButton.Location = new System.Drawing.Point(195, 3);
            this.changeKeyToolbarButton.Name = "changeKeyToolbarButton";
            this.changeKeyToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.changeKeyToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.changeKeyToolbarButton.TabIndex = 15;
            this.changeKeyToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.changeKeyToolbarButton, "Change key");
            this.changeKeyToolbarButton.Click += new System.EventHandler(this.ChangeKeyToolbarButton_Click);
            // 
            // openToolbarButton
            // 
            this.openToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolbarButton.Image")));
            this.openToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openToolbarButton.Location = new System.Drawing.Point(27, 3);
            this.openToolbarButton.Name = "openToolbarButton";
            this.openToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.openToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.openToolbarButton.TabIndex = 15;
            this.openToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.openToolbarButton, "Open");
            this.openToolbarButton.Click += new System.EventHandler(this.OpenToolbarButton_Click);
            // 
            // pasteToolbarButton
            // 
            this.pasteToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasteToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolbarButton.Image")));
            this.pasteToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pasteToolbarButton.Location = new System.Drawing.Point(171, 3);
            this.pasteToolbarButton.Name = "pasteToolbarButton";
            this.pasteToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.pasteToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pasteToolbarButton.TabIndex = 15;
            this.pasteToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.pasteToolbarButton, "Paste");
            this.pasteToolbarButton.Click += new System.EventHandler(this.PasteToolbarButton_Click);
            // 
            // saveToolbarButton
            // 
            this.saveToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolbarButton.Image")));
            this.saveToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.saveToolbarButton.Location = new System.Drawing.Point(51, 3);
            this.saveToolbarButton.Name = "saveToolbarButton";
            this.saveToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.saveToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.saveToolbarButton.TabIndex = 15;
            this.saveToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.saveToolbarButton, "Save");
            this.saveToolbarButton.Click += new System.EventHandler(this.SaveToolbarButton_Click);
            // 
            // copyToolbarButton
            // 
            this.copyToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolbarButton.Image")));
            this.copyToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.copyToolbarButton.Location = new System.Drawing.Point(147, 3);
            this.copyToolbarButton.Name = "copyToolbarButton";
            this.copyToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.copyToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.copyToolbarButton.TabIndex = 15;
            this.copyToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.copyToolbarButton, "Copy");
            this.copyToolbarButton.Click += new System.EventHandler(this.CopyToolbarButton_Click);
            // 
            // fileLocationToolbarButton
            // 
            this.fileLocationToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileLocationToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("fileLocationToolbarButton.Image")));
            this.fileLocationToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fileLocationToolbarButton.Location = new System.Drawing.Point(75, 3);
            this.fileLocationToolbarButton.Name = "fileLocationToolbarButton";
            this.fileLocationToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.fileLocationToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fileLocationToolbarButton.TabIndex = 15;
            this.fileLocationToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.fileLocationToolbarButton, "Open file folder");
            this.fileLocationToolbarButton.Click += new System.EventHandler(this.FileLocationToolbarButton_Click);
            // 
            // cutToolbarButton
            // 
            this.cutToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cutToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolbarButton.Image")));
            this.cutToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cutToolbarButton.Location = new System.Drawing.Point(123, 3);
            this.cutToolbarButton.Name = "cutToolbarButton";
            this.cutToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.cutToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cutToolbarButton.TabIndex = 15;
            this.cutToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.cutToolbarButton, "Cut");
            this.cutToolbarButton.Click += new System.EventHandler(this.CutToolbarButton_Click);
            // 
            // deleteFileToolbarButton
            // 
            this.deleteFileToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFileToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteFileToolbarButton.Image")));
            this.deleteFileToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteFileToolbarButton.Location = new System.Drawing.Point(99, 3);
            this.deleteFileToolbarButton.Name = "deleteFileToolbarButton";
            this.deleteFileToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.deleteFileToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.deleteFileToolbarButton.TabIndex = 15;
            this.deleteFileToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.deleteFileToolbarButton, "Delete file");
            this.deleteFileToolbarButton.Click += new System.EventHandler(this.DeleteFileToolbarButton_Click);
            // 
            // closeToolbarButton
            // 
            this.closeToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeToolbarButton.Image = global::Crypto_Notepad.Properties.Resources.close_g;
            this.closeToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeToolbarButton.Location = new System.Drawing.Point(463, 3);
            this.closeToolbarButton.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.closeToolbarButton.Name = "closeToolbarButton";
            this.closeToolbarButton.Size = new System.Drawing.Size(15, 18);
            this.closeToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeToolbarButton.TabIndex = 14;
            this.closeToolbarButton.TabStop = false;
            this.closeToolbarButton.Visible = false;
            this.closeToolbarButton.Click += new System.EventHandler(this.CloseToolbarButton_Click);
            this.closeToolbarButton.MouseEnter += new System.EventHandler(this.CloseToolbarButton_MouseEnter);
            this.closeToolbarButton.MouseLeave += new System.EventHandler(this.CloseToolbarButton_MouseLeave);
            // 
            // settingsToolbarButton
            // 
            this.settingsToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsToolbarButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolbarButton.Image")));
            this.settingsToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.settingsToolbarButton.Location = new System.Drawing.Point(267, 3);
            this.settingsToolbarButton.Name = "settingsToolbarButton";
            this.settingsToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.settingsToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.settingsToolbarButton.TabIndex = 15;
            this.settingsToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.settingsToolbarButton, "Settings");
            this.settingsToolbarButton.Click += new System.EventHandler(this.SettingsToolbarButton_Click);
            // 
            // alwaysOnTopToolbarButton
            // 
            this.alwaysOnTopToolbarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alwaysOnTopToolbarButton.Image = global::Crypto_Notepad.Properties.Resources.applications_blue;
            this.alwaysOnTopToolbarButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.alwaysOnTopToolbarButton.Location = new System.Drawing.Point(243, 3);
            this.alwaysOnTopToolbarButton.Name = "alwaysOnTopToolbarButton";
            this.alwaysOnTopToolbarButton.Size = new System.Drawing.Size(16, 16);
            this.alwaysOnTopToolbarButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alwaysOnTopToolbarButton.TabIndex = 15;
            this.alwaysOnTopToolbarButton.TabStop = false;
            this.toolTip.SetToolTip(this.alwaysOnTopToolbarButton, "Always on Top");
            this.alwaysOnTopToolbarButton.Click += new System.EventHandler(this.AlwaysOnTopToolbarButton_Click);
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.statusPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusPanel.ForeColor = System.Drawing.Color.Black;
            this.statusPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPanelLabel,
            this.statusPanelLengthLabel,
            this.statusPaneLinesLabel,
            this.statusPaneLnLabel,
            this.statusPaneColLabel});
            this.statusPanel.Location = new System.Drawing.Point(0, 239);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(484, 22);
            this.statusPanel.TabIndex = 18;
            // 
            // statusPanelLabel
            // 
            this.statusPanelLabel.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.statusPanelLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusPanelLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusPanelLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusPanelLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusPanelLabel.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.statusPanelLabel.LinkColor = System.Drawing.Color.SteelBlue;
            this.statusPanelLabel.Name = "statusPanelLabel";
            this.statusPanelLabel.Size = new System.Drawing.Size(43, 17);
            this.statusPanelLabel.Text = "Ready";
            this.statusPanelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusPanelLabel.VisitedLinkColor = System.Drawing.Color.SteelBlue;
            this.statusPanelLabel.Click += new System.EventHandler(this.StatusPanelLabel_Click);
            this.statusPanelLabel.TextChanged += new System.EventHandler(this.StatusPanelLabel_TextChanged);
            // 
            // statusPanelLengthLabel
            // 
            this.statusPanelLengthLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusPanelLengthLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusPanelLengthLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusPanelLengthLabel.Name = "statusPanelLengthLabel";
            this.statusPanelLengthLabel.Size = new System.Drawing.Size(59, 17);
            this.statusPanelLengthLabel.Text = "Length: 0";
            // 
            // statusPaneLinesLabel
            // 
            this.statusPaneLinesLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusPaneLinesLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusPaneLinesLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusPaneLinesLabel.Name = "statusPaneLinesLabel";
            this.statusPaneLinesLabel.Size = new System.Drawing.Size(49, 17);
            this.statusPaneLinesLabel.Text = "Lines: 1";
            // 
            // statusPaneLnLabel
            // 
            this.statusPaneLnLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusPaneLnLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusPaneLnLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusPaneLnLabel.Name = "statusPaneLnLabel";
            this.statusPaneLnLabel.Size = new System.Drawing.Size(35, 17);
            this.statusPaneLnLabel.Text = "Ln: 1";
            // 
            // statusPaneColLabel
            // 
            this.statusPaneColLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusPaneColLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusPaneColLabel.Name = "statusPaneColLabel";
            this.statusPaneColLabel.Size = new System.Drawing.Size(36, 17);
            this.statusPaneColLabel.Text = "Col: 0";
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Crypto Notepad";
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTrayMenu,
            this.exitTrayMenu});
            this.trayMenu.Name = "mnuTray";
            this.trayMenu.Size = new System.Drawing.Size(104, 48);
            // 
            // showTrayMenu
            // 
            this.showTrayMenu.Name = "showTrayMenu";
            this.showTrayMenu.Size = new System.Drawing.Size(103, 22);
            this.showTrayMenu.Text = "Show";
            this.showTrayMenu.Click += new System.EventHandler(this.ShowTrayMenu_Click);
            // 
            // exitTrayMenu
            // 
            this.exitTrayMenu.Name = "exitTrayMenu";
            this.exitTrayMenu.Size = new System.Drawing.Size(103, 22);
            this.exitTrayMenu.Text = "Exit";
            this.exitTrayMenu.Click += new System.EventHandler(this.ExitTrayMenu_Click);
            // 
            // fileLockedPanel
            // 
            this.fileLockedPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileLockedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fileLockedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLockedPanel.Controls.Add(this.encryptionKeyPlaceholder);
            this.fileLockedPanel.Controls.Add(this.fileLockedCloseButton);
            this.fileLockedPanel.Controls.Add(this.fileLockedOkButton);
            this.fileLockedPanel.Controls.Add(this.fileLockedKeyTextBox);
            this.fileLockedPanel.Controls.Add(this.fileLockedShowKey);
            this.fileLockedPanel.Controls.Add(this.fileLockedLabel);
            this.fileLockedPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileLockedPanel.ForeColor = System.Drawing.Color.Azure;
            this.fileLockedPanel.Location = new System.Drawing.Point(106, 30);
            this.fileLockedPanel.Name = "fileLockedPanel";
            this.fileLockedPanel.Size = new System.Drawing.Size(261, 91);
            this.fileLockedPanel.TabIndex = 20;
            this.fileLockedPanel.Visible = false;
            this.fileLockedPanel.VisibleChanged += new System.EventHandler(this.FileLockedPanel_VisibleChanged);
            // 
            // encryptionKeyPlaceholder
            // 
            this.encryptionKeyPlaceholder.AutoSize = true;
            this.encryptionKeyPlaceholder.BackColor = System.Drawing.SystemColors.Window;
            this.encryptionKeyPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.encryptionKeyPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.encryptionKeyPlaceholder.Location = new System.Drawing.Point(11, 37);
            this.encryptionKeyPlaceholder.Name = "encryptionKeyPlaceholder";
            this.encryptionKeyPlaceholder.Size = new System.Drawing.Size(82, 13);
            this.encryptionKeyPlaceholder.TabIndex = 12;
            this.encryptionKeyPlaceholder.Text = "Encryption key";
            // 
            // fileLockedCloseButton
            // 
            this.fileLockedCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileLockedCloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fileLockedCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fileLockedCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fileLockedCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileLockedCloseButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileLockedCloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.fileLockedCloseButton.Location = new System.Drawing.Point(239, -2);
            this.fileLockedCloseButton.Name = "fileLockedCloseButton";
            this.fileLockedCloseButton.Size = new System.Drawing.Size(23, 23);
            this.fileLockedCloseButton.TabIndex = 11;
            this.fileLockedCloseButton.TabStop = false;
            this.fileLockedCloseButton.Text = "X";
            this.fileLockedCloseButton.UseVisualStyleBackColor = true;
            this.fileLockedCloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileLockedCloseButton_MouseClick);
            this.fileLockedCloseButton.MouseEnter += new System.EventHandler(this.FileLockedCloseButton_MouseEnter);
            this.fileLockedCloseButton.MouseLeave += new System.EventHandler(this.FileLockedCloseButton_MouseLeave);
            // 
            // fileLockedOkButton
            // 
            this.fileLockedOkButton.Enabled = false;
            this.fileLockedOkButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileLockedOkButton.Location = new System.Drawing.Point(6, 60);
            this.fileLockedOkButton.Name = "fileLockedOkButton";
            this.fileLockedOkButton.Size = new System.Drawing.Size(57, 23);
            this.fileLockedOkButton.TabIndex = 10;
            this.fileLockedOkButton.Text = "OK";
            this.fileLockedOkButton.UseVisualStyleBackColor = true;
            this.fileLockedOkButton.Click += new System.EventHandler(this.FileLockedOkButton_Click);
            // 
            // fileLockedKeyTextBox
            // 
            this.fileLockedKeyTextBox.Location = new System.Drawing.Point(6, 34);
            this.fileLockedKeyTextBox.Name = "fileLockedKeyTextBox";
            this.fileLockedKeyTextBox.Size = new System.Drawing.Size(231, 22);
            this.fileLockedKeyTextBox.TabIndex = 8;
            this.fileLockedKeyTextBox.UseSystemPasswordChar = true;
            this.fileLockedKeyTextBox.TextChanged += new System.EventHandler(this.FileLockedKeyTextBox_TextChanged);
            this.fileLockedKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FileLockedKeyTextBox_KeyDown);
            // 
            // fileLockedShowKey
            // 
            this.fileLockedShowKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLockedShowKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileLockedShowKey.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.fileLockedShowKey.InitialImage = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.fileLockedShowKey.Location = new System.Drawing.Point(239, 34);
            this.fileLockedShowKey.Name = "fileLockedShowKey";
            this.fileLockedShowKey.Size = new System.Drawing.Size(18, 22);
            this.fileLockedShowKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fileLockedShowKey.TabIndex = 9;
            this.fileLockedShowKey.TabStop = false;
            this.fileLockedShowKey.Click += new System.EventHandler(this.FileLockedShowKey_Click);
            // 
            // fileLockedLabel
            // 
            this.fileLockedLabel.AutoEllipsis = true;
            this.fileLockedLabel.AutoSize = true;
            this.fileLockedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileLockedLabel.Location = new System.Drawing.Point(88, 3);
            this.fileLockedLabel.Name = "fileLockedLabel";
            this.fileLockedLabel.Size = new System.Drawing.Size(71, 17);
            this.fileLockedLabel.TabIndex = 7;
            this.fileLockedLabel.Text = "File locked";
            // 
            // richTextBoxPanel
            // 
            this.richTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxPanel.Controls.Add(this.fileLockedPanel);
            this.richTextBoxPanel.Controls.Add(this.richTextBox);
            this.richTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPanel.Location = new System.Drawing.Point(22, 48);
            this.richTextBoxPanel.Name = "richTextBoxPanel";
            this.richTextBoxPanel.Size = new System.Drawing.Size(462, 166);
            this.richTextBoxPanel.TabIndex = 21;
            // 
            // richTextBox
            // 
            this.richTextBox.AcceptsTab = true;
            this.richTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.ContextMenuStrip = this.contextMenu;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richTextBox.ForeColor = System.Drawing.Color.Black;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(460, 164);
            this.richTextBox.TabIndex = 16;
            this.richTextBox.Text = "";
            this.richTextBox.CursorPositionChanged += new System.EventHandler(this.RichTextBox_CursorPositionChanged);
            this.richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RichTextBox_LinkClicked);
            this.richTextBox.SelectionChanged += new System.EventHandler(this.RichTextBox_SelectionChanged);
            this.richTextBox.Click += new System.EventHandler(this.RichTextBox_Click);
            this.richTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            this.richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox_KeyDown);
            // 
            // lineNumbers
            // 
            this.lineNumbers._SeeThroughMode_ = false;
            this.lineNumbers.AutoSizing = true;
            this.lineNumbers.BackColor = System.Drawing.SystemColors.Control;
            this.lineNumbers.BackgroundGradient_AlphaColor = System.Drawing.Color.Transparent;
            this.lineNumbers.BackgroundGradient_BetaColor = System.Drawing.Color.Transparent;
            this.lineNumbers.BackgroundGradient_Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lineNumbers.BorderLines_Color = System.Drawing.Color.Transparent;
            this.lineNumbers.BorderLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers.BorderLines_Thickness = 1F;
            this.lineNumbers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNumbers.DockSide = LineNumbers.LineNumbers.LineNumberDockSide.Left;
            this.lineNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lineNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164)))));
            this.lineNumbers.GridLines_Color = System.Drawing.Color.Transparent;
            this.lineNumbers.GridLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers.GridLines_Thickness = 1F;
            this.lineNumbers.LineNrs_Alignment = System.Drawing.ContentAlignment.TopCenter;
            this.lineNumbers.LineNrs_AntiAlias = true;
            this.lineNumbers.LineNrs_AsHexadecimal = false;
            this.lineNumbers.LineNrs_ClippedByItemRectangle = true;
            this.lineNumbers.LineNrs_LeadingZeroes = false;
            this.lineNumbers.LineNrs_Offset = new System.Drawing.Size(0, 0);
            this.lineNumbers.Location = new System.Drawing.Point(0, 48);
            this.lineNumbers.Margin = new System.Windows.Forms.Padding(0);
            this.lineNumbers.MarginLines_Color = System.Drawing.Color.DarkGray;
            this.lineNumbers.MarginLines_Side = LineNumbers.LineNumbers.LineNumberDockSide.None;
            this.lineNumbers.MarginLines_Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.lineNumbers.MarginLines_Thickness = 1F;
            this.lineNumbers.Name = "lineNumbers";
            this.lineNumbers.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.lineNumbers.ParentRichTextBox = this.richTextBox;
            this.lineNumbers.Show_BackgroundGradient = false;
            this.lineNumbers.Show_BorderLines = false;
            this.lineNumbers.Show_GridLines = false;
            this.lineNumbers.Show_LineNrs = true;
            this.lineNumbers.Show_MarginLines = false;
            this.lineNumbers.Size = new System.Drawing.Size(22, 166);
            this.lineNumbers.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.richTextBoxPanel);
            this.Controls.Add(this.lineNumbers);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.toolbarPanel);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.statusPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypto Notepad";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCloseButton)).EndInit();
            this.toolbarPanel.ResumeLayout(false);
            this.toolbarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeKeyToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pasteToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileLocationToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFileToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsToolbarButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alwaysOnTopToolbarButton)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.fileLockedPanel.ResumeLayout(false);
            this.fileLockedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileLockedShowKey)).EndInit();
            this.richTextBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileMainMenu;
        private System.Windows.Forms.ToolStripMenuItem editMainMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMainMenu;
        private System.Windows.Forms.ToolStripMenuItem saveAsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMainMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMainMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem newMainMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem clearMainMenu;
        private System.Windows.Forms.ToolStripMenuItem openMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveMainMenu;
        private System.Windows.Forms.ToolStripMenuItem selectAllMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cutMainMenu;
        private System.Windows.Forms.ToolStripMenuItem copyMainMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator6;
        private System.Windows.Forms.ToolStripMenuItem deleteFileMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationMainMenu;
        private System.Windows.Forms.ToolStripMenuItem wordWrapMainMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem undoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem undoMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator7;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteMainMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteContextMenu;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectAllContextMenu;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearContextMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changeKeyMainMenu;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesMainMenu;
        private System.Windows.Forms.ToolStripMenuItem documentationMainMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator5;
        private System.Windows.Forms.ToolStripMenuItem findMainMenu;
        private System.Windows.Forms.PictureBox newToolbarButton;
        private System.Windows.Forms.PictureBox openToolbarButton;
        private System.Windows.Forms.PictureBox saveToolbarButton;
        private System.Windows.Forms.PictureBox fileLocationToolbarButton;
        private System.Windows.Forms.PictureBox deleteFileToolbarButton;
        private System.Windows.Forms.PictureBox cutToolbarButton;
        private System.Windows.Forms.PictureBox copyToolbarButton;
        private System.Windows.Forms.PictureBox pasteToolbarButton;
        private System.Windows.Forms.PictureBox changeKeyToolbarButton;
        private System.Windows.Forms.PictureBox settingsToolbarButton;
        private System.Windows.Forms.PictureBox closeToolbarButton;
        private System.Windows.Forms.PictureBox lockToolbarButton;
        private System.Windows.Forms.ToolStripMenuItem lockMainMenu;
        private System.Windows.Forms.ToolStripSeparator mainMenuSeparator8;
        private System.Windows.Forms.ToolStripMenuItem redoMainMenu;
        private System.Windows.Forms.ToolStripMenuItem redoContextMenu;
        private System.Windows.Forms.ToolStripMenuItem debugMainMenu;
        private System.Windows.Forms.ToolStripMenuItem variablesMainMenu;
        private System.Windows.Forms.ToolStripStatusLabel statusPanelLengthLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusPaneLinesLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusPaneLnLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusPaneColLabel;
        public System.Windows.Forms.TableLayoutPanel toolbarPanel;
        public ExRichTextBox richTextBox;
        public System.Windows.Forms.ToolStripMenuItem insertMainMenu;
        public LineNumbers.LineNumbers lineNumbers;
        protected internal System.Windows.Forms.StatusStrip statusPanel;
        protected internal System.Windows.Forms.ToolStripStatusLabel statusPanelLabel;
        protected internal System.Windows.Forms.TextBox searchTextBox;
        protected internal System.Windows.Forms.CheckBox searchCaseSensitiveCheckBox;
        protected internal System.Windows.Forms.CheckBox searchWholeWordCheckBox;
        protected internal System.Windows.Forms.Button searchFindNextButton;
        public System.Windows.Forms.TableLayoutPanel searchPanel;
        public System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.PictureBox searchCloseButton;
        protected internal System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Panel fileLockedPanel;
        private System.Windows.Forms.Label fileLockedLabel;
        private System.Windows.Forms.PictureBox fileLockedShowKey;
        private System.Windows.Forms.Button fileLockedOkButton;
        private System.Windows.Forms.Button fileLockedCloseButton;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopMainMenu;
        private System.Windows.Forms.PictureBox alwaysOnTopToolbarButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem showTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem exitTrayMenu;
        private System.Windows.Forms.Label encryptionKeyPlaceholder;
        protected internal System.Windows.Forms.TextBox fileLockedKeyTextBox;
        protected internal System.Windows.Forms.Panel richTextBoxPanel;
    }
}
