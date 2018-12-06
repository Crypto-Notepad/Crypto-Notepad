using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class AboutFrom : Form
    {
        public AboutFrom()
        {
            InitializeComponent();
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            Version vrs = new Version(Application.ProductVersion);
            label1.Text = string.Format("Crypto Notepad " + "{0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Build);
        }

        private void customRichTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }

        private void AboutFrom_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/Crypto-Notepad/wiki/Release-Notes");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://crypto-notepad.github.io/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/Crypto-Notepad");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/Crypto-Notepad/blob/master/LICENSE");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://sigmanor.pp.ua/");
        }
    }
}
