using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class SettingsForm : Form
    {
        Properties.Settings ps = Properties.Settings.Default;
        public SettingsForm()
        {
            InitializeComponent();
        }

        /*Functions*/
        private void SetSettings(string value)
        {
            if (value == "save")
            {
                if (AssociateCheckBox.Checked)
                {
                    AssociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
                }
                else
                {
                    DissociateExtension(Assembly.GetEntryAssembly().Location, "cnp");
                }

                if (IntegrateCheckBox.Checked)
                {
                    MenuIntegrate("enable");
                }
                else
                {
                    MenuIntegrate("disable");
                }

                ps.RichForeColor = FontColorPanel.BackColor;
                ps.RichBackColor = BackgroundColorPanel.BackColor;
                ps.RichTextFont = FontNameComboBox.Text;
                ps.RichTextSize = Convert.ToInt32(FontSizeComboBox.Text.ToString());
                ps.AssociateCheck = AssociateCheckBox.Checked;
                ps.HashAlgorithm = HashComboBox.Text;
                ps.KeySize = Convert.ToInt32(KeySizeComboBox.Text.ToString());
                ps.TheSalt = SaltTextBox.Text;
                ps.PasswordIterations = Convert.ToInt32(PwdIterationsTextBox.Text.ToString());
                ps.ShowToolbar = ToolbarCheckBox.Checked;
                ps.AutoCheckUpdate = UpdatesCheckBox.Checked;
                ps.AutoLock = AutoLockCheckBox.Checked;
                ps.AutoSave = AutoSaveCheckBox.Checked;
                ps.SendTo = SendToCheckBox.Checked;
                ps.MenuIntegrate = IntegrateCheckBox.Checked;
                ps.MenuIcons = MenuIconsCheckBox.Checked;
                ps.ColoredToolbar = ToolbarColorCheckBox.Checked;
                ps.LNVisible = LNVisibleComboBox.Text;
                ps.LNBackgroundColor = LNBackgroundColorPanel.BackColor;
                ps.LNFontColorPanel = LNFontColorPanel.BackColor;
                ps.BLColor = BLColorPanel.BackColor;
                ps.BLShow = BLShowСomboBox.Text;
                ps.GLColor = GLColorPanel.BackColor;
                ps.GLShow = GLShowComboBox.Text;
                ps.InserKey = InserKeyComboBox.Text;

                switch (BLStyleComboBox.Text)
                {
                    case "Solid":
                        ps.BLStyle = DashStyle.Solid;
                        break;
                    case "Dash":
                        ps.BLStyle = DashStyle.Dash;
                        break;
                    case "Dot":
                        ps.BLStyle = DashStyle.Dot;
                        break;
                    case "DashDot":
                        ps.BLStyle = DashStyle.DashDot;
                        break;
                    case "DashDotDot":
                        ps.BLStyle = DashStyle.DashDotDot;
                        break;
                }

                switch (GLStyleComboBox.Text)
                {
                    case "Solid":
                        ps.GLStyle = DashStyle.Solid;
                        break;
                    case "Dash":
                        ps.GLStyle = DashStyle.Dash;
                        break;
                    case "Dot":
                        ps.GLStyle = DashStyle.Dot;
                        break;
                    case "DashDot":
                        ps.GLStyle = DashStyle.DashDot;
                        break;
                    case "DashDotDot":
                        ps.GLStyle = DashStyle.DashDotDot;
                        break;
                }

                ps.Save();
                PublicVar.settingsChanged = true;

                Close();
            }

            if (value == "default")
            {
                FontColorPanel.BackColor = Color.FromArgb(228, 228, 228);
                BackgroundColorPanel.BackColor = Color.FromArgb(56, 56, 56);
                FontNameComboBox.Text = "Consolas";
                FontSizeComboBox.Text = 11.ToString();
                AssociateCheckBox.Checked = false;
                UpdatesCheckBox.Checked = true;
                ToolbarCheckBox.Checked = true;
                AutoLockCheckBox.Checked = false;
                AutoSaveCheckBox.Checked = true;
                SendToCheckBox.Checked = false;
                IntegrateCheckBox.Checked = false;
                MenuIconsCheckBox.Checked = false;
                ToolbarColorCheckBox.Checked = false;
                LNVisibleComboBox.Text = "True";
                LNBackgroundColorPanel.BackColor = Color.FromArgb(53, 53, 53);
                LNFontColorPanel.BackColor = Color.FromArgb(164, 164, 164);
                BLShowСomboBox.Text = "False";
                BLColorPanel.BackColor = Color.FromArgb(164, 164, 164);
                BLStyleComboBox.Text = "Solid";
                InserKeyComboBox.Text = "Enable";
            }
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
        /*Functions*/


        /*Form Events*/
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            foreach (FontFamily fonts in FontFamily.Families)
            {
                FontNameComboBox.Items.Add(fonts.Name);
            }

            FontNameComboBox.Text = ps.RichTextFont;
            FontSizeComboBox.Text = ps.RichTextSize.ToString();
            HashComboBox.Text = ps.HashAlgorithm;
            KeySizeComboBox.Text = ps.KeySize.ToString();
            SaltTextBox.Text = ps.TheSalt;
            PwdIterationsTextBox.Text = ps.PasswordIterations.ToString();
            FontColorPanel.BackColor = ps.RichForeColor;
            BackgroundColorPanel.BackColor = ps.RichBackColor;
            AssociateCheckBox.Checked = ps.AssociateCheck;
            UpdatesCheckBox.Checked = ps.AutoCheckUpdate;
            ToolbarCheckBox.Checked = ps.ShowToolbar;
            AutoLockCheckBox.Checked = ps.AutoLock;
            AutoSaveCheckBox.Checked = ps.AutoSave;
            SendToCheckBox.Checked = ps.SendTo;
            IntegrateCheckBox.Checked = ps.MenuIntegrate;
            MenuIconsCheckBox.Checked = ps.MenuIcons;
            ToolbarColorCheckBox.Checked = ps.ColoredToolbar;
            LNVisibleComboBox.Text = ps.LNVisible;
            LNBackgroundColorPanel.BackColor = ps.LNBackgroundColor;
            LNFontColorPanel.BackColor = ps.LNFontColorPanel;
            BLShowСomboBox.Text = ps.BLShow;
            BLColorPanel.BackColor = ps.BLColor;
            BLStyleComboBox.Text = ps.BLStyle.ToString();
            GLShowComboBox.Text = ps.GLShow;
            GLColorPanel.BackColor = ps.GLColor;
            GLStyleComboBox.Text = ps.GLStyle.ToString();
            InserKeyComboBox.Text = ps.InserKey;

            if (!ps.ShowToolbar)
            {
                ToolbarColorCheckBox.Enabled = false;
            }

            if (ps.TheSalt != "")
            {
                SaltTextBox.Visible = true;
                SaltLabel.Visible = true;
            }

            string custom_colors = ps.CustomColor;
            int[] array_of_colors = custom_colors.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
            colorDialog.CustomColors = array_of_colors;
        }
        /*Form Events*/


        /*Buttons*/
        private void ResetSettingsButton_Click(object sender, EventArgs e)
        {
            using (new CenterWinDialog(this))
            {
                DialogResult result = MessageBox.Show("Reset app settings to default?", "Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SetSettings("default");
                }
            }
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SetSettings("save");
        }
        /*Buttons*/


        /*Settings Section*/
        private void FontColorPanel_Click_1(object sender, EventArgs e)
        {
            colorDialog.Color = FontColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog.ShowDialog();
            }
            FontColorPanel.BackColor = colorDialog.Color;
        }

        private void BackgroundColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = BackgroundColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog.ShowDialog();
            }
            BackgroundColorPanel.BackColor = colorDialog.Color;
        }

        private void ToolbarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ToolbarCheckBox.Checked)
            {
                ToolbarColorCheckBox.Enabled = false;
            }
            else
            {
                ToolbarColorCheckBox.Enabled = true;
            }
        }

        private void LNBackgroundColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = LNBackgroundColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog.ShowDialog();
            }
            LNBackgroundColorPanel.BackColor = colorDialog.Color;
        }

        private void LNFontColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = LNFontColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog.ShowDialog();
            }
            LNFontColorPanel.BackColor = colorDialog.Color;
        }

        private void BLColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = BLColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog.ShowDialog();
            }
            BLColorPanel.BackColor = colorDialog.Color;
        }

        private void GLColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.Color = GLColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog.ShowDialog();
            }
            GLColorPanel.BackColor = colorDialog.Color;
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            string result = string.Join(";", colorDialog.CustomColors);
            ps.CustomColor = result;
            ps.Save();
        }

        /*Settings Section*/
    }
}
