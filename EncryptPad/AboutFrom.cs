using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EncryptPad
{
    public partial class AboutFrom : Form
    {
        public AboutFrom()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/EncryptPad/blob/master/LICENSE");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/EncryptPad");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.codeproject.com/Articles/20917/Creating-a-Custom-Settings-Provider");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Process.Start("http://easylab.net.ua/net-c-windows-forms/c-algoritm-shifrovaniya-aes");
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Process.Start("https://code.msdn.microsoft.com/windowsdesktop/How-to-find-the-text-and-e92b8d78");
        }

        private void AboutWindow_Load(object sender, EventArgs e)
        {
            Version vrs = new Version(Application.ProductVersion);
            label1.Text = string.Format("EncryptPad "+ "{0}.{1}.{2}", vrs.Major, vrs.Minor, vrs.Build);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Sigmanor/EncryptPad/wiki/Release-Notes");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(64, 64, 64))
            {
                this.BackColor = Color.FromArgb(36, 67, 92);
            }

            else if (this.BackColor == Color.FromArgb(36, 67, 92))
            {
                this.BackColor = Color.FromArgb(90, 36, 119);
            }

            else if (this.BackColor == Color.FromArgb(90, 36, 119))
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }

            
        }
    }
}
