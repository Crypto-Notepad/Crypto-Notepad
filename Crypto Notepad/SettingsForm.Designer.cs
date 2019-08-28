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
            this.FontColorLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.FontNameLabel = new System.Windows.Forms.Label();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.LineNumbersGroupBox = new System.Windows.Forms.GroupBox();
            this.GLStyleComboBox = new System.Windows.Forms.ComboBox();
            this.GLStyleLabel = new System.Windows.Forms.Label();
            this.GLColorPanel = new System.Windows.Forms.Panel();
            this.GLColorLabel = new System.Windows.Forms.Label();
            this.GLShowComboBox = new System.Windows.Forms.ComboBox();
            this.GLShowLabel = new System.Windows.Forms.Label();
            this.BLStyleComboBox = new System.Windows.Forms.ComboBox();
            this.BLStyleLabel = new System.Windows.Forms.Label();
            this.BLColorPanel = new System.Windows.Forms.Panel();
            this.BLColorLabel = new System.Windows.Forms.Label();
            this.BLShowСomboBox = new System.Windows.Forms.ComboBox();
            this.BLShowLabel = new System.Windows.Forms.Label();
            this.LNFontColorPanel = new System.Windows.Forms.Panel();
            this.LNBackgroundColorPanel = new System.Windows.Forms.Panel();
            this.LNVisibleComboBox = new System.Windows.Forms.ComboBox();
            this.LNFontColorLabel = new System.Windows.Forms.Label();
            this.LNBackgroundColor = new System.Windows.Forms.Label();
            this.LNVisibleLabel = new System.Windows.Forms.Label();
            this.EditorGroupBox = new System.Windows.Forms.GroupBox();
            this.InserKeyComboBox = new System.Windows.Forms.ComboBox();
            this.InsertKeyLabel = new System.Windows.Forms.Label();
            this.FontNameComboBox = new System.Windows.Forms.ComboBox();
            this.FontColorPanel = new System.Windows.Forms.Panel();
            this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.BackgroundColorPanel = new System.Windows.Forms.Panel();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.ApplicationTabPage = new System.Windows.Forms.TabPage();
            this.ToolbarColorCheckBox = new System.Windows.Forms.CheckBox();
            this.MenuIconsCheckBox = new System.Windows.Forms.CheckBox();
            this.ToolbarCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdatesCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoLockCheckBox = new System.Windows.Forms.CheckBox();
            this.IntegrationTabPage = new System.Windows.Forms.TabPage();
            this.IntegrateCheckBox = new System.Windows.Forms.CheckBox();
            this.AssociateCheckBox = new System.Windows.Forms.CheckBox();
            this.SendToCheckBox = new System.Windows.Forms.CheckBox();
            this.EncryptionTabPage = new System.Windows.Forms.TabPage();
            this.PwdIterationsTextBox = new System.Windows.Forms.TextBox();
            this.HashComboBox = new System.Windows.Forms.ComboBox();
            this.PwdIterationsLabel = new System.Windows.Forms.Label();
            this.SaltTextBox = new System.Windows.Forms.TextBox();
            this.KeySizeComboBox = new System.Windows.Forms.ComboBox();
            this.SaltLabel = new System.Windows.Forms.Label();
            this.KeySizeLabel = new System.Windows.Forms.Label();
            this.HashLabel = new System.Windows.Forms.Label();
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.SettingsTabControl.SuspendLayout();
            this.MainTabPage.SuspendLayout();
            this.LineNumbersGroupBox.SuspendLayout();
            this.EditorGroupBox.SuspendLayout();
            this.ApplicationTabPage.SuspendLayout();
            this.IntegrationTabPage.SuspendLayout();
            this.EncryptionTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontColorLabel
            // 
            this.FontColorLabel.AutoSize = true;
            this.FontColorLabel.Location = new System.Drawing.Point(9, 84);
            this.FontColorLabel.Name = "FontColorLabel";
            this.FontColorLabel.Size = new System.Drawing.Size(61, 15);
            this.FontColorLabel.TabIndex = 0;
            this.FontColorLabel.Text = "Font color";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(214, 269);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(68, 23);
            this.SaveSettingsButton.TabIndex = 4;
            this.SaveSettingsButton.TabStop = false;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // FontNameLabel
            // 
            this.FontNameLabel.AutoSize = true;
            this.FontNameLabel.Location = new System.Drawing.Point(9, 26);
            this.FontNameLabel.Name = "FontNameLabel";
            this.FontNameLabel.Size = new System.Drawing.Size(66, 15);
            this.FontNameLabel.TabIndex = 1;
            this.FontNameLabel.Text = "Font name";
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.MainTabPage);
            this.SettingsTabControl.Controls.Add(this.ApplicationTabPage);
            this.SettingsTabControl.Controls.Add(this.IntegrationTabPage);
            this.SettingsTabControl.Controls.Add(this.EncryptionTabPage);
            this.SettingsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.SettingsTabControl.Multiline = true;
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(286, 267);
            this.SettingsTabControl.TabIndex = 4;
            // 
            // MainTabPage
            // 
            this.MainTabPage.AutoScroll = true;
            this.MainTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.MainTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTabPage.Controls.Add(this.LineNumbersGroupBox);
            this.MainTabPage.Controls.Add(this.EditorGroupBox);
            this.MainTabPage.Location = new System.Drawing.Point(4, 24);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(278, 239);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Main";
            // 
            // LineNumbersGroupBox
            // 
            this.LineNumbersGroupBox.Controls.Add(this.GLStyleComboBox);
            this.LineNumbersGroupBox.Controls.Add(this.GLStyleLabel);
            this.LineNumbersGroupBox.Controls.Add(this.GLColorPanel);
            this.LineNumbersGroupBox.Controls.Add(this.GLColorLabel);
            this.LineNumbersGroupBox.Controls.Add(this.GLShowComboBox);
            this.LineNumbersGroupBox.Controls.Add(this.GLShowLabel);
            this.LineNumbersGroupBox.Controls.Add(this.BLStyleComboBox);
            this.LineNumbersGroupBox.Controls.Add(this.BLStyleLabel);
            this.LineNumbersGroupBox.Controls.Add(this.BLColorPanel);
            this.LineNumbersGroupBox.Controls.Add(this.BLColorLabel);
            this.LineNumbersGroupBox.Controls.Add(this.BLShowСomboBox);
            this.LineNumbersGroupBox.Controls.Add(this.BLShowLabel);
            this.LineNumbersGroupBox.Controls.Add(this.LNFontColorPanel);
            this.LineNumbersGroupBox.Controls.Add(this.LNBackgroundColorPanel);
            this.LineNumbersGroupBox.Controls.Add(this.LNVisibleComboBox);
            this.LineNumbersGroupBox.Controls.Add(this.LNFontColorLabel);
            this.LineNumbersGroupBox.Controls.Add(this.LNBackgroundColor);
            this.LineNumbersGroupBox.Controls.Add(this.LNVisibleLabel);
            this.LineNumbersGroupBox.Location = new System.Drawing.Point(2, 215);
            this.LineNumbersGroupBox.Name = "LineNumbersGroupBox";
            this.LineNumbersGroupBox.Size = new System.Drawing.Size(249, 283);
            this.LineNumbersGroupBox.TabIndex = 14;
            this.LineNumbersGroupBox.TabStop = false;
            this.LineNumbersGroupBox.Text = "Line Numbers";
            // 
            // GLStyleComboBox
            // 
            this.GLStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GLStyleComboBox.FormattingEnabled = true;
            this.GLStyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.GLStyleComboBox.Location = new System.Drawing.Point(137, 250);
            this.GLStyleComboBox.Name = "GLStyleComboBox";
            this.GLStyleComboBox.Size = new System.Drawing.Size(100, 23);
            this.GLStyleComboBox.TabIndex = 26;
            // 
            // GLStyleLabel
            // 
            this.GLStyleLabel.AutoSize = true;
            this.GLStyleLabel.Location = new System.Drawing.Point(9, 250);
            this.GLStyleLabel.Name = "GLStyleLabel";
            this.GLStyleLabel.Size = new System.Drawing.Size(86, 15);
            this.GLStyleLabel.TabIndex = 25;
            this.GLStyleLabel.Text = "Grid lines style";
            // 
            // GLColorPanel
            // 
            this.GLColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GLColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GLColorPanel.Location = new System.Drawing.Point(137, 223);
            this.GLColorPanel.Name = "GLColorPanel";
            this.GLColorPanel.Size = new System.Drawing.Size(100, 21);
            this.GLColorPanel.TabIndex = 24;
            this.GLColorPanel.Click += new System.EventHandler(this.GLColorPanel_Click);
            // 
            // GLColorLabel
            // 
            this.GLColorLabel.AutoSize = true;
            this.GLColorLabel.Location = new System.Drawing.Point(9, 223);
            this.GLColorLabel.Name = "GLColorLabel";
            this.GLColorLabel.Size = new System.Drawing.Size(89, 15);
            this.GLColorLabel.TabIndex = 23;
            this.GLColorLabel.Text = "Grid lines color";
            // 
            // GLShowComboBox
            // 
            this.GLShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GLShowComboBox.FormattingEnabled = true;
            this.GLShowComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.GLShowComboBox.Location = new System.Drawing.Point(137, 194);
            this.GLShowComboBox.Name = "GLShowComboBox";
            this.GLShowComboBox.Size = new System.Drawing.Size(100, 23);
            this.GLShowComboBox.TabIndex = 22;
            // 
            // GLShowLabel
            // 
            this.GLShowLabel.AutoSize = true;
            this.GLShowLabel.Location = new System.Drawing.Point(9, 194);
            this.GLShowLabel.Name = "GLShowLabel";
            this.GLShowLabel.Size = new System.Drawing.Size(91, 15);
            this.GLShowLabel.TabIndex = 21;
            this.GLShowLabel.Text = "Show grid lines";
            // 
            // BLStyleComboBox
            // 
            this.BLStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BLStyleComboBox.FormattingEnabled = true;
            this.BLStyleComboBox.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot"});
            this.BLStyleComboBox.Location = new System.Drawing.Point(137, 165);
            this.BLStyleComboBox.Name = "BLStyleComboBox";
            this.BLStyleComboBox.Size = new System.Drawing.Size(100, 23);
            this.BLStyleComboBox.TabIndex = 20;
            // 
            // BLStyleLabel
            // 
            this.BLStyleLabel.AutoSize = true;
            this.BLStyleLabel.Location = new System.Drawing.Point(9, 165);
            this.BLStyleLabel.Name = "BLStyleLabel";
            this.BLStyleLabel.Size = new System.Drawing.Size(100, 15);
            this.BLStyleLabel.TabIndex = 19;
            this.BLStyleLabel.Text = "Border lines style";
            // 
            // BLColorPanel
            // 
            this.BLColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BLColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLColorPanel.Location = new System.Drawing.Point(137, 138);
            this.BLColorPanel.Name = "BLColorPanel";
            this.BLColorPanel.Size = new System.Drawing.Size(100, 21);
            this.BLColorPanel.TabIndex = 18;
            this.BLColorPanel.Click += new System.EventHandler(this.BLColorPanel_Click);
            // 
            // BLColorLabel
            // 
            this.BLColorLabel.AutoSize = true;
            this.BLColorLabel.Location = new System.Drawing.Point(9, 138);
            this.BLColorLabel.Name = "BLColorLabel";
            this.BLColorLabel.Size = new System.Drawing.Size(103, 15);
            this.BLColorLabel.TabIndex = 17;
            this.BLColorLabel.Text = "Border lines color";
            // 
            // BLShowСomboBox
            // 
            this.BLShowСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BLShowСomboBox.FormattingEnabled = true;
            this.BLShowСomboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.BLShowСomboBox.Location = new System.Drawing.Point(137, 109);
            this.BLShowСomboBox.Name = "BLShowСomboBox";
            this.BLShowСomboBox.Size = new System.Drawing.Size(100, 23);
            this.BLShowСomboBox.TabIndex = 16;
            // 
            // BLShowLabel
            // 
            this.BLShowLabel.AutoSize = true;
            this.BLShowLabel.Location = new System.Drawing.Point(9, 109);
            this.BLShowLabel.Name = "BLShowLabel";
            this.BLShowLabel.Size = new System.Drawing.Size(106, 15);
            this.BLShowLabel.TabIndex = 15;
            this.BLShowLabel.Text = "Show border lines";
            // 
            // LNFontColorPanel
            // 
            this.LNFontColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNFontColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LNFontColorPanel.Location = new System.Drawing.Point(137, 82);
            this.LNFontColorPanel.Name = "LNFontColorPanel";
            this.LNFontColorPanel.Size = new System.Drawing.Size(100, 21);
            this.LNFontColorPanel.TabIndex = 14;
            this.LNFontColorPanel.Click += new System.EventHandler(this.LNFontColorPanel_Click);
            // 
            // LNBackgroundColorPanel
            // 
            this.LNBackgroundColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNBackgroundColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LNBackgroundColorPanel.Location = new System.Drawing.Point(137, 55);
            this.LNBackgroundColorPanel.Name = "LNBackgroundColorPanel";
            this.LNBackgroundColorPanel.Size = new System.Drawing.Size(100, 21);
            this.LNBackgroundColorPanel.TabIndex = 13;
            this.LNBackgroundColorPanel.Click += new System.EventHandler(this.LNBackgroundColorPanel_Click);
            // 
            // LNVisibleComboBox
            // 
            this.LNVisibleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LNVisibleComboBox.FormattingEnabled = true;
            this.LNVisibleComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.LNVisibleComboBox.Location = new System.Drawing.Point(137, 26);
            this.LNVisibleComboBox.Name = "LNVisibleComboBox";
            this.LNVisibleComboBox.Size = new System.Drawing.Size(100, 23);
            this.LNVisibleComboBox.TabIndex = 3;
            // 
            // LNFontColorLabel
            // 
            this.LNFontColorLabel.AutoSize = true;
            this.LNFontColorLabel.Location = new System.Drawing.Point(9, 82);
            this.LNFontColorLabel.Name = "LNFontColorLabel";
            this.LNFontColorLabel.Size = new System.Drawing.Size(61, 15);
            this.LNFontColorLabel.TabIndex = 2;
            this.LNFontColorLabel.Text = "Font color";
            // 
            // LNBackgroundColor
            // 
            this.LNBackgroundColor.AutoSize = true;
            this.LNBackgroundColor.Location = new System.Drawing.Point(9, 55);
            this.LNBackgroundColor.Name = "LNBackgroundColor";
            this.LNBackgroundColor.Size = new System.Drawing.Size(103, 15);
            this.LNBackgroundColor.TabIndex = 1;
            this.LNBackgroundColor.Text = "Background color";
            // 
            // LNVisibleLabel
            // 
            this.LNVisibleLabel.AutoSize = true;
            this.LNVisibleLabel.Location = new System.Drawing.Point(9, 26);
            this.LNVisibleLabel.Name = "LNVisibleLabel";
            this.LNVisibleLabel.Size = new System.Drawing.Size(43, 15);
            this.LNVisibleLabel.TabIndex = 0;
            this.LNVisibleLabel.Text = "Visible";
            // 
            // EditorGroupBox
            // 
            this.EditorGroupBox.Controls.Add(this.InserKeyComboBox);
            this.EditorGroupBox.Controls.Add(this.InsertKeyLabel);
            this.EditorGroupBox.Controls.Add(this.FontNameLabel);
            this.EditorGroupBox.Controls.Add(this.FontColorLabel);
            this.EditorGroupBox.Controls.Add(this.FontNameComboBox);
            this.EditorGroupBox.Controls.Add(this.FontColorPanel);
            this.EditorGroupBox.Controls.Add(this.FontSizeComboBox);
            this.EditorGroupBox.Controls.Add(this.BackgroundColorPanel);
            this.EditorGroupBox.Controls.Add(this.BackgroundColorLabel);
            this.EditorGroupBox.Controls.Add(this.FontSizeLabel);
            this.EditorGroupBox.Location = new System.Drawing.Point(6, 12);
            this.EditorGroupBox.Name = "EditorGroupBox";
            this.EditorGroupBox.Size = new System.Drawing.Size(249, 183);
            this.EditorGroupBox.TabIndex = 13;
            this.EditorGroupBox.TabStop = false;
            this.EditorGroupBox.Text = "Editor";
            // 
            // InserKeyComboBox
            // 
            this.InserKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InserKeyComboBox.FormattingEnabled = true;
            this.InserKeyComboBox.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.InserKeyComboBox.Location = new System.Drawing.Point(137, 138);
            this.InserKeyComboBox.Name = "InserKeyComboBox";
            this.InserKeyComboBox.Size = new System.Drawing.Size(100, 23);
            this.InserKeyComboBox.TabIndex = 14;
            // 
            // InsertKeyLabel
            // 
            this.InsertKeyLabel.AutoSize = true;
            this.InsertKeyLabel.Location = new System.Drawing.Point(9, 138);
            this.InsertKeyLabel.Name = "InsertKeyLabel";
            this.InsertKeyLabel.Size = new System.Drawing.Size(58, 15);
            this.InsertKeyLabel.TabIndex = 13;
            this.InsertKeyLabel.Text = "Insert key";
            // 
            // FontNameComboBox
            // 
            this.FontNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FontNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontNameComboBox.FormattingEnabled = true;
            this.FontNameComboBox.Location = new System.Drawing.Point(137, 26);
            this.FontNameComboBox.Name = "FontNameComboBox";
            this.FontNameComboBox.Size = new System.Drawing.Size(100, 23);
            this.FontNameComboBox.TabIndex = 5;
            // 
            // FontColorPanel
            // 
            this.FontColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FontColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FontColorPanel.Location = new System.Drawing.Point(137, 84);
            this.FontColorPanel.Name = "FontColorPanel";
            this.FontColorPanel.Size = new System.Drawing.Size(100, 21);
            this.FontColorPanel.TabIndex = 7;
            this.FontColorPanel.Click += new System.EventHandler(this.FontColorPanel_Click_1);
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.FontSizeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.FontSizeComboBox.FormattingEnabled = true;
            this.FontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.FontSizeComboBox.Location = new System.Drawing.Point(137, 55);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(100, 23);
            this.FontSizeComboBox.TabIndex = 6;
            // 
            // BackgroundColorPanel
            // 
            this.BackgroundColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackgroundColorPanel.Location = new System.Drawing.Point(137, 111);
            this.BackgroundColorPanel.Name = "BackgroundColorPanel";
            this.BackgroundColorPanel.Size = new System.Drawing.Size(100, 21);
            this.BackgroundColorPanel.TabIndex = 8;
            this.BackgroundColorPanel.Click += new System.EventHandler(this.BackgroundColorPanel_Click);
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(9, 111);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(103, 15);
            this.BackgroundColorLabel.TabIndex = 10;
            this.BackgroundColorLabel.Text = "Background color";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(9, 55);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(56, 15);
            this.FontSizeLabel.TabIndex = 9;
            this.FontSizeLabel.Text = "Font size";
            // 
            // ApplicationTabPage
            // 
            this.ApplicationTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.ApplicationTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ApplicationTabPage.Controls.Add(this.ToolbarColorCheckBox);
            this.ApplicationTabPage.Controls.Add(this.MenuIconsCheckBox);
            this.ApplicationTabPage.Controls.Add(this.ToolbarCheckBox);
            this.ApplicationTabPage.Controls.Add(this.AutoSaveCheckBox);
            this.ApplicationTabPage.Controls.Add(this.UpdatesCheckBox);
            this.ApplicationTabPage.Controls.Add(this.AutoLockCheckBox);
            this.ApplicationTabPage.Location = new System.Drawing.Point(4, 24);
            this.ApplicationTabPage.Name = "ApplicationTabPage";
            this.ApplicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationTabPage.Size = new System.Drawing.Size(278, 239);
            this.ApplicationTabPage.TabIndex = 2;
            this.ApplicationTabPage.Text = "Application";
            // 
            // ToolbarColorCheckBox
            // 
            this.ToolbarColorCheckBox.AutoSize = true;
            this.ToolbarColorCheckBox.Location = new System.Drawing.Point(7, 128);
            this.ToolbarColorCheckBox.Name = "ToolbarColorCheckBox";
            this.ToolbarColorCheckBox.Size = new System.Drawing.Size(131, 19);
            this.ToolbarColorCheckBox.TabIndex = 8;
            this.ToolbarColorCheckBox.Text = "Chameleon toolbar";
            this.ToolbarColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // MenuIconsCheckBox
            // 
            this.MenuIconsCheckBox.AutoSize = true;
            this.MenuIconsCheckBox.Location = new System.Drawing.Point(7, 82);
            this.MenuIconsCheckBox.Name = "MenuIconsCheckBox";
            this.MenuIconsCheckBox.Size = new System.Drawing.Size(90, 19);
            this.MenuIconsCheckBox.TabIndex = 7;
            this.MenuIconsCheckBox.Text = "Menu icons";
            this.MenuIconsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToolbarCheckBox
            // 
            this.ToolbarCheckBox.AutoSize = true;
            this.ToolbarCheckBox.Location = new System.Drawing.Point(7, 105);
            this.ToolbarCheckBox.Name = "ToolbarCheckBox";
            this.ToolbarCheckBox.Size = new System.Drawing.Size(98, 19);
            this.ToolbarCheckBox.TabIndex = 2;
            this.ToolbarCheckBox.Text = "Show toolbar";
            this.ToolbarCheckBox.UseVisualStyleBackColor = true;
            this.ToolbarCheckBox.CheckedChanged += new System.EventHandler(this.ToolbarCheckBox_CheckedChanged);
            // 
            // AutoSaveCheckBox
            // 
            this.AutoSaveCheckBox.AutoSize = true;
            this.AutoSaveCheckBox.Location = new System.Drawing.Point(7, 59);
            this.AutoSaveCheckBox.Name = "AutoSaveCheckBox";
            this.AutoSaveCheckBox.Size = new System.Drawing.Size(120, 19);
            this.AutoSaveCheckBox.TabIndex = 4;
            this.AutoSaveCheckBox.Text = "Auto save on lock";
            this.AutoSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdatesCheckBox
            // 
            this.UpdatesCheckBox.AutoSize = true;
            this.UpdatesCheckBox.Location = new System.Drawing.Point(7, 36);
            this.UpdatesCheckBox.Name = "UpdatesCheckBox";
            this.UpdatesCheckBox.Size = new System.Drawing.Size(132, 19);
            this.UpdatesCheckBox.TabIndex = 1;
            this.UpdatesCheckBox.Text = "Auto check updates";
            this.UpdatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoLockCheckBox
            // 
            this.AutoLockCheckBox.AutoSize = true;
            this.AutoLockCheckBox.Location = new System.Drawing.Point(7, 13);
            this.AutoLockCheckBox.Name = "AutoLockCheckBox";
            this.AutoLockCheckBox.Size = new System.Drawing.Size(146, 19);
            this.AutoLockCheckBox.TabIndex = 3;
            this.AutoLockCheckBox.Text = "Auto lock on minimize";
            this.AutoLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // IntegrationTabPage
            // 
            this.IntegrationTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntegrationTabPage.Controls.Add(this.IntegrateCheckBox);
            this.IntegrationTabPage.Controls.Add(this.AssociateCheckBox);
            this.IntegrationTabPage.Controls.Add(this.SendToCheckBox);
            this.IntegrationTabPage.Location = new System.Drawing.Point(4, 24);
            this.IntegrationTabPage.Name = "IntegrationTabPage";
            this.IntegrationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IntegrationTabPage.Size = new System.Drawing.Size(278, 239);
            this.IntegrationTabPage.TabIndex = 3;
            this.IntegrationTabPage.Text = "Integration";
            this.IntegrationTabPage.UseVisualStyleBackColor = true;
            // 
            // IntegrateCheckBox
            // 
            this.IntegrateCheckBox.AutoSize = true;
            this.IntegrateCheckBox.Location = new System.Drawing.Point(7, 13);
            this.IntegrateCheckBox.Name = "IntegrateCheckBox";
            this.IntegrateCheckBox.Size = new System.Drawing.Size(227, 19);
            this.IntegrateCheckBox.TabIndex = 6;
            this.IntegrateCheckBox.Text = "Integrate with windows context menu";
            this.IntegrateCheckBox.UseVisualStyleBackColor = true;
            // 
            // AssociateCheckBox
            // 
            this.AssociateCheckBox.AutoSize = true;
            this.AssociateCheckBox.Location = new System.Drawing.Point(7, 36);
            this.AssociateCheckBox.Name = "AssociateCheckBox";
            this.AssociateCheckBox.Size = new System.Drawing.Size(159, 19);
            this.AssociateCheckBox.TabIndex = 0;
            this.AssociateCheckBox.Text = "Associate with *.cnp files";
            this.AssociateCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendToCheckBox
            // 
            this.SendToCheckBox.AutoSize = true;
            this.SendToCheckBox.Location = new System.Drawing.Point(7, 59);
            this.SendToCheckBox.Name = "SendToCheckBox";
            this.SendToCheckBox.Size = new System.Drawing.Size(158, 19);
            this.SendToCheckBox.TabIndex = 5;
            this.SendToCheckBox.Text = "Show in \"Send to\" menu";
            this.SendToCheckBox.UseVisualStyleBackColor = true;
            // 
            // EncryptionTabPage
            // 
            this.EncryptionTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.EncryptionTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EncryptionTabPage.Controls.Add(this.PwdIterationsTextBox);
            this.EncryptionTabPage.Controls.Add(this.HashComboBox);
            this.EncryptionTabPage.Controls.Add(this.PwdIterationsLabel);
            this.EncryptionTabPage.Controls.Add(this.SaltTextBox);
            this.EncryptionTabPage.Controls.Add(this.KeySizeComboBox);
            this.EncryptionTabPage.Controls.Add(this.SaltLabel);
            this.EncryptionTabPage.Controls.Add(this.KeySizeLabel);
            this.EncryptionTabPage.Controls.Add(this.HashLabel);
            this.EncryptionTabPage.Location = new System.Drawing.Point(4, 24);
            this.EncryptionTabPage.Name = "EncryptionTabPage";
            this.EncryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptionTabPage.Size = new System.Drawing.Size(278, 239);
            this.EncryptionTabPage.TabIndex = 1;
            this.EncryptionTabPage.Text = "Encryption";
            // 
            // PwdIterationsTextBox
            // 
            this.PwdIterationsTextBox.Location = new System.Drawing.Point(162, 68);
            this.PwdIterationsTextBox.Name = "PwdIterationsTextBox";
            this.PwdIterationsTextBox.Size = new System.Drawing.Size(100, 21);
            this.PwdIterationsTextBox.TabIndex = 7;
            // 
            // HashComboBox
            // 
            this.HashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HashComboBox.FormattingEnabled = true;
            this.HashComboBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.HashComboBox.Location = new System.Drawing.Point(162, 10);
            this.HashComboBox.Name = "HashComboBox";
            this.HashComboBox.Size = new System.Drawing.Size(100, 23);
            this.HashComboBox.TabIndex = 5;
            // 
            // PwdIterationsLabel
            // 
            this.PwdIterationsLabel.AutoSize = true;
            this.PwdIterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PwdIterationsLabel.Location = new System.Drawing.Point(13, 71);
            this.PwdIterationsLabel.Name = "PwdIterationsLabel";
            this.PwdIterationsLabel.Size = new System.Drawing.Size(114, 15);
            this.PwdIterationsLabel.TabIndex = 6;
            this.PwdIterationsLabel.Text = "Password iterations";
            // 
            // SaltTextBox
            // 
            this.SaltTextBox.Location = new System.Drawing.Point(162, 95);
            this.SaltTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.SaltTextBox.Name = "SaltTextBox";
            this.SaltTextBox.ReadOnly = true;
            this.SaltTextBox.Size = new System.Drawing.Size(100, 21);
            this.SaltTextBox.TabIndex = 4;
            this.SaltTextBox.Visible = false;
            // 
            // KeySizeComboBox
            // 
            this.KeySizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeySizeComboBox.FormattingEnabled = true;
            this.KeySizeComboBox.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.KeySizeComboBox.Location = new System.Drawing.Point(162, 39);
            this.KeySizeComboBox.Name = "KeySizeComboBox";
            this.KeySizeComboBox.Size = new System.Drawing.Size(100, 23);
            this.KeySizeComboBox.TabIndex = 3;
            // 
            // SaltLabel
            // 
            this.SaltLabel.AutoSize = true;
            this.SaltLabel.Location = new System.Drawing.Point(13, 101);
            this.SaltLabel.Name = "SaltLabel";
            this.SaltLabel.Size = new System.Drawing.Size(52, 15);
            this.SaltLabel.TabIndex = 2;
            this.SaltLabel.Text = "The Salt";
            this.SaltLabel.Visible = false;
            // 
            // KeySizeLabel
            // 
            this.KeySizeLabel.AutoSize = true;
            this.KeySizeLabel.Location = new System.Drawing.Point(13, 42);
            this.KeySizeLabel.Name = "KeySizeLabel";
            this.KeySizeLabel.Size = new System.Drawing.Size(52, 15);
            this.KeySizeLabel.TabIndex = 1;
            this.KeySizeLabel.Text = "Key size";
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(13, 13);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(94, 15);
            this.HashLabel.TabIndex = 0;
            this.HashLabel.Text = "Hash algorithm ";
            // 
            // ResetSettingsButton
            // 
            this.ResetSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetSettingsButton.Location = new System.Drawing.Point(4, 269);
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.Size = new System.Drawing.Size(68, 23);
            this.ResetSettingsButton.TabIndex = 5;
            this.ResetSettingsButton.Text = "Reset";
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 297);
            this.Controls.Add(this.ResetSettingsButton);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.SettingsTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SettingsTabControl.ResumeLayout(false);
            this.MainTabPage.ResumeLayout(false);
            this.LineNumbersGroupBox.ResumeLayout(false);
            this.LineNumbersGroupBox.PerformLayout();
            this.EditorGroupBox.ResumeLayout(false);
            this.EditorGroupBox.PerformLayout();
            this.ApplicationTabPage.ResumeLayout(false);
            this.ApplicationTabPage.PerformLayout();
            this.IntegrationTabPage.ResumeLayout(false);
            this.IntegrationTabPage.PerformLayout();
            this.EncryptionTabPage.ResumeLayout(false);
            this.EncryptionTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FontColorLabel;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label FontNameLabel;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage EncryptionTabPage;
        private System.Windows.Forms.TabPage ApplicationTabPage;
        private System.Windows.Forms.CheckBox AssociateCheckBox;
        private System.Windows.Forms.CheckBox UpdatesCheckBox;
        private System.Windows.Forms.ComboBox FontNameComboBox;
        private System.Windows.Forms.ComboBox FontSizeComboBox;
        private System.Windows.Forms.Panel FontColorPanel;
        private System.Windows.Forms.Panel BackgroundColorPanel;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.Label BackgroundColorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TextBox SaltTextBox;
        private System.Windows.Forms.ComboBox KeySizeComboBox;
        private System.Windows.Forms.Label SaltLabel;
        private System.Windows.Forms.Label KeySizeLabel;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.ComboBox HashComboBox;
        private System.Windows.Forms.TextBox PwdIterationsTextBox;
        private System.Windows.Forms.Label PwdIterationsLabel;
        private System.Windows.Forms.Button ResetSettingsButton;
        private System.Windows.Forms.CheckBox ToolbarCheckBox;
        private System.Windows.Forms.CheckBox AutoLockCheckBox;
        private System.Windows.Forms.CheckBox AutoSaveCheckBox;
        private System.Windows.Forms.CheckBox SendToCheckBox;
        private System.Windows.Forms.CheckBox IntegrateCheckBox;
        private System.Windows.Forms.CheckBox MenuIconsCheckBox;
        private System.Windows.Forms.TabPage IntegrationTabPage;
        private System.Windows.Forms.CheckBox ToolbarColorCheckBox;
        private System.Windows.Forms.GroupBox LineNumbersGroupBox;
        private System.Windows.Forms.GroupBox EditorGroupBox;
        private System.Windows.Forms.Label LNFontColorLabel;
        private System.Windows.Forms.Label LNBackgroundColor;
        private System.Windows.Forms.Label LNVisibleLabel;
        private System.Windows.Forms.ComboBox LNVisibleComboBox;
        private System.Windows.Forms.Panel LNFontColorPanel;
        private System.Windows.Forms.Panel LNBackgroundColorPanel;
        private System.Windows.Forms.ComboBox BLStyleComboBox;
        private System.Windows.Forms.Label BLStyleLabel;
        private System.Windows.Forms.Panel BLColorPanel;
        private System.Windows.Forms.Label BLColorLabel;
        private System.Windows.Forms.ComboBox BLShowСomboBox;
        private System.Windows.Forms.Label BLShowLabel;
        private System.Windows.Forms.ComboBox GLStyleComboBox;
        private System.Windows.Forms.Label GLStyleLabel;
        private System.Windows.Forms.Panel GLColorPanel;
        private System.Windows.Forms.Label GLColorLabel;
        private System.Windows.Forms.ComboBox GLShowComboBox;
        private System.Windows.Forms.Label GLShowLabel;
        private System.Windows.Forms.ComboBox InserKeyComboBox;
        private System.Windows.Forms.Label InsertKeyLabel;
    }
}