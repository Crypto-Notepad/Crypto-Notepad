using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class EnterKeyForm : Form
    {
        public EnterKeyForm()
        {
            PublicVar.okPressed = false;
            InitializeComponent();
        }

        /*Form Events*/
        private void EnterKeyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm main = Owner as MainForm;
            if (main.Visible == false)
            {
                Environment.Exit(0);
            }
            txtKey.Focus();
        }

        private void EnterKeyForm_Load(object sender, EventArgs e)
        {
            lblFileName.Text = PublicVar.openFileName;
            Properties.Settings settings = Properties.Settings.Default;
            TopMost = settings.alwaysOnTop;
        }

        private void EnterKeyForm_Shown(object sender, EventArgs e)
        {
            lblFileName.Text = PublicVar.openFileName;
        }
        /*Form Events*/


        /*Enter key area*/
        private void TxtKey_TextChanged(object sender, EventArgs e)
        {
            if (txtKey.Text.Length > 0)
                btnOk.Enabled = true;
            else
                btnOk.Enabled = false;
        }

        private void TxtKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnOk.Enabled)
            {
                BtnOk_Click(sender, e);
            }
        }

        private void KeyEyeIcon_Click(object sender, EventArgs e)
        {
            if (txtKey.UseSystemPasswordChar)
            {
                txtKey.UseSystemPasswordChar = false;
                picShowKey.Image = Properties.Resources.eye;
            }
            else
            {
                txtKey.UseSystemPasswordChar = true;
                picShowKey.Image = Properties.Resources.eye_half;
            }
        }
        /*Enter key area*/


        /*Buttons*/
        private void BtnOk_Click(object sender, EventArgs e)
        {
            TypedPassword.Value = txtKey.Text;
            txtKey.Focus();
            PublicVar.okPressed = true;
            Hide();
        }
        /*Buttons*/


    }
}
