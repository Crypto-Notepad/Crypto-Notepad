using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class Form2 : Form
    {
        public static bool OkPressed = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainWindow.key = textBox1.Text;
            textBox1.Focus();
            textBox1.Text = "";
            OkPressed = true;
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
                return;
            }

            if (textBox1.UseSystemPasswordChar == false)
            {
                textBox1.UseSystemPasswordChar = true;
                return;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
