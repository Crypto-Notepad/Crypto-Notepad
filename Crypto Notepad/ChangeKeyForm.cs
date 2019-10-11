using System;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class ChangeKeyForm : Form
    {
        public ChangeKeyForm()
        {
            InitializeComponent();
        }

        /*Buttons*/
        private async void BtnAccept_Click(object sender, EventArgs e)
        {
            if (txtOldKey.Text == PublicVar.encryptionKey.Get() && txtOldKey.Text != txtNewKey.Text)
            {
                PublicVar.encryptionKey.Set(txtNewKey.Text);
                PublicVar.keyChanged = true;
                txtOldKey.Text = "";
                txtNewKey.Text = "";
                lblStatus.Text = "Key was successfully changed";
                lblStatus.Visible = true;
                btnAccept.Enabled = false;
                await Task.Delay(2000);
                lblStatus.Text = "";
                return;
            }

            if (txtOldKey.Text != PublicVar.encryptionKey.Get())
            {
                SystemSounds.Beep.Play();
                lblStatus.Text = "Invalid old key";
                lblStatus.Visible = true;
                txtOldKey.Text = "";
                txtNewKey.Text = "";
                return;
            }

            if (txtOldKey.Text == txtNewKey.Text)
            {
                SystemSounds.Beep.Play();
                lblStatus.Text = "New key is the same as old";
                lblStatus.Visible = true;
                txtOldKey.Text = "";
                txtNewKey.Text = "";
                return;
            }
        }
        /*Buttons*/


        /*Enter keys area*/
        private void PicOldKeyEyeIcon_Click(object sender, EventArgs e)
        {
            if (txtOldKey.UseSystemPasswordChar)
            {
                txtOldKey.UseSystemPasswordChar = false;
                picOldKey.Image = Properties.Resources.eye;
            }
            else
            {
                txtOldKey.UseSystemPasswordChar = true;
                picOldKey.Image = Properties.Resources.eye_half;
            }
        }

        private void PicNewKeyEyeIcon_Click(object sender, EventArgs e)
        {
            if (txtNewKey.UseSystemPasswordChar)
            {
                txtNewKey.UseSystemPasswordChar = false;
                picNewKey.Image = Properties.Resources.eye;
            }
            else
            {
                txtNewKey.UseSystemPasswordChar = true;
                picNewKey.Image = Properties.Resources.eye_half;
            }
        }

        private void TxtOldKey_TextChanged(object sender, EventArgs e)
        {
            if (txtOldKey.Text.Length > 0 && txtNewKey.Text.Length > 0)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void TxtNewKey_TextChanged(object sender, EventArgs e)
        {
            if (txtNewKey.Text.Length > 0 && txtOldKey.Text.Length > 0)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }
        /*Enter keys area*/
    }
}
