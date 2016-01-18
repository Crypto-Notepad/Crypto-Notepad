using System;
using Ionic.Zip;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;
using System.Net;
using System.Reflection;

namespace Updater
{
    public partial class UpdateForm : Form
    {
        string[] arg;
        string exePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\";
        bool okButton = false;

        public UpdateForm(string[] args)
        {
            arg = args;
            InitializeComponent();
        }

        #region ExtractZip
        public void ExtractFileToDirectory(string zipFileName, string outputDirectory)
        {
            ZipFile zip = ZipFile.Read(zipFileName);
            Directory.CreateDirectory(outputDirectory);
            zip.ExtractAll(outputDirectory, ExtractExistingFileAction.OverwriteSilently);
        }
        #endregion

        void downloader_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                System.Media.SystemSounds.Beep.Play();
                //linkLabel1.Visible = false;
                okButton = true;
                button1.Enabled = true;
                label1.Text = "There was some errors during the update, please try again later.";
            }

            if (e.Error == null)
            {
                var pr = new Process();
                ExtractFileToDirectory(exePath + "Crypto-Notepad-Update.zip", exePath);
                pr.StartInfo.FileName = exePath + "Crypto Notepad.exe";
                pr.Start();
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (arg.Length == 0)
            {
                this.Close();
            }

            else if (arg[0] == "/u")
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (okButton == false)
            {
                var pr = new Process();
                button1.Enabled = false;
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(downloader_DownloadFileCompleted);
                webClient.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/Sigmanor/Crypto-Notepad/master/Crypto-Notepad-Update.zip"), exePath + "Crypto-Notepad-Update.zip");
            }

            if (okButton == true)
            {
                var pr = new Process();
                pr.StartInfo.FileName = exePath + "Crypto Notepad.exe";
                pr.Start();
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/Crypto-Notepad/wiki/Release-Notes");
        }
    }
}
