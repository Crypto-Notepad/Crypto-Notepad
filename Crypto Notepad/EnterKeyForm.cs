using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class EnterKeyForm : Form
    {
        public EnterKeyForm()
        {
            // Initialize to false in case user presses the exit button
            PublicVar.okPressed = false;
            InitializeComponent();
        }

        /*Form Events*/
        private void EnterKeyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            KeyTextBox.Focus();
        }

        private void EnterKeyForm_Load(object sender, EventArgs e)
        {
            this.Text = PublicVar.openFileName;
        }
        /*Form Events*/


        /*Enter key area*/
        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyTextBox.Text.Length > 0)
                OkButton.Enabled = true;
            else
                OkButton.Enabled = false;
        }

        private void KeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && OkButton.Enabled)
            {
                OkButton_Click(sender, e);
            }
        }

        private void EyePictureBox_Click(object sender, EventArgs e)
        {
            if (KeyTextBox.UseSystemPasswordChar)
            {
                KeyTextBox.UseSystemPasswordChar = false;
                EyePictureBox.Image = Properties.Resources.eye;
            }
            else
            {
                KeyTextBox.UseSystemPasswordChar = true;
                EyePictureBox.Image = Properties.Resources.eye_half;
            }
        }
        /*Enter key area*/


        /*Buttons*/
        private void OkButton_Click(object sender, EventArgs e)
        {
            TypedPassword.Value = KeyTextBox.Text;
            KeyTextBox.Focus();
            PublicVar.okPressed = true;
            this.Hide();
        }
        /*Buttons*/
    }
}
