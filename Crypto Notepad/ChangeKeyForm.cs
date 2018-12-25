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
            if (OldKeyTextBox.Text == PublicVar.encryptionKey.Get() && OldKeyTextBox.Text != NewKeyTextBox.Text)
            {
                PublicVar.encryptionKey.Set(NewKeyTextBox.Text);
                PublicVar.keyChanged = true;
                OldKeyTextBox.Text = "";
                NewKeyTextBox.Text = "";
                StatusLabel.Text = "Key was successfully changed";
                StatusLabel.Visible = true;
                AcceptButton.Enabled = false;
                await Task.Delay(2000);
                StatusLabel.Text = "";
                return;
            }

            if (OldKeyTextBox.Text != PublicVar.encryptionKey.Get())
            {
                SystemSounds.Beep.Play();
                StatusLabel.Text = "Invalid old key";
                StatusLabel.Visible = true;
                OldKeyTextBox.Text = "";
                NewKeyTextBox.Text = "";
                return;
            }

            if (OldKeyTextBox.Text == NewKeyTextBox.Text)
            {
                SystemSounds.Beep.Play();
                StatusLabel.Text = "New key is the same as old";
                StatusLabel.Visible = true;
                OldKeyTextBox.Text = "";
                NewKeyTextBox.Text = "";
                return;
            }
        }
        /*Buttons*/


        /*Enter keys area*/
        private void EyePictureBox1_Click(object sender, EventArgs e)
        {
            if (OldKeyTextBox.UseSystemPasswordChar)
            {
                OldKeyTextBox.UseSystemPasswordChar = false;
                EyePictureBox1.Image = Properties.Resources.eye;
            }
            else
            {
                OldKeyTextBox.UseSystemPasswordChar = true;
                EyePictureBox1.Image = Properties.Resources.eye_half;
            }
        }

        private void EyePictureBox2_Click(object sender, EventArgs e)
        {
            if (NewKeyTextBox.UseSystemPasswordChar)
            {
                NewKeyTextBox.UseSystemPasswordChar = false;
                EyePictureBox2.Image = Properties.Resources.eye;
            }
            else
            {
                NewKeyTextBox.UseSystemPasswordChar = true;
                EyePictureBox2.Image = Properties.Resources.eye_half;
            }
        }

        private void OldKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (OldKeyTextBox.Text.Length > 0)
            {
                AcceptButton.Enabled = true;
            }
            else
            {
                AcceptButton.Enabled = false;
            }
        }

        private void NewKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewKeyTextBox.Text.Length > 0)
            {
                AcceptButton.Enabled = true;
            }
            else
            {
                AcceptButton.Enabled = false;
            }
        }
        /*Enter keys area*/
    }
}
