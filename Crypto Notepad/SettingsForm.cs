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

            integrateCheckBox.Checked = settings.explorerIntegrate;
            associateCheckBox.Checked = settings.explorerAssociate;
            sendToCheckBox.Checked = settings.explorerSendTo;

            hashAlgorithmComboBox.Text = settings.HashAlgorithm;
            keySizeComboBox.Text = settings.KeySize;
            passwordIterationsTextBox.Text = settings.PasswordIterations;

            searchBackColor.BackColor = settings.searchPanelBackColor;
            searchFontColor.BackColor = settings.searchPanelForeColor;

            toolbarBackColor.BackColor = settings.toolbarBackColor;
            toolbarBorderCheckBox.Checked = settings.toolbarBorder;
            toolbarVisibleCheckBox.Checked = settings.toolbarVisible;
            toolbarOldIconsCheckBox.Checked = settings.oldToolbarIcons;

            statusPanelBackColor.BackColor = settings.statusPanelBackColor;
            statusPanelFontColor.BackColor = settings.statusPanelFontColor;
            statusPanelVisibleCheckBox.Checked = settings.statusPanelVisible;

            lineNumbersVisibleComboBox.Text = settings.lineNumbersVisible;
            lineNumbersBackColor.BackColor = settings.lineNumbersBackColor;
            lineNumbersFontColor.BackColor = settings.lineNumbersForeColor;
            borderLinesVisibleСomboBox.Text = settings.borderLinesVisible;
            borderLinesColor.BackColor = settings.borderLinesColor;
            borderLinesStyleComboBox.Text = settings.borderLinesStyle;
            gridLinesVisibleComboBox.Text = settings.gridLinesVisible;
            gridLinesColor.BackColor = settings.gridLinesColor;
            gridLinesStyleComboBox.Text = settings.gridLinesStyle;

            marginLinesVisibleComboBox.Text = settings.marginLinesVisible;
            marginLinesColor.BackColor = settings.marginLinesColor;
            marginLinesStyleComboBox.Text = settings.marginLinesStyle;
            marginLinesSideComboBox.Text = settings.marginLinesSide;
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

        private void LineNumbersBackColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = lineNumbersBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.lineNumbers.BackColor = colorDialog.Color;
                    lineNumbersBackColor.BackColor = colorDialog.Color;
                    settings.lineNumbersBackColor = colorDialog.Color;
                }
            }
        }

        private void LineNumbersFontColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = lineNumbersFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.lineNumbers.ForeColor = colorDialog.Color;
                    lineNumbersFontColor.BackColor = colorDialog.Color;
                    settings.lineNumbersForeColor = colorDialog.Color;
                }
            }
        }

        private void BorderLinesColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = borderLinesColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.lineNumbers.BorderLines_Color = colorDialog.Color;
                    borderLinesColor.BackColor = colorDialog.Color;
                    settings.borderLinesColor = colorDialog.Color;
                }
            }
        }

        private void GridLinesColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = gridLinesColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.lineNumbers.GridLines_Color = colorDialog.Color;
                    gridLinesColor.BackColor = colorDialog.Color;
                    settings.gridLinesColor = colorDialog.Color;
                }
            }
        }

        private void SettingsNavigation_Click(object sender, EventArgs e)
        {
            switch (settingsNavigation.SelectedIndex)
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

        private void ToolbarVisibleCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.toolbarPanel.Visible = toolbarVisibleCheckBox.Checked;
            main.lineNumbers.Height = 1;
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
                    main.lineNumbers.Font = fontDialog.Font;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
                }
            }
        }

        private void LineNumbersVisibleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.lineNumbersVisible != lineNumbersVisibleComboBox.Text)
            {
                settings.lineNumbersVisible = lineNumbersVisibleComboBox.Text;
                main.lineNumbers.Visible = bool.Parse(settings.lineNumbersVisible);
                main.lineNumbers.Height = 1;
                settings.lineNumbersVisible = lineNumbersVisibleComboBox.Text;
            }
        }

        private void BorderLinesVisibleСomboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.borderLinesVisible != borderLinesVisibleСomboBox.Text)
            {
                settings.borderLinesVisible = borderLinesVisibleСomboBox.Text;
                main.lineNumbers.Show_BorderLines = bool.Parse(settings.borderLinesVisible);
            }
        }

        private void BorderLinesStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.borderLinesStyle != borderLinesStyleComboBox.Text)
            {
                switch (borderLinesStyleComboBox.Text)
                {
                    case "Solid":
                        settings.borderLinesStyle = DashStyle.Solid.ToString();
                        break;
                    case "Dash":
                        settings.borderLinesStyle = DashStyle.Dash.ToString();
                        break;
                    case "Dot":
                        settings.borderLinesStyle = DashStyle.Dot.ToString();
                        break;
                    case "DashDot":
                        settings.borderLinesStyle = DashStyle.DashDot.ToString();
                        break;
                    case "DashDotDot":
                        settings.borderLinesStyle = DashStyle.DashDotDot.ToString();
                        break;
                }
                main.lineNumbers.BorderLines_Style = (DashStyle)Enum.Parse(typeof(DashStyle), settings.borderLinesStyle);
            }
        }

        private void GridLinesVisibleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.gridLinesVisible != gridLinesVisibleComboBox.Text)
            {
                settings.gridLinesVisible = gridLinesVisibleComboBox.Text;
                main.lineNumbers.Show_GridLines = bool.Parse(settings.gridLinesVisible);
            }
        }

        private void GridLinesStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.gridLinesStyle.ToString() != gridLinesStyleComboBox.Text)
            {
                switch (gridLinesStyleComboBox.Text)
                {
                    case "Solid":
                        settings.gridLinesStyle = DashStyle.Solid.ToString(); ;
                        break;
                    case "Dash":
                        settings.gridLinesStyle = DashStyle.Dash.ToString();
                        break;
                    case "Dot":
                        settings.gridLinesStyle = DashStyle.Dot.ToString();
                        break;
                    case "DashDot":
                        settings.gridLinesStyle = DashStyle.DashDot.ToString();
                        break;
                    case "DashDotDot":
                        settings.gridLinesStyle = DashStyle.DashDotDot.ToString();
                        break;
                }
                main.lineNumbers.GridLines_Style = (DashStyle)Enum.Parse(typeof(DashStyle), settings.gridLinesStyle);
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
            main.lineNumbers.Font = fontDialog.Font;
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
            main.Toolbaricons(settings.oldToolbarIcons);
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

        private void MarginLinesVisibleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.marginLinesVisible != marginLinesVisibleComboBox.Text)
            {
                settings.marginLinesVisible = marginLinesVisibleComboBox.Text;
                main.lineNumbers.Show_MarginLines = bool.Parse(settings.marginLinesVisible);
            }
        }

        private void MarginLinesSideComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.marginLinesSide.ToString() != marginLinesSideComboBox.Text)
            {
                switch (marginLinesSideComboBox.Text)
                {
                    case "None":
                        settings.marginLinesSide = LineNumbers.LineNumbers.LineNumberDockSide.None.ToString();
                        break;
                    case "Left":
                        settings.marginLinesSide = LineNumbers.LineNumbers.LineNumberDockSide.Left.ToString();
                        break;
                    case "Right":
                        settings.marginLinesSide = LineNumbers.LineNumbers.LineNumberDockSide.Right.ToString();
                        break;
                    case "Height":
                        settings.marginLinesSide = LineNumbers.LineNumbers.LineNumberDockSide.Height.ToString();
                        break;
                }
                main.lineNumbers.MarginLines_Side = (LineNumbers.LineNumbers.LineNumberDockSide)Enum.Parse(typeof(LineNumbers.LineNumbers.LineNumberDockSide), settings.marginLinesSide);
            }
        }

        private void MarginLinesStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.marginLinesStyle != marginLinesStyleComboBox.Text)
            {
                switch (marginLinesStyleComboBox.Text)
                {
                    case "Solid":
                        settings.marginLinesStyle = DashStyle.Solid.ToString();
                        break;
                    case "Dash":
                        settings.marginLinesStyle = DashStyle.Dash.ToString();
                        break;
                    case "Dot":
                        settings.marginLinesStyle = DashStyle.Dot.ToString();
                        break;
                    case "DashDot":
                        settings.marginLinesStyle = DashStyle.DashDot.ToString();
                        break;
                    case "DashDotDot":
                        settings.marginLinesStyle = DashStyle.DashDotDot.ToString();
                        break;
                }
                main.lineNumbers.MarginLines_Style = (DashStyle)Enum.Parse(typeof(DashStyle), settings.marginLinesStyle);
            }
        }

        private void MarginLinesColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = marginLinesColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.lineNumbers.MarginLines_Color = colorDialog.Color;
                    marginLinesColor.BackColor = colorDialog.Color;
                    settings.marginLinesColor = colorDialog.Color;
                }
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

        /*Settings Section*/


    }
}