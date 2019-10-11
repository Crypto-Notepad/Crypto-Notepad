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
            pnlEditorFontColor.BackColor = settings.editroForeColor;
            pnlEditorBackColor.BackColor = settings.editorBackColor;
            cbxInsKey.Text = settings.insKey;
            txtPaddingLeft.Text = settings.editorPaddingLeft;
            cbxOpenLinks.Text = settings.openLinks;
            fontDialog.Font = settings.editorFont;

            chkAutoLock.Checked = settings.autoLock;
            chkUpdates.Checked = settings.autoCheckUpdate;
            chkMainMenu.Checked = settings.mainMenuVisible;
            chkMenuIcons.Checked = settings.menuIcons;
            chkMinimizeToTray.Checked = settings.minimizeToTray;
            chkCloseToTray.Checked = settings.closeToTray;

            chkIntegrate.Checked = settings.explorerIntegrate;
            chkAssociate.Checked = settings.explorerAssociate;
            chkSendTo.Checked = settings.explorerSendTo;

            cboHash.Text = settings.HashAlgorithm;
            cboKeySize.Text = settings.KeySize;
            txtPwdIterations.Text = settings.PasswordIterations;

            searchBackColor.BackColor = settings.searchPanelBackColor;
            searchFontColor.BackColor = settings.searchPanelForeColor;

            toolbarBackColor.BackColor = settings.toolbarBackColor;
            toolbarBorder.Checked = settings.toolbarBorder;
            toolbarVisible.Checked = settings.toolbarVisible;
            toolbarOldIcons.Checked = settings.oldToolbarIcons;

            statusBackColor.BackColor = settings.statusPanelBackColor;
            statusFontColor.BackColor = settings.statusPanelFontColor;
            statusPanelVisible.Checked = settings.statusPanelVisible;

            LNVisibleComboBox.Text = settings.lnVisible;
            LNBackColor.BackColor = settings.lnBackColor;
            LNFontColor.BackColor = settings.lnForeColor;
            BLShowСomboBox.Text = settings.blShow;
            BLColor.BackColor = settings.blColor;
            BLStyleComboBox.Text = settings.blStyle;
            GLShowComboBox.Text = settings.glShow;
            GLColor.BackColor = settings.glColor;
            GLStyleComboBox.Text = settings.glStyle;

            MLVisibleComboBox.Text = settings.mlVisible;
            MLColor.BackColor = settings.mlColor;
            MLStyleComboBox.Text = settings.mlStyle;
            MLSideComboBox.Text = settings.mlSide;
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
            lstSettingsNav.SelectedIndex = 0;
            TopMost = settings.alwaysOnTop;
            LoadSettings();
        }

        private void TxtPaddingLeft_Click(object sender, EventArgs e)
        {
            txtPaddingLeft.SelectAll();
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
            if (string.IsNullOrWhiteSpace(txtPaddingLeft.Text))
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
            colorDialog.Color = pnlEditorFontColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.ForeColor = colorDialog.Color;
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
                    settings.editroForeColor = colorDialog.Color;
                    pnlEditorFontColor.BackColor = colorDialog.Color;
                }
            }
        }
        private void EditorBGColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = pnlEditorBackColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.richTextBox.BackColor = colorDialog.Color;
                    main.BackColor = colorDialog.Color;
                    settings.editorBackColor = colorDialog.Color;
                    pnlEditorBackColor.BackColor = colorDialog.Color;
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
                    LNBackColor.BackColor = colorDialog.Color;
                    settings.lnBackColor = colorDialog.Color;
                }
            }
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
                    LNFontColor.BackColor = colorDialog.Color;
                    settings.lnForeColor = colorDialog.Color;
                }
            }
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
                    BLColor.BackColor = colorDialog.Color;
                    settings.blColor = colorDialog.Color;
                }
            }
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
                    GLColor.BackColor = colorDialog.Color;
                    settings.glColor = colorDialog.Color;
                }
            }
        }

        private void LstSettingsNav_Click(object sender, EventArgs e)
        {
            switch (lstSettingsNav.SelectedIndex)
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
            main.toolbarPanel.Visible = toolbarVisible.Checked;
            main.RTBLineNumbers.Height = 1;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(settings.editorPaddingLeft), 0, 0, 0);
            settings.toolbarVisible= toolbarVisible.Checked;
        }

        private void AssociateCheckBox_Click(object sender, EventArgs e)
        {
            if (chkAssociate.Checked)
            {
                AssociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
            }
            else
            {
                DissociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
            }
            settings.explorerAssociate = chkAssociate.Checked;

        }

        private void IntegrateCheckBox_Click(object sender, EventArgs e)
        {
            if (chkIntegrate.Checked)
            {
                MenuIntegrate("enable");
            }
            else
            {
                MenuIntegrate("disable");
            }
            settings.explorerIntegrate = chkIntegrate.Checked;
        }

        private void TxtPaddingLeft_TextChanged(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (txtPaddingLeft.Text.Length >= 1)
            {
                if (settings.editorPaddingLeft != txtPaddingLeft.Text)
                {
                    main.richTextBox.SetInnerMargins(Convert.ToInt32(txtPaddingLeft.Text), 0, 0, 0);
                    main.richTextBox.Refresh();
                    settings.editorPaddingLeft = txtPaddingLeft.Text;
                }
            }
        }

        private void SendToCheckBox_Click(object sender, EventArgs e)
        {
            if (chkSendTo.Checked)
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
            settings.explorerSendTo = chkSendTo.Checked;

        }

        private void InsKeyComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.insKey != cbxInsKey.Text)
            {
                if (cbxInsKey.Text == "Disable")
                {
                    main.insMainMenu.ShortcutKeys = Keys.Insert;
                }
                else
                {
                    main.insMainMenu.ShortcutKeys = Keys.None;
                }
                settings.insKey = cbxInsKey.Text;
            }
        }

        private void MenuIconsCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            settings.menuIcons = chkMenuIcons.Checked;
            main.MenuIcons(settings.menuIcons);
        }

        private void BtnFont_Click(object sender, EventArgs e)
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
                settings.lnVisible = LNVisibleComboBox.Text;
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

        private void KeySizeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (cboKeySize.Text != settings.KeySize)
            {
                settings.KeySize = cboKeySize.Text;
            }
        }

        private void HashComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (cboHash.Text != settings.HashAlgorithm)
            {
                settings.HashAlgorithm = cboHash.Text;
            }
        }

        private void TxtPaddingLeft_KeyPress(object sender, KeyPressEventArgs e)
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
            settings.editorFont = fontDialog.Font;
        }

        private void StatusPanelVisible_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            main.statusPanel.Visible = statusPanelVisible.Checked;
            main.richTextBox.SetInnerMargins(Convert.ToInt32(txtPaddingLeft.Text), 0, 0, 0);
            settings.statusPanelVisible = statusPanelVisible.Checked;
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
                    statusBackColor.BackColor = colorDialog.Color;
                    settings.statusPanelBackColor = colorDialog.Color;
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
                    statusFontColor.BackColor = colorDialog.Color;
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
        
        private void ToolbarBorder_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (toolbarBorder.Checked)
            {
                main.toolbarPanel.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                main.toolbarPanel.BorderStyle = BorderStyle.None;
            }
            settings.toolbarBorder = toolbarBorder.Checked;
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
                    main.caseSensitiveCheckBox.ForeColor = colorDialog.Color;
                    main.wholeWordCheckBox.ForeColor = colorDialog.Color;
                    main.findNextButton.ForeColor = colorDialog.Color;
                    settings.searchPanelForeColor = colorDialog.Color;
                    searchFontColor.BackColor = colorDialog.Color;
                }
            }
        }

        private void MainMenuCheckBox_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (chkMainMenu.Checked)
            {
                main.mainMenu.Visible = true;
            }
            else
            {
                main.mainMenu.Visible = false;
            }
            settings.mainMenuVisible = chkMainMenu.Checked;
        }

        private void ToolbarOldIcons_Click(object sender, EventArgs e)
        {
            settings.oldToolbarIcons = toolbarOldIcons.Checked;
            MainForm main = Owner as MainForm;
            main.Toolbaricons(settings.oldToolbarIcons);
        }

        private void CbxOpenLinks_DropDownClosed(object sender, EventArgs e)
        {
            if (settings.openLinks != cbxOpenLinks.Text)
            {
                settings.openLinks = cbxOpenLinks.Text;
            }

        }

        private void AutoLockCheckBox_Click(object sender, EventArgs e)
        {
            settings.autoLock = chkAutoLock.Checked;
        }

        private void UpdatesCheckBox_Click(object sender, EventArgs e)
        {
            settings.autoCheckUpdate = chkUpdates.Checked;

        }

        private void PwdIterationsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (txtPwdIterations.Text != settings.PasswordIterations)
            {
                settings.PasswordIterations = txtPwdIterations.Text;
            }
        }

        private void MLVisibleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.mlVisible != MLVisibleComboBox.Text)
            {
                settings.mlVisible = MLVisibleComboBox.Text;
                main.RTBLineNumbers.Show_MarginLines = bool.Parse(settings.mlVisible);
            }
        }

        private void MLSideComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.mlSide.ToString() != MLSideComboBox.Text)
            {
                switch (MLSideComboBox.Text)
                {
                    case "None":
                        settings.mlSide = LineNumbers.LineNumbers.LineNumberDockSide.None.ToString();
                        break;
                    case "Left":
                        settings.mlSide = LineNumbers.LineNumbers.LineNumberDockSide.Left.ToString();
                        break;
                    case "Right":
                        settings.mlSide = LineNumbers.LineNumbers.LineNumberDockSide.Right.ToString();
                        break;
                    case "Height":
                        settings.mlSide = LineNumbers.LineNumbers.LineNumberDockSide.Height.ToString();
                        break;
                }
                main.RTBLineNumbers.MarginLines_Side = (LineNumbers.LineNumbers.LineNumberDockSide)Enum.Parse(typeof(LineNumbers.LineNumbers.LineNumberDockSide), settings.mlSide);
            }
        }

        private void MLStyleComboBox_DropDownClosed(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (settings.mlStyle != MLStyleComboBox.Text)
            {
                switch (MLStyleComboBox.Text)
                {
                    case "Solid":
                        settings.mlStyle = DashStyle.Solid.ToString();
                        break;
                    case "Dash":
                        settings.mlStyle = DashStyle.Dash.ToString();
                        break;
                    case "Dot":
                        settings.mlStyle = DashStyle.Dot.ToString();
                        break;
                    case "DashDot":
                        settings.mlStyle = DashStyle.DashDot.ToString();
                        break;
                    case "DashDotDot":
                        settings.mlStyle = DashStyle.DashDotDot.ToString();
                        break;
                }
                main.RTBLineNumbers.MarginLines_Style = (DashStyle)Enum.Parse(typeof(DashStyle), settings.mlStyle);
            }
        }

        private void MLColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = MLColor.BackColor;
            using (new CenterWinDialog(this))
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm main = Owner as MainForm;
                    main.RTBLineNumbers.MarginLines_Color = colorDialog.Color;
                    MLColor.BackColor = colorDialog.Color;
                    settings.mlColor = colorDialog.Color;
                }
            }
        }

        private void ChkMinimizeToTray_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (chkCloseToTray.Checked == false & chkMinimizeToTray.Checked == false)
            {
                main.trayIcon.Visible = false;
            }
            if (chkMinimizeToTray.Checked == true)
            {
                main.trayIcon.Visible = true;
            }
            settings.minimizeToTray = chkMinimizeToTray.Checked;
        }

        private void ChkCloseToTray_Click(object sender, EventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (chkCloseToTray.Checked == false & chkMinimizeToTray.Checked ==false )
            {
                main.trayIcon.Visible = false;
            }
            if (chkCloseToTray.Checked == true)
            {
                main.trayIcon.Visible = true;
            }
            settings.closeToTray = chkCloseToTray.Checked;
        }
        /*Settings Section*/


    }
}