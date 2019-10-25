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


        /*Methods*/
        private void LoadSettings()
        {
            editorFontColor.BackColor = settings.editroForeColor;
            editorBackColor.BackColor = settings.editorBackColor;
            editorInsertKeyComboBox.Text = settings.insertKey;
            editorPaddingLeftTextBox.Text = settings.editorPaddingLeft;
            editorOpenLinksWithComboBox.Text = settings.openLinks;
            editorBorderComboBox.Text = settings.editorBorder;
            fontDialog.Font = settings.editorFont;

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
        }

        private static void AssociateExtension(string applicationExecutablePath, string extension)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Classes", true);
                key.CreateSubKey("." + extension).SetValue(string.Empty, extension + "_auto_file");
                key = key.CreateSubKey(extension + "_auto_file");
                key.CreateSubKey("DefaultIcon").SetValue(string.Empty, applicationExecutablePath + ",0");
                key = key.CreateSubKey("Shell");
                key.SetValue(string.Empty, "Open");
                key = key.CreateSubKey("Open");
                key.CreateSubKey("Command").SetValue(string.Empty, "\"" + applicationExecutablePath + "\" \"%1\" /o");
                key.CreateSubKey("ddeexec\\Topic").SetValue(string.Empty, "System");
            }
            catch (Exception)
            {

            }
        }

        private static void DissociateExtension(string applicationExecutablePath, string extension)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Classes", true);
                RegistryKey subKeyTree = Registry.CurrentUser.OpenSubKey(@"Software\Classes\" + extension + "_auto_file", true);
                if (subKeyTree != null)
                {
                    key.DeleteSubKeyTree(extension + "_auto_file");
                    key.DeleteSubKeyTree("." + extension);
                }
            }
            catch { }
        }

        private static void MenuIntegrate(string action)
        {
            string appExePath = Assembly.GetEntryAssembly().Location;
            try
            {
                if (action == "enable")
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Classes\*\", true);
                    key = key.CreateSubKey("shell");
                    key.CreateSubKey("Crypto Notepad").SetValue("icon", appExePath);
                    key.CreateSubKey("Crypto Notepad").SetValue("SubCommands", "");
                    key.CreateSubKey(@"Crypto Notepad\shell");
                    key.CreateSubKey(@"Crypto Notepad\shell\cmd1\").SetValue("MUIVerb", "Encrypt");
                    key.CreateSubKey(@"Crypto Notepad\shell\cmd1\command").SetValue(string.Empty, "\"" + appExePath + "\" \"%1\" /er");
                    key.CreateSubKey(@"Crypto Notepad\shell\cmd2\").SetValue("MUIVerb", "Decrypt");
                    key.CreateSubKey(@"Crypto Notepad\shell\cmd2\command").SetValue(string.Empty, "\"" + appExePath + "\" \"%1\" /o");

                }

                if (action == "disable")
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Classes\*\shell\", true);
                    RegistryKey subKeyTree = Registry.CurrentUser.OpenSubKey(@"Software\Classes\*\shell\Crypto Notepad", true);
                    if (subKeyTree != null)
                    {
                        key.DeleteSubKeyTree("Crypto Notepad");
                    }
                }
            }
            catch { }
        }

        private void SendToShortcut()
        {
            string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft\Windows\SendTo";
            string shortcutName = PublicVar.appName + ".lnk";
            string shortcutLocation = Path.Combine(shortcutPath, shortcutName);
            string targetFileLocation = Assembly.GetEntryAssembly().Location;
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            shortcut.Description = PublicVar.appName;
            shortcut.IconLocation = targetFileLocation;
            shortcut.TargetPath = targetFileLocation;
            shortcut.Arguments = "/s";
            shortcut.Save();
        }
        /*Methods*/


        /*Form Events*/
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
        /*Form Events*/


        /*Settings Section*/
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
                AssociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
            }
            else
            {
                DissociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
            }
            settings.explorerAssociate = associateCheckBox.Checked;

        }

        private void IntegrateCheckBox_Click(object sender, EventArgs e)
        {
            if (integrateCheckBox.Checked)
            {
                MenuIntegrate("enable");
            }
            else
            {
                MenuIntegrate("disable");
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

        private void SendToCheckBox_Click(object sender, EventArgs e)
        {
            if (sendToCheckBox.Checked)
            {
                SendToShortcut();
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

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.richTextBox.Font = fontDialog.Font;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            settings.editorFont = fontDialog.Font;
        }

        private void StatusPanelVisibleCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanel.Visible = statusPanelVisibleCheckBox.Checked;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(editorPaddingLeftTextBox.Text), 0, 0, 0);
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
        /*Settings Section*/


    }
}