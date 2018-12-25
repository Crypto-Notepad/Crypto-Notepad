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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.FontColorLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.FontNameLabel = new System.Windows.Forms.Label();
            this.SettingsTabControl = new System.Windows.Forms.TabControl();
            this.EditorTabPage = new System.Windows.Forms.TabPage();
            this.HighlightsColorPanel = new System.Windows.Forms.Panel();
            this.HighlightsColorLabel = new System.Windows.Forms.Label();
            this.FontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.BackgroundColorLabel = new System.Windows.Forms.Label();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.BackgroundColorPanel = new System.Windows.Forms.Panel();
            this.FontColorPanel = new System.Windows.Forms.Panel();
            this.FontNameComboBox = new System.Windows.Forms.ComboBox();
            this.EncryptionTabPage = new System.Windows.Forms.TabPage();
            this.PwdIterationsTextBox = new System.Windows.Forms.TextBox();
            this.HashComboBox = new System.Windows.Forms.ComboBox();
            this.PwdIterationsLabel = new System.Windows.Forms.Label();
            this.SaltTextBox = new System.Windows.Forms.TextBox();
            this.KeySizeComboBox = new System.Windows.Forms.ComboBox();
            this.SaltLabel = new System.Windows.Forms.Label();
            this.KeySizeLabel = new System.Windows.Forms.Label();
            this.HashLabel = new System.Windows.Forms.Label();
            this.ApplicationTabPage = new System.Windows.Forms.TabPage();
            this.IntegrateCheckBox = new System.Windows.Forms.CheckBox();
            this.ToolbarCheckBox = new System.Windows.Forms.CheckBox();
            this.SendToCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoSaveCheckBox = new System.Windows.Forms.CheckBox();
            this.AssociateCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdatesCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoLockCheckBox = new System.Windows.Forms.CheckBox();
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SettingsTabControl.SuspendLayout();
            this.EditorTabPage.SuspendLayout();
            this.EncryptionTabPage.SuspendLayout();
            this.ApplicationTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontColorLabel
            // 
            this.FontColorLabel.AutoSize = true;
            this.FontColorLabel.Location = new System.Drawing.Point(7, 86);
            this.FontColorLabel.Name = "FontColorLabel";
            this.FontColorLabel.Size = new System.Drawing.Size(54, 13);
            this.FontColorLabel.TabIndex = 0;
            this.FontColorLabel.Text = "Font color";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(179, 239);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(79, 23);
            this.SaveSettingsButton.TabIndex = 4;
            this.SaveSettingsButton.Text = "Save && Close";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // FontNameLabel
            // 
            this.FontNameLabel.AutoSize = true;
            this.FontNameLabel.Location = new System.Drawing.Point(7, 18);
            this.FontNameLabel.Name = "FontNameLabel";
            this.FontNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FontNameLabel.TabIndex = 1;
            this.FontNameLabel.Text = "Font name";
            // 
            // SettingsTabControl
            // 
            this.SettingsTabControl.Controls.Add(this.EditorTabPage);
            this.SettingsTabControl.Controls.Add(this.EncryptionTabPage);
            this.SettingsTabControl.Controls.Add(this.ApplicationTabPage);
            this.SettingsTabControl.Location = new System.Drawing.Point(2, 2);
            this.SettingsTabControl.Name = "SettingsTabControl";
            this.SettingsTabControl.SelectedIndex = 0;
            this.SettingsTabControl.Size = new System.Drawing.Size(260, 231);
            this.SettingsTabControl.TabIndex = 4;
            // 
            // EditorTabPage
            // 
            this.EditorTabPage.Controls.Add(this.HighlightsColorPanel);
            this.EditorTabPage.Controls.Add(this.HighlightsColorLabel);
            this.EditorTabPage.Controls.Add(this.FontSizeComboBox);
            this.EditorTabPage.Controls.Add(this.BackgroundColorLabel);
            this.EditorTabPage.Controls.Add(this.FontSizeLabel);
            this.EditorTabPage.Controls.Add(this.BackgroundColorPanel);
            this.EditorTabPage.Controls.Add(this.FontColorPanel);
            this.EditorTabPage.Controls.Add(this.FontNameComboBox);
            this.EditorTabPage.Controls.Add(this.FontNameLabel);
            this.EditorTabPage.Controls.Add(this.FontColorLabel);
            this.EditorTabPage.Location = new System.Drawing.Point(4, 22);
            this.EditorTabPage.Name = "EditorTabPage";
            this.EditorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditorTabPage.Size = new System.Drawing.Size(252, 205);
            this.EditorTabPage.TabIndex = 0;
            this.EditorTabPage.Text = "Editor";
            this.EditorTabPage.UseVisualStyleBackColor = true;
            // 
            // HighlightsColorPanel
            // 
            this.HighlightsColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighlightsColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HighlightsColorPanel.Location = new System.Drawing.Point(136, 151);
            this.HighlightsColorPanel.Name = "HighlightsColorPanel";
            this.HighlightsColorPanel.Size = new System.Drawing.Size(100, 21);
            this.HighlightsColorPanel.TabIndex = 12;
            this.HighlightsColorPanel.Click += new System.EventHandler(this.HighlightsColorPanel_Click);
            // 
            // HighlightsColorLabel
            // 
            this.HighlightsColorLabel.AutoSize = true;
            this.HighlightsColorLabel.Location = new System.Drawing.Point(7, 154);
            this.HighlightsColorLabel.Name = "HighlightsColorLabel";
            this.HighlightsColorLabel.Size = new System.Drawing.Size(79, 13);
            this.HighlightsColorLabel.TabIndex = 11;
            this.HighlightsColorLabel.Text = "Highlights color";
            // 
            // FontSizeComboBox
            // 
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
            this.FontSizeComboBox.Location = new System.Drawing.Point(136, 49);
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(100, 21);
            this.FontSizeComboBox.TabIndex = 6;
            // 
            // BackgroundColorLabel
            // 
            this.BackgroundColorLabel.AutoSize = true;
            this.BackgroundColorLabel.Location = new System.Drawing.Point(7, 120);
            this.BackgroundColorLabel.Name = "BackgroundColorLabel";
            this.BackgroundColorLabel.Size = new System.Drawing.Size(91, 13);
            this.BackgroundColorLabel.TabIndex = 10;
            this.BackgroundColorLabel.Text = "Background color";
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(7, 52);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(49, 13);
            this.FontSizeLabel.TabIndex = 9;
            this.FontSizeLabel.Text = "Font size";
            // 
            // BackgroundColorPanel
            // 
            this.BackgroundColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackgroundColorPanel.Location = new System.Drawing.Point(136, 117);
            this.BackgroundColorPanel.Name = "BackgroundColorPanel";
            this.BackgroundColorPanel.Size = new System.Drawing.Size(100, 21);
            this.BackgroundColorPanel.TabIndex = 8;
            this.BackgroundColorPanel.Click += new System.EventHandler(this.BackgroundColorPanel_Click);
            // 
            // FontColorPanel
            // 
            this.FontColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FontColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FontColorPanel.Location = new System.Drawing.Point(136, 83);
            this.FontColorPanel.Name = "FontColorPanel";
            this.FontColorPanel.Size = new System.Drawing.Size(100, 21);
            this.FontColorPanel.TabIndex = 7;
            this.FontColorPanel.Click += new System.EventHandler(this.FontColorPanel_Click_1);
            // 
            // FontNameComboBox
            // 
            this.FontNameComboBox.FormattingEnabled = true;
            this.FontNameComboBox.Location = new System.Drawing.Point(136, 15);
            this.FontNameComboBox.Name = "FontNameComboBox";
            this.FontNameComboBox.Size = new System.Drawing.Size(100, 21);
            this.FontNameComboBox.TabIndex = 5;
            // 
            // EncryptionTabPage
            // 
            this.EncryptionTabPage.Controls.Add(this.PwdIterationsTextBox);
            this.EncryptionTabPage.Controls.Add(this.HashComboBox);
            this.EncryptionTabPage.Controls.Add(this.PwdIterationsLabel);
            this.EncryptionTabPage.Controls.Add(this.SaltTextBox);
            this.EncryptionTabPage.Controls.Add(this.KeySizeComboBox);
            this.EncryptionTabPage.Controls.Add(this.SaltLabel);
            this.EncryptionTabPage.Controls.Add(this.KeySizeLabel);
            this.EncryptionTabPage.Controls.Add(this.HashLabel);
            this.EncryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.EncryptionTabPage.Name = "EncryptionTabPage";
            this.EncryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EncryptionTabPage.Size = new System.Drawing.Size(252, 205);
            this.EncryptionTabPage.TabIndex = 1;
            this.EncryptionTabPage.Text = "Encryption";
            this.EncryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // PwdIterationsTextBox
            // 
            this.PwdIterationsTextBox.Location = new System.Drawing.Point(136, 83);
            this.PwdIterationsTextBox.Name = "PwdIterationsTextBox";
            this.PwdIterationsTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.HashComboBox.Location = new System.Drawing.Point(136, 15);
            this.HashComboBox.Name = "HashComboBox";
            this.HashComboBox.Size = new System.Drawing.Size(100, 21);
            this.HashComboBox.TabIndex = 5;
            // 
            // PwdIterationsLabel
            // 
            this.PwdIterationsLabel.AutoSize = true;
            this.PwdIterationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.PwdIterationsLabel.Location = new System.Drawing.Point(7, 86);
            this.PwdIterationsLabel.Name = "PwdIterationsLabel";
            this.PwdIterationsLabel.Size = new System.Drawing.Size(98, 13);
            this.PwdIterationsLabel.TabIndex = 6;
            this.PwdIterationsLabel.Text = "Password iterations";
            // 
            // SaltTextBox
            // 
            this.SaltTextBox.Location = new System.Drawing.Point(136, 116);
            this.SaltTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.SaltTextBox.Name = "SaltTextBox";
            this.SaltTextBox.ReadOnly = true;
            this.SaltTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.KeySizeComboBox.Location = new System.Drawing.Point(136, 49);
            this.KeySizeComboBox.Name = "KeySizeComboBox";
            this.KeySizeComboBox.Size = new System.Drawing.Size(100, 21);
            this.KeySizeComboBox.TabIndex = 3;
            // 
            // SaltLabel
            // 
            this.SaltLabel.AutoSize = true;
            this.SaltLabel.Location = new System.Drawing.Point(7, 119);
            this.SaltLabel.Name = "SaltLabel";
            this.SaltLabel.Size = new System.Drawing.Size(47, 13);
            this.SaltLabel.TabIndex = 2;
            this.SaltLabel.Text = "The Salt";
            this.SaltLabel.Visible = false;
            // 
            // KeySizeLabel
            // 
            this.KeySizeLabel.AutoSize = true;
            this.KeySizeLabel.Location = new System.Drawing.Point(7, 52);
            this.KeySizeLabel.Name = "KeySizeLabel";
            this.KeySizeLabel.Size = new System.Drawing.Size(46, 13);
            this.KeySizeLabel.TabIndex = 1;
            this.KeySizeLabel.Text = "Key size";
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(7, 18);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(80, 13);
            this.HashLabel.TabIndex = 0;
            this.HashLabel.Text = "Hash algorithm ";
            // 
            // ApplicationTabPage
            // 
            this.ApplicationTabPage.Controls.Add(this.IntegrateCheckBox);
            this.ApplicationTabPage.Controls.Add(this.ToolbarCheckBox);
            this.ApplicationTabPage.Controls.Add(this.SendToCheckBox);
            this.ApplicationTabPage.Controls.Add(this.AutoSaveCheckBox);
            this.ApplicationTabPage.Controls.Add(this.AssociateCheckBox);
            this.ApplicationTabPage.Controls.Add(this.UpdatesCheckBox);
            this.ApplicationTabPage.Controls.Add(this.AutoLockCheckBox);
            this.ApplicationTabPage.Location = new System.Drawing.Point(4, 22);
            this.ApplicationTabPage.Name = "ApplicationTabPage";
            this.ApplicationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationTabPage.Size = new System.Drawing.Size(252, 205);
            this.ApplicationTabPage.TabIndex = 2;
            this.ApplicationTabPage.Text = "Application";
            this.ApplicationTabPage.UseVisualStyleBackColor = true;
            // 
            // IntegrateCheckBox
            // 
            this.IntegrateCheckBox.AutoSize = true;
            this.IntegrateCheckBox.Location = new System.Drawing.Point(7, 18);
            this.IntegrateCheckBox.Name = "IntegrateCheckBox";
            this.IntegrateCheckBox.Size = new System.Drawing.Size(201, 17);
            this.IntegrateCheckBox.TabIndex = 6;
            this.IntegrateCheckBox.Text = "Integrate with windows context menu";
            this.IntegrateCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToolbarCheckBox
            // 
            this.ToolbarCheckBox.AutoSize = true;
            this.ToolbarCheckBox.Location = new System.Drawing.Point(7, 156);
            this.ToolbarCheckBox.Name = "ToolbarCheckBox";
            this.ToolbarCheckBox.Size = new System.Drawing.Size(88, 17);
            this.ToolbarCheckBox.TabIndex = 2;
            this.ToolbarCheckBox.Text = "Show toolbar";
            this.ToolbarCheckBox.UseVisualStyleBackColor = true;
            // 
            // SendToCheckBox
            // 
            this.SendToCheckBox.AutoSize = true;
            this.SendToCheckBox.Location = new System.Drawing.Point(7, 64);
            this.SendToCheckBox.Name = "SendToCheckBox";
            this.SendToCheckBox.Size = new System.Drawing.Size(143, 17);
            this.SendToCheckBox.TabIndex = 5;
            this.SendToCheckBox.Text = "Show in \"Send to\" menu";
            this.SendToCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoSaveCheckBox
            // 
            this.AutoSaveCheckBox.AutoSize = true;
            this.AutoSaveCheckBox.Location = new System.Drawing.Point(7, 133);
            this.AutoSaveCheckBox.Name = "AutoSaveCheckBox";
            this.AutoSaveCheckBox.Size = new System.Drawing.Size(112, 17);
            this.AutoSaveCheckBox.TabIndex = 4;
            this.AutoSaveCheckBox.Text = "Auto save on lock";
            this.AutoSaveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AssociateCheckBox
            // 
            this.AssociateCheckBox.AutoSize = true;
            this.AssociateCheckBox.Location = new System.Drawing.Point(7, 41);
            this.AssociateCheckBox.Name = "AssociateCheckBox";
            this.AssociateCheckBox.Size = new System.Drawing.Size(143, 17);
            this.AssociateCheckBox.TabIndex = 0;
            this.AssociateCheckBox.Text = "Associate with *.cnp files";
            this.AssociateCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdatesCheckBox
            // 
            this.UpdatesCheckBox.AutoSize = true;
            this.UpdatesCheckBox.Location = new System.Drawing.Point(7, 110);
            this.UpdatesCheckBox.Name = "UpdatesCheckBox";
            this.UpdatesCheckBox.Size = new System.Drawing.Size(122, 17);
            this.UpdatesCheckBox.TabIndex = 1;
            this.UpdatesCheckBox.Text = "Auto check updates";
            this.UpdatesCheckBox.UseVisualStyleBackColor = true;
            // 
            // AutoLockCheckBox
            // 
            this.AutoLockCheckBox.AutoSize = true;
            this.AutoLockCheckBox.Location = new System.Drawing.Point(7, 87);
            this.AutoLockCheckBox.Name = "AutoLockCheckBox";
            this.AutoLockCheckBox.Size = new System.Drawing.Size(128, 17);
            this.AutoLockCheckBox.TabIndex = 3;
            this.AutoLockCheckBox.Text = "Auto lock on minimize";
            this.AutoLockCheckBox.UseVisualStyleBackColor = true;
            // 
            // ResetSettingsButton
            // 
            this.ResetSettingsButton.Location = new System.Drawing.Point(6, 239);
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.Size = new System.Drawing.Size(98, 23);
            this.ResetSettingsButton.TabIndex = 5;
            this.ResetSettingsButton.Text = "Reset to Defaults";
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ResetSettingsButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 270);
            this.Controls.Add(this.ResetSettingsButton);
            this.Controls.Add(this.SettingsTabControl);
            this.Controls.Add(this.SaveSettingsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SettingsTabControl.ResumeLayout(false);
            this.EditorTabPage.ResumeLayout(false);
            this.EditorTabPage.PerformLayout();
            this.EncryptionTabPage.ResumeLayout(false);
            this.EncryptionTabPage.PerformLayout();
            this.ApplicationTabPage.ResumeLayout(false);
            this.ApplicationTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FontColorLabel;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label FontNameLabel;
        private System.Windows.Forms.TabControl SettingsTabControl;
        private System.Windows.Forms.TabPage EditorTabPage;
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
        private System.Windows.Forms.Panel HighlightsColorPanel;
        private System.Windows.Forms.Label HighlightsColorLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
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
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox AutoSaveCheckBox;
        private System.Windows.Forms.CheckBox SendToCheckBox;
        private System.Windows.Forms.CheckBox IntegrateCheckBox;
    }
}