using Microsoft.Win32;
using System;
using System.Drawing;
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
                ps.HighlightsColor = HighlightsColorPanel.BackColor;
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
                ps.Save();
                PublicVar.settingsChanged = true;

                this.Hide();
            }

            if (value == "default")
            {
                FontColorPanel.BackColor = Color.FromArgb(228, 228, 228);
                BackgroundColorPanel.BackColor = Color.FromArgb(56, 56, 56);
                HighlightsColorPanel.BackColor = Color.FromArgb(101, 51, 6);
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
            HighlightsColorPanel.BackColor = ps.HighlightsColor;
            AssociateCheckBox.Checked = ps.AssociateCheck;
            UpdatesCheckBox.Checked = ps.AutoCheckUpdate;
            ToolbarCheckBox.Checked = ps.ShowToolbar;
            AutoLockCheckBox.Checked = ps.AutoLock;
            AutoSaveCheckBox.Checked = ps.AutoSave;
            SendToCheckBox.Checked = ps.SendTo;
            IntegrateCheckBox.Checked = ps.MenuIntegrate;
            MenuIconsCheckBox.Checked = ps.MenuIcons;
            ToolbarColorCheckBox.Checked = ps.ColoredToolbar;

            if (!ps.ShowToolbar)
            {
                ToolbarColorCheckBox.Checked = false;
                ToolbarColorCheckBox.Enabled = false;
            }

            if (ps.TheSalt != "")
            {
                SaltTextBox.Visible = true;
                SaltLabel.Visible = true;
            }
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
            colorDialog1.Color = FontColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog1.ShowDialog();
            }
            FontColorPanel.BackColor = colorDialog1.Color;
        }

        private void BackgroundColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = BackgroundColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog1.ShowDialog();
            }
            BackgroundColorPanel.BackColor = colorDialog1.Color;
        }

        private void HighlightsColorPanel_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = HighlightsColorPanel.BackColor;
            using (new CenterWinDialog(this))
            {
                colorDialog1.ShowDialog();
            }
            HighlightsColorPanel.BackColor = colorDialog1.Color;
        }

        private void ToolbarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ToolbarCheckBox.Checked)
            {
                ToolbarColorCheckBox.Checked = false;
                ToolbarColorCheckBox.Enabled = false;
            }
            else
            {
                ToolbarColorCheckBox.Enabled = true;
            }
        }
        /*Settings Section*/
    }
}
