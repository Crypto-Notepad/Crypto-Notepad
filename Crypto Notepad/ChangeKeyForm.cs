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
        private async void AcceptButton_Click(object sender, EventArgs e)
        {
            if (oldKeyTextBox.Text == PublicVar.encryptionKey.Get() && oldKeyTextBox.Text != newKeyTextBox.Text)
            {
                PublicVar.encryptionKey.Set(newKeyTextBox.Text);
                PublicVar.keyChanged = true;
                oldKeyTextBox.Text = "";
                newKeyTextBox.Text = "";
                statusLabel.Text = "Key was successfully changed";
                statusLabel.Visible = true;
                acceptButton.Enabled = false;
                await Task.Delay(2000);
                statusLabel.Text = "";
                return;
            }

            if (oldKeyTextBox.Text != PublicVar.encryptionKey.Get())
            {
                SystemSounds.Beep.Play();
                statusLabel.Text = "Invalid old key";
                statusLabel.Visible = true;
                oldKeyTextBox.Text = "";
                newKeyTextBox.Text = "";
                return;
            }

            if (oldKeyTextBox.Text == newKeyTextBox.Text)
            {
                SystemSounds.Beep.Play();
                statusLabel.Text = "New key is the same as old";
                statusLabel.Visible = true;
                oldKeyTextBox.Text = "";
                newKeyTextBox.Text = "";
                return;
            }
        }
        /*Buttons*/


        /*Enter keys area*/
        private void OldKeyEyeIcon_Click(object sender, EventArgs e)
        {
            if (oldKeyTextBox.UseSystemPasswordChar)
            {
                oldKeyTextBox.UseSystemPasswordChar = false;
                oldKeyEyeIcon.Image = Properties.Resources.eye;
            }
            else
            {
                oldKeyTextBox.UseSystemPasswordChar = true;
                oldKeyEyeIcon.Image = Properties.Resources.eye_half;
            }
        }

        private void NewKeyEyeIcon_Click(object sender, EventArgs e)
        {
            if (newKeyTextBox.UseSystemPasswordChar)
            {
                newKeyTextBox.UseSystemPasswordChar = false;
                newKeyEyeIcon.Image = Properties.Resources.eye;
            }
            else
            {
                newKeyTextBox.UseSystemPasswordChar = true;
                newKeyEyeIcon.Image = Properties.Resources.eye_half;
            }
        }

        private void OldKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (oldKeyTextBox.Text.Length > 0 && newKeyTextBox.Text.Length > 0)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }
        }

        private void NewKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (newKeyTextBox.Text.Length > 0 && oldKeyTextBox.Text.Length > 0)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }
        }
        /*Enter keys area*/
    }
}
