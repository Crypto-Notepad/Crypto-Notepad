using System;
using System.Drawing;
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
            statusLabel.Text = "";
        }

        /*Buttons*/
        private async void AcceptButton_Click(object sender, EventArgs e)
        {
            oldKeyTextBox.Focus();
            if (oldKeyTextBox.Text == PublicVar.encryptionKey.Get() & oldKeyTextBox.Text != newKeyTextBox.Text)
            {
                PublicVar.encryptionKey.Set(newKeyTextBox.Text);
                PublicVar.keyChanged = true;
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Key was successfully changed";
                oldKeyTextBox.Text = "";
                newKeyTextBox.Text = "";         
                await Task.Delay(3000);
                statusLabel.Text = "";
            }
            else if (oldKeyTextBox.Text != PublicVar.encryptionKey.Get())
            {
                SystemSounds.Hand.Play();
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Invalid old key";
                oldKeyTextBox.Text = "";
                newKeyTextBox.Text = "";
                await Task.Delay(2000);
                statusLabel.Text = "";
            }
            else if(oldKeyTextBox.Text == newKeyTextBox.Text)
            {
                SystemSounds.Hand.Play();
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "New key is the same as old";
                oldKeyTextBox.Text = "";
                newKeyTextBox.Text = "";
                await Task.Delay(2000);
                statusLabel.Text = "";
            }
        }

        private void PasswordGeneratorButton_Click(object sender, EventArgs e)
        {
            ActiveControl = null;
            PasswordGeneratorFrom passwordGeneratorFrom = new PasswordGeneratorFrom();
            if ((Application.OpenForms["PasswordGeneratorFrom"] as PasswordGeneratorFrom) == null)
            {
                passwordGeneratorFrom.Show(this);
            }
        }
        /*Buttons*/


        /*Enter keys area*/
        private void ShowOldKeyPictureBox_Click(object sender, EventArgs e)
        {
            if (oldKeyTextBox.UseSystemPasswordChar)
            {
                oldKeyTextBox.UseSystemPasswordChar = false;
                showOldKeyPictureBox.Image = Properties.Resources.eye;
            }
            else
            {
                oldKeyTextBox.UseSystemPasswordChar = true;
                showOldKeyPictureBox.Image = Properties.Resources.eye_half;
            }
        }

        private void ShowNewKeyPictureBox_Click(object sender, EventArgs e)
        {
            if (newKeyTextBox.UseSystemPasswordChar)
            {
                newKeyTextBox.UseSystemPasswordChar = false;
                showNewKeyPictureBox.Image = Properties.Resources.eye;
            }
            else
            {
                newKeyTextBox.UseSystemPasswordChar = true;
                showNewKeyPictureBox.Image = Properties.Resources.eye_half;
            }
        }

        private void OldKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (oldKeyTextBox.Text.Length > 0 & newKeyTextBox.Text.Length > 0)
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
            if (newKeyTextBox.Text.Length > 0 & oldKeyTextBox.Text.Length > 0)
            {
                acceptButton.Enabled = true;
            }
            else
            {
                acceptButton.Enabled = false;
            }           
        }

        private void NewKeyPlaceholder_Click(object sender, EventArgs e)
        {
            newKeyTextBox.Focus();
        }
        private void OldKeyPlaceholder_Click(object sender, EventArgs e)
        {
            oldKeyTextBox.Focus();
        }

        private void NewKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter & acceptButton.Enabled)
            {
                AcceptButton_Click(sender, e);
            }
        }

        private void OldKeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Enter & acceptButton.Enabled)
            {
                AcceptButton_Click(sender, e);
            }
        }
        /*Enter keys area*/


    }
}
