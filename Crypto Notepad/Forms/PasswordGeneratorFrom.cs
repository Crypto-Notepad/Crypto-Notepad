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
        private IEnumerable<string> GeneratePasswordGroup()
        {
            var pwd = new Password(
                includeLowercase: lowercaseCheckBox.Checked,
                includeUppercase: uppercaseCheckBox.Checked,
                includeNumeric: numericCheckBox.Checked,
                includeSpecial: specialCheckBox.Checked,
                passwordLength: int.Parse(passwordLengthTextBox.Text));
            return pwd.NextGroup(Convert.ToInt32(numberOfStringsTextBox.Text));
        }
        #endregion


        #region Event Handlers
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            passwordsListTextBox.AppendLine(string.Join(Environment.NewLine, GeneratePasswordGroup().ToArray()));
        }

        private void ClearPasswordsListButton_Click(object sender, EventArgs e)
        {
            passwordsListTextBox.Clear();
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
            numberOfStringsTextBox.Text = settings.passwordGeneratorNumberOfStrings;
            passwordsListTextBox.Text = string.Join(Environment.NewLine, GeneratePasswordGroup().ToArray());
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
            try
            {
                if (Enumerable.Range(8, 128).Contains(int.Parse(passwordLengthTextBox.Text)))
                {
                    settings.passwordGeneratorLength = passwordLengthTextBox.Text;
                }
                if (Enumerable.Range(1, 1000).Contains(int.Parse(numberOfStringsTextBox.Text)))
                {
                    settings.passwordGeneratorNumberOfStrings = numberOfStringsTextBox.Text;
                }
            }
            catch
            {
            }
            settings.Save();
        }

        private void PasswordValidation(object sender, EventArgs e)
        {
            try
            {
                if (!Enumerable.Range(1, 1000).Contains(int.Parse(numberOfStringsTextBox.Text)) |
                    !Enumerable.Range(8, 128).Contains(int.Parse(passwordLengthTextBox.Text)) |
                    !lowercaseCheckBox.Checked &
                    !uppercaseCheckBox.Checked &
                    !numericCheckBox.Checked &
                    !specialCheckBox.Checked |
                    string.IsNullOrWhiteSpace(numberOfStringsTextBox.Text.Trim('0')))
                {
                    generateButton.Enabled = false;
                }
                else
                {
                    generateButton.Enabled = true;
                }

            }
            catch
            {
                generateButton.Enabled = false;
            }
        }

        private void CopyAllButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordsListTextBox.Text);
            passwordGeneratorToolTip.SetToolTip(copyAllButton, "Copied");
        }

        private void CopyLastButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordsListTextBox.Lines[passwordsListTextBox.Lines.Length - 1]);
            passwordGeneratorToolTip.SetToolTip(copyLastButton, "Copied");
        }

        private void PasswordsListTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordsListTextBox.Text))
            {
                copyLastButton.Enabled = false;
                copyAllButton.Enabled = false;
            }
            else
            {
                copyLastButton.Enabled = true;
                copyAllButton.Enabled = true;
            }
        }

        #endregion

        private void CopyLastButton_MouseEnter(object sender, EventArgs e)
        {
            passwordGeneratorToolTip.SetToolTip(copyLastButton, null);
        }

        private void CopyAllButton_MouseEnter(object sender, EventArgs e)
        {
            passwordGeneratorToolTip.SetToolTip(copyAllButton, null);
        }
    }
}
