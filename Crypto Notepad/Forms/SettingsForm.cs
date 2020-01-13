using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class SettingsForm : Form
    {
        Properties.Settings settings = Properties.Settings.Default;
        public SettingsForm()
        {
            InitializeComponent();
        }


        #region Methods
        private void LoadSettings()
        {
            editorFontColor.BackColor = settings.editroForeColor;
            editorBackColor.BackColor = settings.editorBackColor;
            editorInsertKeyComboBox.Text = settings.insertKey;
            editorPaddingLeftTextBox.Text = settings.editorPaddingLeft;
            editorOpenLinksWithComboBox.Text = settings.openLinks;
            editorBorderComboBox.Text = settings.editorBorder;
            fontDialog.Font = settings.editorFont;
            lockTimeoutTextBox.Text = settings.lockTimeout;
            autoLockOnMinimizeCheckBox.Checked = settings.autoLock;
            autoCheckUpdatesCheckBox.Checked = settings.autoCheckUpdate;
            mainMenuCheckBox.Checked = settings.mainMenuVisible;
            menuIconsCheckBox.Checked = settings.menuIcons;
            minimizeToTrayCheckBox.Checked = settings.minimizeToTray;
            closeToTrayCheckBox.Checked = settings.closeToTray;
            singleInstanceCheckBox.Checked = settings.singleInstance;
            integrateCheckBox.Checked = settings.explorerIntegrate;
            associateCheckBox.Checked = settings.explorerAssociate;
            sendToCheckBox.Checked = settings.explorerSendTo;
            hashAlgorithmComboBox.Text = settings.HashAlgorithm;
            keySizeComboBox.Text = settings.KeySize;
            passwordIterationsTextBox.Text = settings.PasswordIterations;
            searchBackColor.BackColor = settings.searchPanelBackColor;
            searchFontColor.BackColor = settings.searchPanelForeColor;
            searchBorderComboBox.Text = settings.searchPanelBorder;
            toolbarBackColor.BackColor = settings.toolbarBackColor;
            toolbarBorderCheckBox.Checked = settings.toolbarBorder;
            toolbarVisibleCheckBox.Checked = settings.toolbarVisible;
            toolbarOldIconsCheckBox.Checked = settings.oldToolbarIcons;
            toolbarCloseButtonCheckBox.Checked = settings.toolbarCloseButton;
            statusPanelBackColor.BackColor = settings.statusPanelBackColor;
            statusPanelFontColor.BackColor = settings.statusPanelFontColor;
            statusPanelVisibleCheckBox.Checked = settings.statusPanelVisible;
            statusPanelLengthCheckBox.Checked = settings.statusPanelLength;
            statusPanelLinesCheckBox.Checked = settings.statusPanelLines;
            statusPanelModifiedCheckBox.Checked = settings.statusPanelModified;
            statusPanelSizeCheckBox.Checked = settings.statusPanelSize;
            statusPanelLabelsGroupBox.Visible = settings.statusPanelVisible;
            statusPanelReadonlyCheckBox.Checked = settings.statusPanelReadonly;
            encryptionHintLabel.Visible = settings.encryptionHint;
        }     
        #endregion


        #region Event Handlers
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string custom_colors = settings.customColor;
            int[] array_of_colors = custom_colors.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
            colorDialog.CustomColors = array_of_colors;
            settingsTabControl.Appearance = TabAppearance.FlatButtons;
            settingsTabControl.ItemSize = new Size(0, 1);
            settingsTabControl.SizeMode = TabSizeMode.Fixed;
            settingsNavigation.SelectedIndex = 0;
            TopMost = settings.alwaysOnTop;
            settingsTabControl.TabStop = false;
            LoadSettings();
        }

        private void EditorPaddingLeftTextBox_Click(object sender, EventArgs e)
        {
            editorPaddingLeftTextBox.SelectAll();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm main = Owner as MainForm;
            string customColor = string.Join(";", colorDialog.CustomColors);
            settings.customColor = customColor;
            if (string.IsNullOrWhiteSpace(settings.PasswordIterations))
            {
                settings.PasswordIterations = "1";
            }
            if (string.IsNullOrWhiteSpace(editorPaddingLeftTextBox.Text))
            {
                settings.editorPaddingLeft = "0";
                main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            }
            settings.Save();
        }

        private void EditorPaddingLeftTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PasswordIterationsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LockTimeoutTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        #region Settings Events
        private void EncryptionHintLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                encryptionHintLabel.Visible = false;
                settings.encryptionHint = false;
            }
        }
        private void EditorFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = editorFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.ForeColor = colorDialog.Color;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
                    settings.editroForeColor = colorDialog.Color;
                    editorFontColor.BackColor = colorDialog.Color;
                }
            }
        }
        private void EditorBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = editorBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.BackColor = colorDialog.Color;
                    main.BackColor = colorDialog.Color;
                    settings.editorBackColor = colorDialog.Color;
                    editorBackColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void SettingsNavigation_Click(object sender, EventArgs e)
        {
            switch (settingsNavigation.SelectedIndex)
            {
                case 0:
                    settingsTabControl.SelectedTab = applicationTabPage;
                    break;
                case 1:
                    settingsTabControl.SelectedTab = toolbarTabPage;
                    break;
                case 2:
                    settingsTabControl.SelectedTab = statusPanelTabPage;
                    break;
                case 3:
                    settingsTabControl.SelectedTab = searchPanelTabPage;
                    break;
                case 4:
                    settingsTabControl.SelectedTab = editorTabPage;
                    break;
                case 5:
                    settingsTabControl.SelectedTab = encryptionTabPage;
                    break;
                case 6:
                    settingsTabControl.SelectedTab = integrationTabPage;
                    break;
            }            
        }

        private void SettingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsTabControl.Focus();
        }

        private void ToolbarVisibleCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.toolbarPanel.Visible = toolbarVisibleCheckBox.Checked;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            settings.toolbarVisible= toolbarVisibleCheckBox.Checked;
        }

        private void AssociateCheckBox_Click(object sender, EventArgs e)
        {
            if (associateCheckBox.Checked)
            {
                Methods.AssociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
            }
            else
            {
                Methods.DissociateExtension("cnp");
            }
            settings.explorerAssociate = associateCheckBox.Checked;
        }

        private void IntegrateCheckBox_Click(object sender, EventArgs e)
        {
            if (integrateCheckBox.Checked)
            {
                Methods.MenuIntegrate("enable");
            }
            else
            {
                Methods.MenuIntegrate("disable");
            }
            settings.explorerIntegrate = integrateCheckBox.Checked;
        }

        private void EditorPaddingLeftTextBox_TextChanged(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (editorPaddingLeftTextBox.Text.Length >= 1)
            {
                if (settings.editorPaddingLeft != editorPaddingLeftTextBox.Text)
                {
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(editorPaddingLeftTextBox.Text), 0, 0, 0);
                    main.richTextBox.Refresh();
                    settings.editorPaddingLeft = editorPaddingLeftTextBox.Text;
                }
            }               
        }

        private void LockTimeoutTextBox_TextChanged(object sender, EventArgs e)
        {
            if (lockTimeoutTextBox.Text != settings.lockTimeout)
            {
                settings.lockTimeout = lockTimeoutTextBox.Text;
            }

            if (string.IsNullOrEmpty(lockTimeoutTextBox.Text) | lockTimeoutTextBox.Text == "0")
            {
                MainForm main = Owner as MainForm;
                main.lockTimer.Enabled = false;
            }
        }

        private void SendToCheckBox_Click(object sender, EventArgs e)
        {
            if (sendToCheckBox.Checked)
            {
                Methods.SendToShortcut();
            }
            else
            {
                string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\SendTo\Crypto Notepad.lnk";
                if (System.IO.File.Exists(shortcutPath))
                {
                    System.IO.File.Delete(shortcutPath);
                }
            }
            settings.explorerSendTo = sendToCheckBox.Checked;
        }

        private void EditorInsertKeyComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.insertKey != editorInsertKeyComboBox.Text)
            {
                if (editorInsertKeyComboBox.Text == "Disable")
                {
                    main.insertMainMenu.ShortcutKeys = Keys.Insert;
                }
                else
                {
                    main.insertMainMenu.ShortcutKeys = Keys.None;
                }
                settings.insertKey = editorInsertKeyComboBox.Text;
            }
        }

        private void MenuIconsCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            settings.menuIcons = menuIconsCheckBox.Checked;
            main.MenuIcons(settings.menuIcons);         
        }

        private void EditorFontButton_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(this))
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.Font = fontDialog.Font;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
                    settings.editorFont = fontDialog.Font;
                }
            }
        }

        private void KeySizeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (keySizeComboBox.Text != settings.KeySize)
            {
                settings.KeySize = keySizeComboBox.Text;
            }
        }

        private void HashAlgorithmComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (hashAlgorithmComboBox.Text != settings.HashAlgorithm)
            {
                settings.HashAlgorithm = hashAlgorithmComboBox.Text;
            }
        }

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.richTextBox.Font = fontDialog.Font;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            settings.editorFont = fontDialog.Font;
        }

        private void StatusPanelVisibleCheckBox_Click(object sender, EventArgs e)
        {
            statusPanelLabelsGroupBox.Visible = statusPanelVisibleCheckBox.Checked;
            Application.DoEvents();
            MainForm main = Owner as MainForm;
            main.statusPanel.Visible = statusPanelVisibleCheckBox.Checked;
            //main.richTextBox.SetInnerMargins(Convert.ToInt32(editorPaddingLeftTextBox.Text), 0, 0, 0);
            settings.statusPanelVisible = statusPanelVisibleCheckBox.Checked;
        }

        private void StatusPanelBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = statusPanelBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.statusPanel.BackColor = colorDialog.Color;
                    statusPanelBackColor.BackColor = colorDialog.Color;
                    settings.statusPanelBackColor = colorDialog.Color;
                }
            }
        }

        private void StatusPanelFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = statusPanelFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.statusPanel.ForeColor = colorDialog.Color;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
                    statusPanelFontColor.BackColor = colorDialog.Color;
                    settings.statusPanelFontColor = colorDialog.Color;
                }
            }
        }

        private void ToolbarBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = toolbarBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.toolbarPanel.BackColor = colorDialog.Color;
                    settings.toolbarBackColor = colorDialog.Color;
                    toolbarBackColor.BackColor = colorDialog.Color;
                }
            }
        }    
        
        private void ToolbarBorderCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (toolbarBorderCheckBox.Checked)
            {
                main.toolbarPanel.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                main.toolbarPanel.BorderStyle = BorderStyle.None;
            }
            settings.toolbarBorder = toolbarBorderCheckBox.Checked;
        }

        private void SearchBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = searchBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.searchPanel.BackColor = colorDialog.Color;
                    main.searchTextBox.BackColor = colorDialog.Color;
                    settings.searchPanelBackColor = colorDialog.Color;
                    searchBackColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void SearchFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = searchFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.searchTextBox.ForeColor = colorDialog.Color;
                    main.searchCaseSensitiveCheckBox.ForeColor = colorDialog.Color;
                    main.searchWholeWordCheckBox.ForeColor = colorDialog.Color;
                    main.searchFindNextButton.ForeColor = colorDialog.Color;
                    main.searchCloseButton.ForeColor = colorDialog.Color;
                    settings.searchPanelForeColor = colorDialog.Color;
                    searchFontColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void MainMenuCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (mainMenuCheckBox.Checked)
            {
                main.mainMenu.Visible = true;
            }
            else
            {
                main.mainMenu.Visible = false;
            }
            settings.mainMenuVisible = mainMenuCheckBox.Checked;
        }

        private void ToolbarOldIconsCheckBox_Click(object sender, EventArgs e)
        {
            settings.oldToolbarIcons = toolbarOldIconsCheckBox.Checked;
            MainForm main = Owner as MainForm;
            main.ToolbarIcons(settings.oldToolbarIcons);
        }

        private void EditorOpenLinksWithComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (settings.openLinks != editorOpenLinksWithComboBox.Text)
            {
                settings.openLinks = editorOpenLinksWithComboBox.Text;
            }
        }

        private void AutoLockOnMinimizeCheckBox_Click(object sender, EventArgs e)
        {
            settings.autoLock = autoLockOnMinimizeCheckBox.Checked;
        }

        private void AutoCheckUpdatesCheckBox_Click(object sender, EventArgs e)
        {
            settings.autoCheckUpdate = autoCheckUpdatesCheckBox.Checked;

        }

        private void PasswordIterationsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordIterationsTextBox.Text != settings.PasswordIterations)
            {
                settings.PasswordIterations = passwordIterationsTextBox.Text;
            }
        }      

        private void MinimizeToTrayCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (closeToTrayCheckBox.Checked == false & minimizeToTrayCheckBox.Checked == false)
            {
                main.trayIcon.Visible = false;
            }
            if (minimizeToTrayCheckBox.Checked == true)
            {
                main.trayIcon.Visible = true;
            }
            settings.minimizeToTray = minimizeToTrayCheckBox.Checked;
        }

        private void CloseToTrayCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (closeToTrayCheckBox.Checked == false & minimizeToTrayCheckBox.Checked ==false )
            {
                main.trayIcon.Visible = false;
            }
            if (closeToTrayCheckBox.Checked == true)
            {
                main.trayIcon.Visible = true;
            }
            settings.closeToTray = closeToTrayCheckBox.Checked;
        }

        private void EditorBorderComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.richTextBoxPanel.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), editorBorderComboBox.Text);
            settings.editorBorder = editorBorderComboBox.Text;
        }

        private void SearchBorderComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.searchPanel.CellBorderStyle = (TableLayoutPanelCellBorderStyle)Enum.Parse(typeof(TableLayoutPanelCellBorderStyle), searchBorderComboBox.Text);
            settings.searchPanelBorder = searchBorderComboBox.Text;
        }

        private void ToolbarCloseButtonCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.closeToolbarButton.Visible = toolbarCloseButtonCheckBox.Checked;
            settings.toolbarCloseButton = toolbarCloseButtonCheckBox.Checked;
        }

        private void SingleInstanceCheckBox_Click(object sender, EventArgs e)
        {
            settings.singleInstance = singleInstanceCheckBox.Checked;
        }

        private void StatusPanelLengthCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanelLengthLabel.Visible = statusPanelLengthCheckBox.Checked;
            settings.statusPanelLength = statusPanelLengthCheckBox.Checked;
            main.StatusPanelTextInfo();
        }

        private void StatusPanelLinesCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanelLinesLabel.Visible = statusPanelLinesCheckBox.Checked;
            settings.statusPanelLines = statusPanelLinesCheckBox.Checked;
            main.StatusPanelTextInfo();
        }

        private void StatusPanelModifiedCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanelModifiedLabel.Visible = statusPanelModifiedCheckBox.Checked;
            settings.statusPanelModified = statusPanelModifiedCheckBox.Checked;
            main.StatusPanelFileInfo();
        }

        private void StatusPanelSizeCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanelSizeLabel.Visible = statusPanelSizeCheckBox.Checked;
            settings.statusPanelSize = statusPanelSizeCheckBox.Checked;
            main.StatusPanelFileInfo();
        }
        #endregion

        private void StatusPanelReadonlyCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanelReadonlyLabel.Visible = statusPanelReadonlyCheckBox.Checked;
            settings.statusPanelReadonly = statusPanelReadonlyCheckBox.Checked;
            main.StatusPanelFileInfo();
        }

    }
}