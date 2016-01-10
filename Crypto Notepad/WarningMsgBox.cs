using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class WarningMsgBox : Form
    {
        Properties.Settings ps = Properties.Settings.Default;

        public WarningMsgBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ps.WarningMsg = true;
                ps.Save();
            }
            this.Close();
        }
    }
}
