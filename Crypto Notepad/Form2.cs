using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            // Initialize to false in case user presses the exit button
            publicVar.okPressed = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            publicVar.encryptionKey.Set(textBox1.Text);
            textBox1.Focus();
            textBox1.Text = "";
            publicVar.okPressed = true;
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
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.eye_half;
                return;
            }

            if (textBox1.UseSystemPasswordChar == false)
            {
                textBox1.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.eye;
                return;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = publicVar.openFileName;
        }
    }
}
