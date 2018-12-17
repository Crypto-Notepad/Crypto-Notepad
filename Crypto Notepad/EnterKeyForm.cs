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

        private void button1_Click(object sender, EventArgs e)
        {
            TypedPassword.Value = textBox1.Text;
            textBox1.Focus();
            PublicVar.okPressed = true;
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && button1.Enabled)
            {
                button1_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar)
            {
                textBox1.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.eye;
                return;
            }

            if (!textBox1.UseSystemPasswordChar)
            {
                textBox1.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.eye_half;
                return;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = PublicVar.openFileName;
        }
    }
}
