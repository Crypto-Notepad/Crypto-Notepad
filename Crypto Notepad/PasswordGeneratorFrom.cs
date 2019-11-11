using PasswordGenerator;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class PasswordGeneratorFrom : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr CloseClipboard();
        public PasswordGeneratorFrom()
        {
            InitializeComponent();
            11.Times(() => GenerateButton_Click(null, null));
        }

        private string GeneratePassword()
        {
            var pwd = new Password(
                includeLowercase: includeLowercaseCheckBox.Checked, 
                includeUppercase: includeUppercaseCheckBox.Checked, 
                includeNumeric: includeNumericCheckBox.Checked, 
                includeSpecial: includeSpecialCheckBox.Checked, 
                passwordLength: int.Parse(passwordLengthTextBox.Text));
            return pwd.Next();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            PublicVar.messageBoxCenterParent = true;
            if (string.IsNullOrEmpty(passwordLengthTextBox.Text))
            {
                passwordLengthTextBox.Text = 8.ToString();
            }
            if (int.Parse(passwordLengthTextBox.Text) < 8)
            {
                passwordLengthTextBox.Text = 8.ToString();
            }
            if (int.Parse(passwordLengthTextBox.Text) > 128)
            {
                passwordLengthTextBox.Text = 128.ToString();
            }
            try
            {
                passwordsList.AppendLine(GeneratePassword());            
            }
            catch (ArgumentOutOfRangeException)
            {
                using (new CenterWinDialog(this))
                {
                    DialogResult res = MessageBox.Show(this, "Choose at least one character type", "Uh oh! Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearPasswordsListButton_Click(object sender, EventArgs e)
        {
            passwordsList.Clear();
        }

        private void PasswordLengthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PasswordGeneratorFrom_Shown(object sender, EventArgs e)
        {
            CenterToParent();
        }


    }
}
