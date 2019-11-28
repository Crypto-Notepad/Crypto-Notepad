using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
            statusLabel.Text = "";
        }

        #region Methods
        private async void ChangePasswordStatus(string message, Color color)
        {
            statusLabel.ForeColor = color;
            statusLabel.Text = message;
            oldKeyTextBox.Text = "";
            newKeyTextBox.Text = "";
            await Task.Delay(2500);
            statusLabel.Text = "";
        }
        #endregion


        #region Event Handlers
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            oldKeyTextBox.Focus();
            if (oldKeyTextBox.Text == PublicVar.password.Get() & oldKeyTextBox.Text != newKeyTextBox.Text)
            {
                PublicVar.password.Set(newKeyTextBox.Text);
                PublicVar.passwordChanged = true;
                ChangePasswordStatus("Password was successfully changed", Color.Green);
            }
            else if (oldKeyTextBox.Text != PublicVar.password.Get())
            {
                SystemSounds.Hand.Play();
                ChangePasswordStatus("Invalid old password", Color.Red);
            }
            else if (oldKeyTextBox.Text == newKeyTextBox.Text)
            {
                SystemSounds.Hand.Play();
                ChangePasswordStatus("New password is the same as old", Color.Red);
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
        #endregion


    }
}
