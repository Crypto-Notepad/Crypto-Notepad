using Crypto_Notepad.Properties;
using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class PasswordGeneratorFrom : Form
    {
        Settings settings = Settings.Default;
        public PasswordGeneratorFrom()
        {
            InitializeComponent();
        }

        #region Methods
        private string GeneratePassword()
        {
            var pwd = new Password(
                includeLowercase: lowercaseCheckBox.Checked,
                includeUppercase: uppercaseCheckBox.Checked,
                includeNumeric: numericCheckBox.Checked,
                includeSpecial: specialCheckBox.Checked,
                passwordLength: int.Parse(passwordLengthTextBox.Text));
            return pwd.Next();
        }

        private IEnumerable<string> GeneratePasswordGroup()
        {
            var pwd = new Password(
                includeLowercase: lowercaseCheckBox.Checked,
                includeUppercase: uppercaseCheckBox.Checked,
                includeNumeric: numericCheckBox.Checked,
                includeSpecial: specialCheckBox.Checked,
                passwordLength: int.Parse(passwordLengthTextBox.Text));
            return pwd.NextGroup(11);
        }
        #endregion


        #region Event Handlers
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            passwordsList.AppendLine(GeneratePassword());
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

        private void PasswordGeneratorFrom_Load(object sender, EventArgs e)
        {
            CenterToParent();
            lowercaseCheckBox.Checked = settings.passwordGeneratorLowercase;
            uppercaseCheckBox.Checked = settings.passwordGeneratorUppercase;
            numericCheckBox.Checked = settings.passwordGeneratorNumeric;
            specialCheckBox.Checked = settings.passwordGeneratorSpecial;
            passwordLengthTextBox.Text = settings.passwordGeneratorLength;
            passwordsList.Text = string.Join(Environment.NewLine, GeneratePasswordGroup().ToArray());
        }

        private void LowercaseCheckBox_Click(object sender, EventArgs e)
        {
            settings.passwordGeneratorLowercase = lowercaseCheckBox.Checked;
            settings.Save();
        }

        private void UppercaseCheckBox_Click(object sender, EventArgs e)
        {
            settings.passwordGeneratorUppercase = uppercaseCheckBox.Checked;
            settings.Save();
        }

        private void NumericCheckBox_Click(object sender, EventArgs e)
        {
            settings.passwordGeneratorNumeric = numericCheckBox.Checked;
            settings.Save();
        }

        private void SpecialCheckBox_Click(object sender, EventArgs e)
        {
            settings.passwordGeneratorSpecial = specialCheckBox.Checked;
            settings.Save();
        }

        private void PasswordGeneratorFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!settings.passwordGeneratorLowercase & !settings.passwordGeneratorUppercase
                & !settings.passwordGeneratorNumeric & !settings.passwordGeneratorSpecial)
            {
                settings.passwordGeneratorLowercase = true;
            }
            if (passwordLengthTextBox.Text.Length >= 1)
            {
                if (int.Parse(passwordLengthTextBox.Text) >= 8 & int.Parse(passwordLengthTextBox.Text) <= 128)
                {
                    settings.passwordGeneratorLength = passwordLengthTextBox.Text;
                }
            }
            settings.Save();
        }

        private void PasswordValidation(object sender, EventArgs e)
        {
            if (passwordLengthTextBox.Text.Length >= 1)
            {
                if (int.Parse(passwordLengthTextBox.Text) < 8 | int.Parse(passwordLengthTextBox.Text) > 128 | !lowercaseCheckBox.Checked 
                    & !uppercaseCheckBox.Checked & !numericCheckBox.Checked & !specialCheckBox.Checked)
                {
                    generateButton.Enabled = false;
                }
                else
                {
                    generateButton.Enabled = true;
                }
            }
            else
            {
                generateButton.Enabled = false;
            }
        }
        #endregion


    }
}
