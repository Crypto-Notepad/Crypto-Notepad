namespace Crypto_Notepad
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.editorFontColorLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.editorTabPage = new System.Windows.Forms.TabPage();
            this.linksComboBox = new System.Windows.Forms.ComboBox();
            this.linksLabel = new System.Windows.Forms.Label();
            this.FontButton = new System.Windows.Forms.Button();
            this.paddingLeftTextBox = new System.Windows.Forms.TextBox();
            this.paddingLeftLabel = new System.Windows.Forms.Label();
            this.insKeyComboBox = new System.Windows.Forms.ComboBox();
            this.editorBGColorLabel = new System.Windows.Forms.Label();
            this.insKeyLabel = new System.Windows.Forms.Label();
            this.editorBGColor = new System.Windows.Forms.Panel();
            this.editorFontColor = new System.Windows.Forms.Panel();
            this.applicationTabPage = new System.Windows.Forms.TabPage();
            this.mainMenuCheckBox = new System.Windows.Forms.CheckBox();
            this.menuIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.updatesCheckBox = new System.Windows.Forms.CheckBox();
            this.autoLockCheckBox = new System.Windows.Forms.CheckBox();
            this.integrationTabPage = new System.Windows.Forms.TabPage();
            this.integrateCheckBox = new System.Windows.Forms.CheckBox();
            this.associateCheckBox = new System.Windows.Forms.CheckBox();
            this.sendToCheckBox = new System.Windows.Forms.CheckBox();
            this.encryptionTabPage = new System.Windows.Forms.TabPage();
            this.pwdIterationsTextBox = new System.Windows.Forms.TextBox();
            this.hashComboBox = new System.Windows.Forms.ComboBox();
            this.pwdIterationsLabel = new System.Windows.Forms.Label();
            this.keySizeLabel = new System.Windows.Forms.Label();
            this.hashLabel = new System.Windows.Forms.Label();
            this.keySizeComboBox = new System.Windows.Forms.ComboBox();
            this.lineNumbersTabPage = new System.Windows.Forms.TabPage();
            this.GLStyleComboBox = new System.Windows.Forms.ComboBox();
            this.LNVisibleLabel = new System.Windows.Forms.Label();
            this.GLStyleLabel = new System.Windows.Forms.Label();
            this.LNBackgroundColor = new System.Windows.Forms.Label();
            this.LNFontColorLabel = new System.Windows.Forms.Label();
            this.GLColorLabel = new System.Windows.Forms.Label();
            this.GLShowLabel = new System.Windows.Forms.Label();
            this.BLShowLabel = new System.Windows.Forms.Label();
            this.BLStyleLabel = new System.Windows.Forms.Label();
            this.BLColorLabel = new System.Windows.Forms.Label();
            this.GLColor = new System.Windows.Forms.Panel();
            this.GLShowComboBox = new System.Windows.Forms.ComboBox();
            this.BLStyleComboBox = new System.Windows.Forms.ComboBox();
            this.LNVisibleComboBox = new System.Windows.Forms.ComboBox();
            this.LNBackColor = new System.Windows.Forms.Panel();
            this.LNFontColor = new System.Windows.Forms.Panel();
            this.BLShowСomboBox = new System.Windows.Forms.ComboBox();
            this.BLColor = new System.Windows.Forms.Panel();
            this.statusPanelTabPage = new System.Windows.Forms.TabPage();
            this.statusPanelVisible = new System.Windows.Forms.CheckBox();
            this.statusBackColor = new System.Windows.Forms.Panel();
            this.statusFontColor = new System.Windows.Forms.Panel();
            this.statusFontColorLabel = new System.Windows.Forms.Label();
            this.statusBackColorLabel = new System.Windows.Forms.Label();
            this.toolbarTabPage = new System.Windows.Forms.TabPage();
            this.toolbarOldIcons = new System.Windows.Forms.CheckBox();
            this.toolbarBorder = new System.Windows.Forms.CheckBox();
            this.toolbarBackColor = new System.Windows.Forms.Panel();
            this.toolbarBackColorLabel = new System.Windows.Forms.Label();
            this.toolbarVisible = new System.Windows.Forms.CheckBox();
            this.searchPanelTabPage = new System.Windows.Forms.TabPage();
            this.searchFontColor = new System.Windows.Forms.Panel();
            this.searchBackColor = new System.Windows.Forms.Panel();
            this.searchFontColorLabel = new System.Windows.Forms.Label();
            this.searchBackColorLabel = new System.Windows.Forms.Label();
            this.settingsNav = new System.Windows.Forms.ListBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.settingsTabControl.SuspendLayout();
            this.editorTabPage.SuspendLayout();
            this.applicationTabPage.SuspendLayout();
            this.integrationTabPage.SuspendLayout();
            this.encryptionTabPage.SuspendLayout();
            this.lineNumbersTabPage.SuspendLayout();
            this.statusPanelTabPage.SuspendLayout();
            this.toolbarTabPage.SuspendLayout();
            this.searchPanelTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorFontColorLabel
            // 
            this.editorFontColorLabel.Location = new System.Drawing.Point(6, 4);
            this.editorFontColorLabel.Name = "editorFontColorLabel";
            this.editorFontColorLabel.Size = new System.Drawing.Size(83, 21);
            this.editorFontColorLabel.TabIndex = 0;
            this.editorFontColorLabel.Text = "Font color";
            this.editorFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.editorTabPage);
            this.settingsTabControl.Controls.Add(this.applicationTabPage);
            this.settingsTabControl.Controls.Add(this.integrationTabPage);
            this.settingsTabControl.Controls.Add(this.encryptionTabPage);
            this.settingsTabControl.Controls.Add(this.lineNumbersTabPage);
            this.settingsTabControl.Controls.Add(this.statusPanelTabPage);
            this.settingsTabControl.Controls.Add(this.toolbarTabPage);
            this.settingsTabControl.Controls.Add(this.searchPanelTabPage);
            this.settingsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsTabControl.Location = new System.Drawing.Point(105, -2);
            this.settingsTabControl.Multiline = true;
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(252, 301);
            this.settingsTabControl.TabIndex = 4;
            this.settingsTabControl.SelectedIndexChanged += new System.EventHandler(this.SettingsTabControl_SelectedIndexChanged);
            // 
            // editorTabPage
            // 
            this.editorTabPage.AutoScroll = true;
            this.editorTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.editorTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorTabPage.Controls.Add(this.linksComboBox);
            this.editorTabPage.Controls.Add(this.linksLabel);
            this.editorTabPage.Controls.Add(this.FontButton);
            this.editorTabPage.Controls.Add(this.paddingLeftTextBox);
            this.editorTabPage.Controls.Add(this.paddingLeftLabel);
            this.editorTabPage.Controls.Add(this.insKeyComboBox);
            this.editorTabPage.Controls.Add(this.editorBGColorLabel);
            this.editorTabPage.Controls.Add(this.insKeyLabel);
            this.editorTabPage.Controls.Add(this.editorBGColor);
            this.editorTabPage.Controls.Add(this.editorFontColorLabel);
            this.editorTabPage.Controls.Add(this.editorFontColor);
            this.editorTabPage.Location = new System.Drawing.Point(4, 44);
            this.editorTabPage.Name = "editorTabPage";
            this.editorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.editorTabPage.Size = new System.Drawing.Size(244, 253);
            this.editorTabPage.TabIndex = 0;
            this.editorTabPage.Text = "edt";
            // 
            // linksComboBox
            // 
            this.linksComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "openLinks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.linksComboBox.FormattingEnabled = true;
            this.linksComboBox.Items.AddRange(new object[] {
            "LMB Click",
            "Shift+LMB",
            "Control+LMB"});
            this.linksComboBox.Location = new System.Drawing.Point(132, 113);
            this.linksComboBox.Name = "linksComboBox";
            this.linksComboBox.Size = new System.Drawing.Size(100, 23);
            this.linksComboBox.TabIndex = 19;
            this.linksComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.openLinks;
            // 
            // linksLabel
            // 
            this.linksLabel.AutoSize = true;
            this.linksLabel.Location = new System.Drawing.Point(6, 116);
            this.linksLabel.Name = "linksLabel";
            this.linksLabel.Size = new System.Drawing.Size(90, 15);
            this.linksLabel.TabIndex = 18;
            this.linksLabel.Text = "Open links with";
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(9, 142);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(223, 23);
            this.FontButton.TabIndex = 17;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // paddingLeftTextBox
            // 
            this.paddingLeftTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "editorPaddingLeft", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.paddingLeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paddingLeftTextBox.Location = new System.Drawing.Point(132, 87);
            this.paddingLeftTextBox.Name = "paddingLeftTextBox";
            this.paddingLeftTextBox.Size = new System.Drawing.Size(100, 20);
            this.paddingLeftTextBox.TabIndex = 16;
            this.paddingLeftTextBox.Text = global::Crypto_Notepad.Properties.Settings.Default.editorPaddingLeft;
            this.paddingLeftTextBox.Click += new System.EventHandler(this.PaddingLeftTextBox_Click);
            this.paddingLeftTextBox.TextChanged += new System.EventHandler(this.PaddingLeftTextBox_TextChanged);
            this.paddingLeftTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaddingLeftTextBox_KeyPress);
            // 
            // paddingLeftLabel
            // 
            this.paddingLeftLabel.AutoSize = true;
            this.paddingLeftLabel.Location = new System.Drawing.Point(6, 88);
            this.paddingLeftLabel.Name = "paddingLeftLabel";
            this.paddingLeftLabel.Size = new System.Drawing.Size(73, 15);
            this.paddingLeftLabel.TabIndex = 15;
            this.paddingLeftLabel.Text = "Padding-left";
            // 
            // insKeyComboBox
            // 
            this.insKeyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "insKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.insKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.insKeyComboBox.FormattingEnabled = true;
            this.insKeyComboBox.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.insKeyComboBox.Location = new System.Drawing.Point(132, 58);
            this.insKeyComboBox.Name = "insKeyComboBox";
            this.insKeyComboBox.Size = new System.Drawing.Size(100, 23);
            this.insKeyComboBox.TabIndex = 14;
            this.insKeyComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.insKey;
            this.insKeyComboBox.DropDownClosed += new System.EventHandler(this.InsKeyComboBox_DropDownClosed);
            // 
            // editorBGColorLabel
            // 
            this.editorBGColorLabel.Location = new System.Drawing.Point(6, 31);
            this.editorBGColorLabel.Name = "editorBGColorLabel";
            this.editorBGColorLabel.Size = new System.Drawing.Size(103, 21);
            this.editorBGColorLabel.TabIndex = 10;
            this.editorBGColorLabel.Text = "Background color";
            this.editorBGColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // insKeyLabel
            // 
            this.insKeyLabel.AutoSize = true;
            this.insKeyLabel.Location = new System.Drawing.Point(6, 61);
            this.insKeyLabel.Name = "insKeyLabel";
            this.insKeyLabel.Size = new System.Drawing.Size(58, 15);
            this.insKeyLabel.TabIndex = 13;
            this.insKeyLabel.Text = "Insert key";
            // 
            // editorBGColor
            // 
            this.editorBGColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.editorBackColor;
            this.editorBGColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorBGColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editorBGColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "editorBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editorBGColor.Location = new System.Drawing.Point(132, 31);
            this.editorBGColor.Name = "editorBGColor";
            this.editorBGColor.Size = new System.Drawing.Size(100, 21);
            this.editorBGColor.TabIndex = 8;
            this.editorBGColor.Click += new System.EventHandler(this.EditorBGColor_Click);
            // 
            // editorFontColor
            // 
            this.editorFontColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.editroFontColor;
            this.editorFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editorFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "editroFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.editorFontColor.Location = new System.Drawing.Point(132, 4);
            this.editorFontColor.Name = "editorFontColor";
            this.editorFontColor.Size = new System.Drawing.Size(100, 21);
            this.editorFontColor.TabIndex = 7;
            this.editorFontColor.Click += new System.EventHandler(this.EditorFontColor_Click);
            // 
            // applicationTabPage
            // 
            this.applicationTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.applicationTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.applicationTabPage.Controls.Add(this.mainMenuCheckBox);
            this.applicationTabPage.Controls.Add(this.menuIconsCheckBox);
            this.applicationTabPage.Controls.Add(this.updatesCheckBox);
            this.applicationTabPage.Controls.Add(this.autoLockCheckBox);
            this.applicationTabPage.Location = new System.Drawing.Point(4, 44);
            this.applicationTabPage.Name = "applicationTabPage";
            this.applicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.applicationTabPage.Size = new System.Drawing.Size(244, 253);
            this.applicationTabPage.TabIndex = 2;
            this.applicationTabPage.Text = "app";
            // 
            // mainMenuCheckBox
            // 
            this.mainMenuCheckBox.AutoSize = true;
            this.mainMenuCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.mainMenu;
            this.mainMenuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mainMenuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "mainMenu", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mainMenuCheckBox.Location = new System.Drawing.Point(7, 55);
            this.mainMenuCheckBox.Name = "mainMenuCheckBox";
            this.mainMenuCheckBox.Size = new System.Drawing.Size(89, 19);
            this.mainMenuCheckBox.TabIndex = 8;
            this.mainMenuCheckBox.Text = "Main menu";
            this.mainMenuCheckBox.UseVisualStyleBackColor = true;
            this.mainMenuCheckBox.Click += new System.EventHandler(this.MainMenuCheckBox_Click);
            // 
            // menuIconsCheckBox
            // 
            this.menuIconsCheckBox.AutoSize = true;
            this.menuIconsCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.menuIcons;
            this.menuIconsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "menuIcons", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.menuIconsCheckBox.Location = new System.Drawing.Point(7, 80);
            this.menuIconsCheckBox.Name = "menuIconsCheckBox";
            this.menuIconsCheckBox.Size = new System.Drawing.Size(90, 19);
            this.menuIconsCheckBox.TabIndex = 7;
            this.menuIconsCheckBox.Text = "Menu icons";
            this.menuIconsCheckBox.UseVisualStyleBackColor = true;
            this.menuIconsCheckBox.Click += new System.EventHandler(this.MenuIconsCheckBox_Click);
            // 
            // updatesCheckBox
            // 
            this.updatesCheckBox.AutoSize = true;
            this.updatesCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.autoCheckUpdate;
            this.updatesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updatesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "autoCheckUpdate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.updatesCheckBox.Location = new System.Drawing.Point(7, 30);
            this.updatesCheckBox.Name = "updatesCheckBox";
            this.updatesCheckBox.Size = new System.Drawing.Size(132, 19);
            this.updatesCheckBox.TabIndex = 1;
            this.updatesCheckBox.Text = "Auto check updates";
            this.updatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // autoLockCheckBox
            // 
            this.autoLockCheckBox.AutoSize = true;
            this.autoLockCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.autoLock;
            this.autoLockCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "autoLock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.autoLockCheckBox.Location = new System.Drawing.Point(7, 7);
            this.autoLockCheckBox.Name = "autoLockCheckBox";
            this.autoLockCheckBox.Size = new System.Drawing.Size(146, 19);
            this.autoLockCheckBox.TabIndex = 3;
            this.autoLockCheckBox.Text = "Auto lock on minimize";
            this.autoLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // integrationTabPage
            // 
            this.integrationTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.integrationTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.integrationTabPage.Controls.Add(this.integrateCheckBox);
            this.integrationTabPage.Controls.Add(this.associateCheckBox);
            this.integrationTabPage.Controls.Add(this.sendToCheckBox);
            this.integrationTabPage.Location = new System.Drawing.Point(4, 44);
            this.integrationTabPage.Name = "integrationTabPage";
            this.integrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.integrationTabPage.Size = new System.Drawing.Size(244, 253);
            this.integrationTabPage.TabIndex = 3;
            this.integrationTabPage.Text = "intgr";
            // 
            // integrateCheckBox
            // 
            this.integrateCheckBox.AutoSize = true;
            this.integrateCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.explorerIntegrate;
            this.integrateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "explorerIntegrate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.integrateCheckBox.Location = new System.Drawing.Point(7, 7);
            this.integrateCheckBox.Name = "integrateCheckBox";
            this.integrateCheckBox.Size = new System.Drawing.Size(227, 19);
            this.integrateCheckBox.TabIndex = 6;
            this.integrateCheckBox.Text = "Integrate with windows context menu";
            this.integrateCheckBox.UseVisualStyleBackColor = true;
            this.integrateCheckBox.Click += new System.EventHandler(this.IntegrateCheckBox_Click);
            // 
            // associateCheckBox
            // 
            this.associateCheckBox.AutoSize = true;
            this.associateCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.explorerAssociate;
            this.associateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "explorerAssociate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.associateCheckBox.Location = new System.Drawing.Point(7, 30);
            this.associateCheckBox.Name = "associateCheckBox";
            this.associateCheckBox.Size = new System.Drawing.Size(159, 19);
            this.associateCheckBox.TabIndex = 0;
            this.associateCheckBox.Text = "Associate with *.cnp files";
            this.associateCheckBox.UseVisualStyleBackColor = true;
            this.associateCheckBox.Click += new System.EventHandler(this.AssociateCheckBox_Click);
            // 
            // sendToCheckBox
            // 
            this.sendToCheckBox.AutoSize = true;
            this.sendToCheckBox.Checked = global::Crypto_Notepad.Properties.Settings.Default.sendTo;
            this.sendToCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "sendTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.sendToCheckBox.Location = new System.Drawing.Point(7, 53);
            this.sendToCheckBox.Name = "sendToCheckBox";
            this.sendToCheckBox.Size = new System.Drawing.Size(158, 19);
            this.sendToCheckBox.TabIndex = 5;
            this.sendToCheckBox.Text = "Show in \"Send to\" menu";
            this.sendToCheckBox.UseVisualStyleBackColor = true;
            this.sendToCheckBox.Click += new System.EventHandler(this.SendToCheckBox_Click);
            // 
            // encryptionTabPage
            // 
            this.encryptionTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.encryptionTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.encryptionTabPage.Controls.Add(this.pwdIterationsTextBox);
            this.encryptionTabPage.Controls.Add(this.hashComboBox);
            this.encryptionTabPage.Controls.Add(this.pwdIterationsLabel);
            this.encryptionTabPage.Controls.Add(this.keySizeLabel);
            this.encryptionTabPage.Controls.Add(this.hashLabel);
            this.encryptionTabPage.Controls.Add(this.keySizeComboBox);
            this.encryptionTabPage.Location = new System.Drawing.Point(4, 44);
            this.encryptionTabPage.Name = "encryptionTabPage";
            this.encryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionTabPage.Size = new System.Drawing.Size(244, 253);
            this.encryptionTabPage.TabIndex = 1;
            this.encryptionTabPage.Text = "enc";
            // 
            // pwdIterationsTextBox
            // 
            this.pwdIterationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "passwordIterations", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pwdIterationsTextBox.Location = new System.Drawing.Point(132, 62);
            this.pwdIterationsTextBox.Name = "pwdIterationsTextBox";
            this.pwdIterationsTextBox.Size = new System.Drawing.Size(100, 21);
            this.pwdIterationsTextBox.TabIndex = 7;
            this.pwdIterationsTextBox.Text = global::Crypto_Notepad.Properties.Settings.Default.PasswordIterations;
            this.pwdIterationsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PwdIterationsTextBox_KeyPress);
            this.pwdIterationsTextBox.Leave += new System.EventHandler(this.PwdIterationsTextBox_Leave);
            // 
            // hashComboBox
            // 
            this.hashComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "hashAlgorithm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashComboBox.FormattingEnabled = true;
            this.hashComboBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hashComboBox.Location = new System.Drawing.Point(132, 4);
            this.hashComboBox.Name = "hashComboBox";
            this.hashComboBox.Size = new System.Drawing.Size(100, 23);
            this.hashComboBox.TabIndex = 5;
            this.hashComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.HashAlgorithm;
            this.hashComboBox.DropDownClosed += new System.EventHandler(this.HashComboBox_DropDownClosed);
            // 
            // pwdIterationsLabel
            // 
            this.pwdIterationsLabel.AutoSize = true;
            this.pwdIterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pwdIterationsLabel.Location = new System.Drawing.Point(6, 65);
            this.pwdIterationsLabel.Name = "pwdIterationsLabel";
            this.pwdIterationsLabel.Size = new System.Drawing.Size(114, 15);
            this.pwdIterationsLabel.TabIndex = 6;
            this.pwdIterationsLabel.Text = "Password iterations";
            // 
            // keySizeLabel
            // 
            this.keySizeLabel.AutoSize = true;
            this.keySizeLabel.Location = new System.Drawing.Point(6, 36);
            this.keySizeLabel.Name = "keySizeLabel";
            this.keySizeLabel.Size = new System.Drawing.Size(52, 15);
            this.keySizeLabel.TabIndex = 1;
            this.keySizeLabel.Text = "Key size";
            // 
            // hashLabel
            // 
            this.hashLabel.AutoSize = true;
            this.hashLabel.Location = new System.Drawing.Point(6, 7);
            this.hashLabel.Name = "hashLabel";
            this.hashLabel.Size = new System.Drawing.Size(94, 15);
            this.hashLabel.TabIndex = 0;
            this.hashLabel.Text = "Hash algorithm ";
            // 
            // keySizeComboBox
            // 
            this.keySizeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "keySize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.keySizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keySizeComboBox.FormattingEnabled = true;
            this.keySizeComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.keySizeComboBox.Location = new System.Drawing.Point(132, 33);
            this.keySizeComboBox.Name = "keySizeComboBox";
            this.keySizeComboBox.Size = new System.Drawing.Size(100, 23);
            this.keySizeComboBox.TabIndex = 3;
            this.keySizeComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.KeySize;
            this.keySizeComboBox.DropDownClosed += new System.EventHandler(this.KeySizeComboBox_DropDownClosed);
            // 
            // lineNumbersTabPage
            // 
            this.lineNumbersTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.lineNumbersTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineNumbersTabPage.Controls.Add(this.GLStyleComboBox);
            this.lineNumbersTabPage.Controls.Add(this.LNVisibleLabel);
            this.lineNumbersTabPage.Controls.Add(this.GLStyleLabel);
            this.lineNumbersTabPage.Controls.Add(this.LNBackgroundColor);
            this.lineNumbersTabPage.Controls.Add(this.LNFontColorLabel);
            this.lineNumbersTabPage.Controls.Add(this.GLColorLabel);
            this.lineNumbersTabPage.Controls.Add(this.GLShowLabel);
            this.lineNumbersTabPage.Controls.Add(this.BLShowLabel);
            this.lineNumbersTabPage.Controls.Add(this.BLStyleLabel);
            this.lineNumbersTabPage.Controls.Add(this.BLColorLabel);
            this.lineNumbersTabPage.Controls.Add(this.GLColor);
            this.lineNumbersTabPage.Controls.Add(this.GLShowComboBox);
            this.lineNumbersTabPage.Controls.Add(this.BLStyleComboBox);
            this.lineNumbersTabPage.Controls.Add(this.LNVisibleComboBox);
            this.lineNumbersTabPage.Controls.Add(this.LNBackColor);
            this.lineNumbersTabPage.Controls.Add(this.LNFontColor);
            this.lineNumbersTabPage.Controls.Add(this.BLShowСomboBox);
            this.lineNumbersTabPage.Controls.Add(this.BLColor);
            this.lineNumbersTabPage.Location = new System.Drawing.Point(4, 44);
            this.lineNumbersTabPage.Name = "lineNumbersTabPage";
            this.lineNumbersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.lineNumbersTabPage.Size = new System.Drawing.Size(244, 253);
            this.lineNumbersTabPage.TabIndex = 4;
            this.lineNumbersTabPage.Text = "ln";
            // 
            // GLStyleComboBox
            // 
            this.GLStyleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "glStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GLStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GLStyleComboBox.FormattingEnabled = true;
            this.GLStyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.GLStyleComboBox.Location = new System.Drawing.Point(132, 228);
            this.GLStyleComboBox.Name = "GLStyleComboBox";
            this.GLStyleComboBox.Size = new System.Drawing.Size(100, 23);
            this.GLStyleComboBox.TabIndex = 26;
            this.GLStyleComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.glStyle;
            this.GLStyleComboBox.DropDownClosed += new System.EventHandler(this.GLStyleComboBox_DropDownClosed);
            // 
            // LNVisibleLabel
            // 
            this.LNVisibleLabel.AutoSize = true;
            this.LNVisibleLabel.Location = new System.Drawing.Point(6, 7);
            this.LNVisibleLabel.Name = "LNVisibleLabel";
            this.LNVisibleLabel.Size = new System.Drawing.Size(43, 15);
            this.LNVisibleLabel.TabIndex = 0;
            this.LNVisibleLabel.Text = "Visible";
            // 
            // GLStyleLabel
            // 
            this.GLStyleLabel.AutoSize = true;
            this.GLStyleLabel.Location = new System.Drawing.Point(6, 231);
            this.GLStyleLabel.Name = "GLStyleLabel";
            this.GLStyleLabel.Size = new System.Drawing.Size(86, 15);
            this.GLStyleLabel.TabIndex = 25;
            this.GLStyleLabel.Text = "Grid lines style";
            // 
            // LNBackgroundColor
            // 
            this.LNBackgroundColor.Location = new System.Drawing.Point(6, 33);
            this.LNBackgroundColor.Name = "LNBackgroundColor";
            this.LNBackgroundColor.Size = new System.Drawing.Size(103, 21);
            this.LNBackgroundColor.TabIndex = 1;
            this.LNBackgroundColor.Text = "Background color";
            this.LNBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LNFontColorLabel
            // 
            this.LNFontColorLabel.Location = new System.Drawing.Point(6, 60);
            this.LNFontColorLabel.Name = "LNFontColorLabel";
            this.LNFontColorLabel.Size = new System.Drawing.Size(61, 21);
            this.LNFontColorLabel.TabIndex = 2;
            this.LNFontColorLabel.Text = "Font color";
            this.LNFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GLColorLabel
            // 
            this.GLColorLabel.Location = new System.Drawing.Point(6, 201);
            this.GLColorLabel.Name = "GLColorLabel";
            this.GLColorLabel.Size = new System.Drawing.Size(89, 21);
            this.GLColorLabel.TabIndex = 23;
            this.GLColorLabel.Text = "Grid lines color";
            this.GLColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GLShowLabel
            // 
            this.GLShowLabel.AutoSize = true;
            this.GLShowLabel.Location = new System.Drawing.Point(6, 175);
            this.GLShowLabel.Name = "GLShowLabel";
            this.GLShowLabel.Size = new System.Drawing.Size(91, 15);
            this.GLShowLabel.TabIndex = 21;
            this.GLShowLabel.Text = "Show grid lines";
            // 
            // BLShowLabel
            // 
            this.BLShowLabel.AutoSize = true;
            this.BLShowLabel.Location = new System.Drawing.Point(6, 90);
            this.BLShowLabel.Name = "BLShowLabel";
            this.BLShowLabel.Size = new System.Drawing.Size(106, 15);
            this.BLShowLabel.TabIndex = 15;
            this.BLShowLabel.Text = "Show border lines";
            // 
            // BLStyleLabel
            // 
            this.BLStyleLabel.AutoSize = true;
            this.BLStyleLabel.Location = new System.Drawing.Point(6, 146);
            this.BLStyleLabel.Name = "BLStyleLabel";
            this.BLStyleLabel.Size = new System.Drawing.Size(100, 15);
            this.BLStyleLabel.TabIndex = 19;
            this.BLStyleLabel.Text = "Border lines style";
            // 
            // BLColorLabel
            // 
            this.BLColorLabel.Location = new System.Drawing.Point(6, 116);
            this.BLColorLabel.Name = "BLColorLabel";
            this.BLColorLabel.Size = new System.Drawing.Size(103, 21);
            this.BLColorLabel.TabIndex = 17;
            this.BLColorLabel.Text = "Border lines color";
            this.BLColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GLColor
            // 
            this.GLColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.glColor;
            this.GLColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GLColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GLColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "glColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GLColor.Location = new System.Drawing.Point(132, 201);
            this.GLColor.Name = "GLColor";
            this.GLColor.Size = new System.Drawing.Size(100, 21);
            this.GLColor.TabIndex = 24;
            this.GLColor.Click += new System.EventHandler(this.GLColor_Click);
            // 
            // GLShowComboBox
            // 
            this.GLShowComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "glShow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GLShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GLShowComboBox.FormattingEnabled = true;
            this.GLShowComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.GLShowComboBox.Location = new System.Drawing.Point(132, 172);
            this.GLShowComboBox.Name = "GLShowComboBox";
            this.GLShowComboBox.Size = new System.Drawing.Size(100, 23);
            this.GLShowComboBox.TabIndex = 22;
            this.GLShowComboBox.Tag = "False";
            this.GLShowComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.glShow;
            this.GLShowComboBox.DropDownClosed += new System.EventHandler(this.GLShowComboBox_DropDownClosed);
            // 
            // BLStyleComboBox
            // 
            this.BLStyleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "blStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BLStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BLStyleComboBox.FormattingEnabled = true;
            this.BLStyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.BLStyleComboBox.Location = new System.Drawing.Point(132, 143);
            this.BLStyleComboBox.Name = "BLStyleComboBox";
            this.BLStyleComboBox.Size = new System.Drawing.Size(100, 23);
            this.BLStyleComboBox.TabIndex = 20;
            this.BLStyleComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.blStyle;
            this.BLStyleComboBox.DropDownClosed += new System.EventHandler(this.BLStyleComboBox_DropDownClosed);
            // 
            // LNVisibleComboBox
            // 
            this.LNVisibleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "lnVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LNVisibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LNVisibleComboBox.FormattingEnabled = true;
            this.LNVisibleComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.LNVisibleComboBox.Location = new System.Drawing.Point(132, 4);
            this.LNVisibleComboBox.Name = "LNVisibleComboBox";
            this.LNVisibleComboBox.Size = new System.Drawing.Size(100, 23);
            this.LNVisibleComboBox.TabIndex = 3;
            this.LNVisibleComboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.lnVisible;
            this.LNVisibleComboBox.DropDownClosed += new System.EventHandler(this.LNVisibleComboBox_DropDownClosed);
            // 
            // LNBackColor
            // 
            this.LNBackColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.lnBackColor;
            this.LNBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LNBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "lnBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LNBackColor.Location = new System.Drawing.Point(132, 33);
            this.LNBackColor.Name = "LNBackColor";
            this.LNBackColor.Size = new System.Drawing.Size(100, 21);
            this.LNBackColor.TabIndex = 13;
            this.LNBackColor.Click += new System.EventHandler(this.LNBackColor_Click);
            // 
            // LNFontColor
            // 
            this.LNFontColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.lnFontColor;
            this.LNFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LNFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "lnFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LNFontColor.Location = new System.Drawing.Point(132, 60);
            this.LNFontColor.Name = "LNFontColor";
            this.LNFontColor.Size = new System.Drawing.Size(100, 21);
            this.LNFontColor.TabIndex = 14;
            this.LNFontColor.Click += new System.EventHandler(this.LNFontColor_Click);
            // 
            // BLShowСomboBox
            // 
            this.BLShowСomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Crypto_Notepad.Properties.Settings.Default, "blShow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BLShowСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BLShowСomboBox.FormattingEnabled = true;
            this.BLShowСomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.BLShowСomboBox.Location = new System.Drawing.Point(132, 87);
            this.BLShowСomboBox.Name = "BLShowСomboBox";
            this.BLShowСomboBox.Size = new System.Drawing.Size(100, 23);
            this.BLShowСomboBox.TabIndex = 16;
            this.BLShowСomboBox.Text = global::Crypto_Notepad.Properties.Settings.Default.blShow;
            this.BLShowСomboBox.DropDownClosed += new System.EventHandler(this.BLShowСomboBox_DropDownClosed);
            // 
            // BLColor
            // 
            this.BLColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.blColor;
            this.BLColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BLColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "blColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BLColor.Location = new System.Drawing.Point(132, 116);
            this.BLColor.Name = "BLColor";
            this.BLColor.Size = new System.Drawing.Size(100, 21);
            this.BLColor.TabIndex = 18;
            this.BLColor.Click += new System.EventHandler(this.BLColor_Click);
            // 
            // statusPanelTabPage
            // 
            this.statusPanelTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.statusPanelTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanelTabPage.Controls.Add(this.statusPanelVisible);
            this.statusPanelTabPage.Controls.Add(this.statusBackColor);
            this.statusPanelTabPage.Controls.Add(this.statusFontColor);
            this.statusPanelTabPage.Controls.Add(this.statusFontColorLabel);
            this.statusPanelTabPage.Controls.Add(this.statusBackColorLabel);
            this.statusPanelTabPage.Location = new System.Drawing.Point(4, 44);
            this.statusPanelTabPage.Name = "statusPanelTabPage";
            this.statusPanelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusPanelTabPage.Size = new System.Drawing.Size(244, 253);
            this.statusPanelTabPage.TabIndex = 5;
            this.statusPanelTabPage.Text = "stat";
            // 
            // statusPanelVisible
            // 
            this.statusPanelVisible.AutoSize = true;
            this.statusPanelVisible.Checked = global::Crypto_Notepad.Properties.Settings.Default.statusPanel;
            this.statusPanelVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusPanelVisible.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "statusPanel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusPanelVisible.Location = new System.Drawing.Point(9, 66);
            this.statusPanelVisible.Name = "statusPanelVisible";
            this.statusPanelVisible.Size = new System.Drawing.Size(62, 19);
            this.statusPanelVisible.TabIndex = 2;
            this.statusPanelVisible.Text = "Visible";
            this.statusPanelVisible.UseVisualStyleBackColor = true;
            this.statusPanelVisible.Click += new System.EventHandler(this.StatusPanelVisible_Click);
            // 
            // statusBackColor
            // 
            this.statusBackColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.statusPanelBackColor;
            this.statusBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "statusPanelBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusBackColor.Location = new System.Drawing.Point(132, 4);
            this.statusBackColor.Name = "statusBackColor";
            this.statusBackColor.Size = new System.Drawing.Size(100, 21);
            this.statusBackColor.TabIndex = 3;
            this.statusBackColor.Click += new System.EventHandler(this.StatusBackColor_Click);
            // 
            // statusFontColor
            // 
            this.statusFontColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.statusPanelFontColor;
            this.statusFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "statusPanelFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusFontColor.Location = new System.Drawing.Point(132, 31);
            this.statusFontColor.Name = "statusFontColor";
            this.statusFontColor.Size = new System.Drawing.Size(100, 21);
            this.statusFontColor.TabIndex = 3;
            this.statusFontColor.Click += new System.EventHandler(this.StatusFontColor_Click);
            // 
            // statusFontColorLabel
            // 
            this.statusFontColorLabel.Location = new System.Drawing.Point(6, 31);
            this.statusFontColorLabel.Name = "statusFontColorLabel";
            this.statusFontColorLabel.Size = new System.Drawing.Size(96, 21);
            this.statusFontColorLabel.TabIndex = 1;
            this.statusFontColorLabel.Text = "Font color";
            this.statusFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusBackColorLabel
            // 
            this.statusBackColorLabel.Location = new System.Drawing.Point(6, 4);
            this.statusBackColorLabel.Name = "statusBackColorLabel";
            this.statusBackColorLabel.Size = new System.Drawing.Size(120, 21);
            this.statusBackColorLabel.TabIndex = 0;
            this.statusBackColorLabel.Text = "Background color";
            this.statusBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolbarTabPage
            // 
            this.toolbarTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.toolbarTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarTabPage.Controls.Add(this.toolbarOldIcons);
            this.toolbarTabPage.Controls.Add(this.toolbarBorder);
            this.toolbarTabPage.Controls.Add(this.toolbarBackColor);
            this.toolbarTabPage.Controls.Add(this.toolbarBackColorLabel);
            this.toolbarTabPage.Controls.Add(this.toolbarVisible);
            this.toolbarTabPage.Location = new System.Drawing.Point(4, 44);
            this.toolbarTabPage.Name = "toolbarTabPage";
            this.toolbarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.toolbarTabPage.Size = new System.Drawing.Size(244, 253);
            this.toolbarTabPage.TabIndex = 6;
            this.toolbarTabPage.Text = "tb";
            // 
            // toolbarOldIcons
            // 
            this.toolbarOldIcons.AutoSize = true;
            this.toolbarOldIcons.Checked = global::Crypto_Notepad.Properties.Settings.Default.oldToolbarIcons;
            this.toolbarOldIcons.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "oldToolbarIcons", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolbarOldIcons.Location = new System.Drawing.Point(9, 91);
            this.toolbarOldIcons.Name = "toolbarOldIcons";
            this.toolbarOldIcons.Size = new System.Drawing.Size(77, 19);
            this.toolbarOldIcons.TabIndex = 13;
            this.toolbarOldIcons.Text = "Old icons";
            this.toolbarOldIcons.UseVisualStyleBackColor = true;
            this.toolbarOldIcons.Click += new System.EventHandler(this.ToolbarOldIcons_Click);
            // 
            // toolbarBorder
            // 
            this.toolbarBorder.AutoSize = true;
            this.toolbarBorder.Checked = global::Crypto_Notepad.Properties.Settings.Default.toolbarBorder;
            this.toolbarBorder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "toolbarBorder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolbarBorder.Location = new System.Drawing.Point(9, 41);
            this.toolbarBorder.Name = "toolbarBorder";
            this.toolbarBorder.Size = new System.Drawing.Size(63, 19);
            this.toolbarBorder.TabIndex = 12;
            this.toolbarBorder.Text = "Border";
            this.toolbarBorder.UseVisualStyleBackColor = true;
            this.toolbarBorder.Click += new System.EventHandler(this.ToolbarBorder_Click);
            // 
            // toolbarBackColor
            // 
            this.toolbarBackColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.toolbarBackColor;
            this.toolbarBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbarBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolbarBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "toolbarBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolbarBackColor.Location = new System.Drawing.Point(132, 4);
            this.toolbarBackColor.Name = "toolbarBackColor";
            this.toolbarBackColor.Size = new System.Drawing.Size(100, 21);
            this.toolbarBackColor.TabIndex = 11;
            this.toolbarBackColor.Click += new System.EventHandler(this.ToolbarBackColor_Click);
            // 
            // toolbarBackColorLabel
            // 
            this.toolbarBackColorLabel.Location = new System.Drawing.Point(6, 4);
            this.toolbarBackColorLabel.Name = "toolbarBackColorLabel";
            this.toolbarBackColorLabel.Size = new System.Drawing.Size(120, 21);
            this.toolbarBackColorLabel.TabIndex = 9;
            this.toolbarBackColorLabel.Text = "Background color";
            this.toolbarBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolbarVisible
            // 
            this.toolbarVisible.AutoSize = true;
            this.toolbarVisible.Checked = global::Crypto_Notepad.Properties.Settings.Default.showToolbar;
            this.toolbarVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolbarVisible.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Crypto_Notepad.Properties.Settings.Default, "showToolbar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolbarVisible.Location = new System.Drawing.Point(9, 66);
            this.toolbarVisible.Name = "toolbarVisible";
            this.toolbarVisible.Size = new System.Drawing.Size(62, 19);
            this.toolbarVisible.TabIndex = 2;
            this.toolbarVisible.Text = "Visible";
            this.toolbarVisible.UseVisualStyleBackColor = true;
            this.toolbarVisible.Click += new System.EventHandler(this.ToolbarVisible_Click);
            // 
            // searchPanelTabPage
            // 
            this.searchPanelTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.searchPanelTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanelTabPage.Controls.Add(this.searchFontColor);
            this.searchPanelTabPage.Controls.Add(this.searchBackColor);
            this.searchPanelTabPage.Controls.Add(this.searchFontColorLabel);
            this.searchPanelTabPage.Controls.Add(this.searchBackColorLabel);
            this.searchPanelTabPage.Location = new System.Drawing.Point(4, 44);
            this.searchPanelTabPage.Name = "searchPanelTabPage";
            this.searchPanelTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPanelTabPage.Size = new System.Drawing.Size(244, 253);
            this.searchPanelTabPage.TabIndex = 7;
            this.searchPanelTabPage.Text = "srch";
            // 
            // searchFontColor
            // 
            this.searchFontColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.searchPanelFontColor;
            this.searchFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchFontColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "searchPanelFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchFontColor.Location = new System.Drawing.Point(132, 31);
            this.searchFontColor.Name = "searchFontColor";
            this.searchFontColor.Size = new System.Drawing.Size(100, 21);
            this.searchFontColor.TabIndex = 3;
            this.searchFontColor.Click += new System.EventHandler(this.SearchFontColor_Click);
            // 
            // searchBackColor
            // 
            this.searchBackColor.BackColor = global::Crypto_Notepad.Properties.Settings.Default.searchPanelBackColor;
            this.searchBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBackColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::Crypto_Notepad.Properties.Settings.Default, "searchPanelBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.searchBackColor.Location = new System.Drawing.Point(132, 4);
            this.searchBackColor.Name = "searchBackColor";
            this.searchBackColor.Size = new System.Drawing.Size(100, 21);
            this.searchBackColor.TabIndex = 2;
            this.searchBackColor.Click += new System.EventHandler(this.SearchBackColor_Click);
            // 
            // searchFontColorLabel
            // 
            this.searchFontColorLabel.Location = new System.Drawing.Point(6, 31);
            this.searchFontColorLabel.Name = "searchFontColorLabel";
            this.searchFontColorLabel.Size = new System.Drawing.Size(87, 21);
            this.searchFontColorLabel.TabIndex = 1;
            this.searchFontColorLabel.Text = "Font color";
            this.searchFontColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBackColorLabel
            // 
            this.searchBackColorLabel.Location = new System.Drawing.Point(6, 4);
            this.searchBackColorLabel.Name = "searchBackColorLabel";
            this.searchBackColorLabel.Size = new System.Drawing.Size(120, 21);
            this.searchBackColorLabel.TabIndex = 0;
            this.searchBackColorLabel.Text = "Background color";
            this.searchBackColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsNav
            // 
            this.settingsNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsNav.FormattingEnabled = true;
            this.settingsNav.ItemHeight = 16;
            this.settingsNav.Items.AddRange(new object[] {
            "Editor",
            "Line Numbers",
            "Status Panel",
            "Toolbar",
            "Application",
            "Search Panel",
            "Integration",
            "Encryption"});
            this.settingsNav.Location = new System.Drawing.Point(3, 3);
            this.settingsNav.Name = "settingsNav";
            this.settingsNav.Size = new System.Drawing.Size(102, 292);
            this.settingsNav.TabIndex = 6;
            this.settingsNav.Click += new System.EventHandler(this.SettingsNav_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowSimulations = false;
            this.fontDialog.AllowVectorFonts = false;
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.Font = global::Crypto_Notepad.Properties.Settings.Default.editorFont;
            this.fontDialog.FontMustExist = true;
            this.fontDialog.MaxSize = 72;
            this.fontDialog.MinSize = 8;
            this.fontDialog.ShowApply = true;
            this.fontDialog.ShowEffects = false;
            this.fontDialog.Apply += new System.EventHandler(this.FontDialog_Apply);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 299);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.settingsNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.settingsTabControl.ResumeLayout(false);
            this.editorTabPage.ResumeLayout(false);
            this.editorTabPage.PerformLayout();
            this.applicationTabPage.ResumeLayout(false);
            this.applicationTabPage.PerformLayout();
            this.integrationTabPage.ResumeLayout(false);
            this.integrationTabPage.PerformLayout();
            this.encryptionTabPage.ResumeLayout(false);
            this.encryptionTabPage.PerformLayout();
            this.lineNumbersTabPage.ResumeLayout(false);
            this.lineNumbersTabPage.PerformLayout();
            this.statusPanelTabPage.ResumeLayout(false);
            this.statusPanelTabPage.PerformLayout();
            this.toolbarTabPage.ResumeLayout(false);
            this.toolbarTabPage.PerformLayout();
            this.searchPanelTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label editorFontColorLabel;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage editorTabPage;
        private System.Windows.Forms.TabPage encryptionTabPage;
        private System.Windows.Forms.TabPage applicationTabPage;
        private System.Windows.Forms.CheckBox associateCheckBox;
        private System.Windows.Forms.CheckBox updatesCheckBox;
        private System.Windows.Forms.Panel editorFontColor;
        private System.Windows.Forms.Panel editorBGColor;
        private System.Windows.Forms.Label editorBGColorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox keySizeComboBox;
        private System.Windows.Forms.Label keySizeLabel;
        private System.Windows.Forms.Label hashLabel;
        private System.Windows.Forms.ComboBox hashComboBox;
        private System.Windows.Forms.TextBox pwdIterationsTextBox;
        private System.Windows.Forms.Label pwdIterationsLabel;
        private System.Windows.Forms.CheckBox toolbarVisible;
        private System.Windows.Forms.CheckBox autoLockCheckBox;
        private System.Windows.Forms.CheckBox sendToCheckBox;
        private System.Windows.Forms.CheckBox integrateCheckBox;
        private System.Windows.Forms.CheckBox menuIconsCheckBox;
        private System.Windows.Forms.TabPage integrationTabPage;
        private System.Windows.Forms.Label LNFontColorLabel;
        private System.Windows.Forms.Label LNBackgroundColor;
        private System.Windows.Forms.Label LNVisibleLabel;
        private System.Windows.Forms.ComboBox LNVisibleComboBox;
        private System.Windows.Forms.Panel LNFontColor;
        private System.Windows.Forms.Panel LNBackColor;
        private System.Windows.Forms.ComboBox BLStyleComboBox;
        private System.Windows.Forms.Label BLStyleLabel;
        private System.Windows.Forms.Panel BLColor;
        private System.Windows.Forms.Label BLColorLabel;
        private System.Windows.Forms.ComboBox BLShowСomboBox;
        private System.Windows.Forms.Label BLShowLabel;
        private System.Windows.Forms.ComboBox GLStyleComboBox;
        private System.Windows.Forms.Label GLStyleLabel;
        private System.Windows.Forms.Panel GLColor;
        private System.Windows.Forms.Label GLColorLabel;
        private System.Windows.Forms.ComboBox GLShowComboBox;
        private System.Windows.Forms.Label GLShowLabel;
        private System.Windows.Forms.ComboBox insKeyComboBox;
        private System.Windows.Forms.Label insKeyLabel;
        private System.Windows.Forms.TextBox paddingLeftTextBox;
        private System.Windows.Forms.Label paddingLeftLabel;
        private System.Windows.Forms.ListBox settingsNav;
        private System.Windows.Forms.TabPage lineNumbersTabPage;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TabPage statusPanelTabPage;
        private System.Windows.Forms.TabPage toolbarTabPage;
        private System.Windows.Forms.TabPage searchPanelTabPage;
        private System.Windows.Forms.Label searchFontColorLabel;
        private System.Windows.Forms.Label searchBackColorLabel;
        private System.Windows.Forms.CheckBox statusPanelVisible;
        private System.Windows.Forms.Label statusFontColorLabel;
        private System.Windows.Forms.Label statusBackColorLabel;
        private System.Windows.Forms.Panel searchBackColor;
        private System.Windows.Forms.Panel statusBackColor;
        private System.Windows.Forms.Panel statusFontColor;
        private System.Windows.Forms.Panel searchFontColor;
        private System.Windows.Forms.Panel toolbarBackColor;
        private System.Windows.Forms.Label toolbarBackColorLabel;
        private System.Windows.Forms.CheckBox toolbarBorder;
        private System.Windows.Forms.ComboBox linksComboBox;
        private System.Windows.Forms.Label linksLabel;
        private System.Windows.Forms.CheckBox mainMenuCheckBox;
        private System.Windows.Forms.CheckBox toolbarOldIcons;
    }
}