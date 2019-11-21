using JCS;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class AboutFrom : Form
    {
        private Random rnd = new Random();
        public AboutFrom()
        {
            InitializeComponent();
        }

        #region Methods
        private static string CheckFor45DotVersion(int releaseKey)
        {
            if (releaseKey >= 528040)
                return "4.8 or later";
            if (releaseKey >= 461808)
                return "4.7.2";
            if (releaseKey >= 461308)
                return "4.7.1";
            if (releaseKey >= 460798)
                return "4.7";
            if (releaseKey >= 394802)
                return "4.6.2";
            if (releaseKey >= 394254)
                return "4.6.1";
            if (releaseKey >= 393295)
                return "4.6";
            if (releaseKey >= 379893)
                return "4.5.2";
            if (releaseKey >= 378675)
                return "4.5.1";
            if (releaseKey >= 378389)
                return "4.5";
            return "No 4.5 or later version detected";
        }

        private async void GetDebugInfo() 
        {
            copyToClipboardLabel.Visible = true;
            Version vrs = new Version(Application.ProductVersion);
            StringBuilder sb = new StringBuilder(string.Empty);

            sb.AppendLine("App Information");
            sb.AppendLine("----------------------------");
            sb.AppendLine("Version = " + vrs);

            sb.AppendLine();
            sb.AppendLine("Operation System Information");
            sb.AppendLine("----------------------------");
            sb.AppendLine(string.Format("Name = {0}", OSVersionInfo.Name + " " + OSVersionInfo.ServicePack));
            sb.AppendLine(string.Format("Version = {0}", OSVersionInfo.VersionString));

            sb.AppendLine();
            sb.AppendLine(".Net Framework Information");
            sb.AppendLine("----------------------------");
            using (RegistryKey ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full\\"))
            {
                int releaseKey = Convert.ToInt32(ndpKey.GetValue("Release"));
                sb.AppendLine("Version = " + CheckFor45DotVersion(releaseKey));
            }
            Clipboard.SetText(sb.ToString());
            await Task.Delay(3000);
            copyToClipboardLabel.Visible = false;
        }
        #endregion


        #region Event Handlers
        private void AboutWindow_Load(object sender, EventArgs e)
        {
            Version vrs = new Version(Application.ProductVersion);
            appVersionLabel.Text = string.Format(PublicVar.appName + " {0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Build);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void RandomColorTimer_Tick(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            appVersionLabel.ForeColor = randomColor;
        }

        private void AppVersionLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GetDebugInfo();
            }
        }
        #endregion


        #region Main
        private void AppInfoRichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void AppVersionLabel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GetDebugInfo();
            }

            if (e.Button == MouseButtons.Right)
            {
                if (randomColorTimer.Enabled)
                {
                    randomColorTimer.Stop();
                }
                else
                {
                    randomColorTimer.Start();
                }
            }
        }
        #endregion


    }
}
