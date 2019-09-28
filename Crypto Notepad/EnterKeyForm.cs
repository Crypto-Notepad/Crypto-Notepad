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
            MainForm main = Owner as MainForm;
            keyTextBox.Focus();
            if (main.Visible == false)
            {
                Application.Exit();
            }
        }

        private void EnterKeyForm_Load(object sender, EventArgs e)
        {
            fileNameLabel.Text = PublicVar.openFileName;
        }
        /*Form Events*/


        /*Enter key area*/
        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (keyTextBox.Text.Length > 0)
                okButton.Enabled = true;
            else
                okButton.Enabled = false;
        }

        private void KeyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && okButton.Enabled)
            {
                OkButton_Click(sender, e);
            }
        }

        private void KeyEyeIcon_Click(object sender, EventArgs e)
        {
            if (keyTextBox.UseSystemPasswordChar)
            {
                keyTextBox.UseSystemPasswordChar = false;
                keyEyeIcon.Image = Properties.Resources.eye;
            }
            else
            {
                keyTextBox.UseSystemPasswordChar = true;
                keyEyeIcon.Image = Properties.Resources.eye_half;
            }
        }
        /*Enter key area*/


        /*Buttons*/
        private void OkButton_Click(object sender, EventArgs e)
        {
            TypedPassword.Value = keyTextBox.Text;
            keyTextBox.Focus();
            PublicVar.okPressed = true;
            Hide();
        }
        /*Buttons*/


    }
}
