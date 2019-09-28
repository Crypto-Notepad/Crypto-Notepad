using IWshRuntimeLibrary;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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


        /*Functions*/   
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
        /*Functions*/


        /*Form Events*/
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string custom_colors = settings.customColor;
            int[] array_of_colors = custom_colors.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
            colorDialog.CustomColors = array_of_colors;

            settingsTabControl.Appearance = TabAppearance.FlatButtons;
            settingsTabControl.ItemSize = new Size(0, 1);
            settingsTabControl.SizeMode = TabSizeMode.Fixed;
            settingsNav.SelectedIndex = 0;
        }

        private void PaddingLeftTextBox_Click(object sender, EventArgs e)
        {
            paddingLeftTextBox.SelectAll();
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
            if (string.IsNullOrWhiteSpace(paddingLeftTextBox.Text))
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
                }
            }
        }
        private void EditorBGColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = editorBGColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.BackColor = colorDialog.Color;
                    main.BackColor = colorDialog.Color;
                }
            }
        }

        private void LNBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = LNBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.RTBLineNumbers.BackColor = colorDialog.Color;
                }
            }
            LNBackColor.BackColor = colorDialog.Color;
        }

        private void LNFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = LNFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.RTBLineNumbers.ForeColor = colorDialog.Color;
                }
            }
            LNFontColor.BackColor = colorDialog.Color;
        }

        private void BLColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = BLColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.RTBLineNumbers.BorderLines_Color = colorDialog.Color;
                }
            }
            BLColor.BackColor = colorDialog.Color;
        }

        private void GLColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = GLColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.RTBLineNumbers.GridLines_Color = colorDialog.Color;
                }
            }
            GLColor.BackColor = colorDialog.Color;
        }

        private void SettingsNav_Click(object sender, EventArgs e)
        {
            switch (settingsNav.SelectedIndex)
            {
                case 0:
                    settingsTabControl.SelectedTab = editorTabPage;
                    break;
                case 1:
                    settingsTabControl.SelectedTab = lineNumbersTabPage;
                    break;
                case 2:
                    settingsTabControl.SelectedTab = statusPanelTabPage;
                    break;
                case 3:
                    settingsTabControl.SelectedTab = toolbarTabPage;
                    break;
                case 4:
                    settingsTabControl.SelectedTab = applicationTabPage;
                    break;
                case 5:
                    settingsTabControl.SelectedTab = searchPanelTabPage;
                    break;
                case 6:
                    settingsTabControl.SelectedTab = integrationTabPage;
                    break;
                case 7:
                    settingsTabControl.SelectedTab = encryptionTabPage;
                    break;
            }
        }

        private void SettingsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            settingsTabControl.Focus();
        }

        private void ToolbarVisible_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (main != null)
            {
                if (toolbarVisible.Checked)
                {
                    main.toolbarPanel.Visible = true;
                    main.RTBLineNumbers.Height = 1;
                }
                else
                {
                    main.toolbarPanel.Visible = false;
                }
                main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            }
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
        }

        private void PaddingLeftTextBox_TextChanged(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (paddingLeftTextBox.Text.Length >= 1)
            {
                if (settings.editorPaddingLeft != paddingLeftTextBox.Text)
                {
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(paddingLeftTextBox.Text), 0, 0, 0);
                    main.richTextBox.Refresh();
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
        }

        private void InsKeyComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (insKeyComboBox.Text == "Disable")
            {
                main.insMainMenu.ShortcutKeys = Keys.Insert;
            }
            else
            {
                main.insMainMenu.ShortcutKeys = Keys.None;
            }
        }

        private void MenuIconsCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.MenuIcons();
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(this))
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.Font = fontDialog.Font;
                    main.RTBLineNumbers.Font = fontDialog.Font;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
                }
            }
        }

        private void LNVisibleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.lnVisible != LNVisibleComboBox.Text)
            {
                settings.lnVisible = LNVisibleComboBox.Text;
                main.RTBLineNumbers.Visible = bool.Parse(settings.lnVisible);
                main.RTBLineNumbers.Height = 1;
            }
        }

        private void BLShowСomboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.blShow != BLShowСomboBox.Text)
            {
                settings.blShow = BLShowСomboBox.Text;
                main.RTBLineNumbers.Show_BorderLines = bool.Parse(settings.blShow);
            }
        }

        private void BLStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.blStyle != BLStyleComboBox.Text)
            {
                switch (BLStyleComboBox.Text)
                {
                    case "Solid":
                        settings.blStyle = DashStyle.Solid.ToString();
                        break;
                    case "Dash":
                        settings.blStyle = DashStyle.Dash.ToString();
                        break;
                    case "Dot":
                        settings.blStyle = DashStyle.Dot.ToString();
                        break;
                    case "DashDot":
                        settings.blStyle = DashStyle.DashDot.ToString();
                        break;
                    case "DashDotDot":
                        settings.blStyle = DashStyle.DashDotDot.ToString();
                        break;
                }
                main.RTBLineNumbers.BorderLines_Style = (DashStyle)Enum.Parse(typeof(DashStyle), settings.blStyle);
            }
        }

        private void GLShowComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.glShow != GLShowComboBox.Text)
            {
                settings.glShow = GLShowComboBox.Text;
                main.RTBLineNumbers.Show_GridLines = bool.Parse(settings.glShow);
            }
        }

        private void GLStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.glStyle.ToString() != GLStyleComboBox.Text)
            {
                switch (GLStyleComboBox.Text)
                {
                    case "Solid":
                        settings.glStyle = DashStyle.Solid.ToString(); ;
                        break;
                    case "Dash":
                        settings.glStyle = DashStyle.Dash.ToString();
                        break;
                    case "Dot":
                        settings.glStyle = DashStyle.Dot.ToString();
                        break;
                    case "DashDot":
                        settings.glStyle = DashStyle.DashDot.ToString();
                        break;
                    case "DashDotDot":
                        settings.glStyle = DashStyle.DashDotDot.ToString();
                        break;
                }
                main.RTBLineNumbers.GridLines_Style = (DashStyle)Enum.Parse(typeof(DashStyle), settings.glStyle);
            }
        }

        private void PwdIterationsTextBox_Leave(object sender, EventArgs e)
        {
            if (pwdIterationsTextBox.Text != settings.PasswordIterations.ToString())
            {
                settings.PasswordIterations = pwdIterationsTextBox.Text;
            }
        }

        private void KeySizeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (keySizeComboBox.Text != settings.KeySize.ToString())
            {
                settings.KeySize = keySizeComboBox.Text;
            }
        }

        private void HashComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (hashComboBox.Text != settings.HashAlgorithm)
            {
                settings.HashAlgorithm = hashComboBox.Text;
            }
        }

        private void PaddingLeftTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PwdIterationsTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            main.RTBLineNumbers.Font = fontDialog.Font;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
        }

        private void StatusPanelVisible_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (statusPanelVisible.Checked)
            {
                main.statusPanel.Visible = true;
            }
            else
            {
                main.statusPanel.Visible = false;
            }
            main.richTextBox.SetInnerMargins(Convert.ToInt32(paddingLeftTextBox.Text), 0, 0, 0);
        }

        private void StatusBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = statusBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.statusPanel.BackColor = colorDialog.Color;
                }
            }
        }

        private void StatusFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = statusFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.statusPanel.ForeColor = colorDialog.Color;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
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
                }
            }
        }    
        
        private void ToolbarBorder_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (toolbarBorder.Checked)
            {
                main.toolbarPanel.BorderStyle = BorderStyle.FixedSingle;
                settings.toolbarBorder = true;
            }
            else
            {
                main.toolbarPanel.BorderStyle = BorderStyle.None;
                settings.toolbarBorder = false;
            }
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
                    main.caseSensitiveCheckBox.ForeColor = colorDialog.Color;
                    main.wholeWordCheckBox.ForeColor = colorDialog.Color;
                    main.findNextButton.ForeColor = colorDialog.Color;
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
        }
        /*Settings Section*/


    }
}