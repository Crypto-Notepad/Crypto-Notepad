using System;
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == publicVar.encryptionKey.Get() & textBox1.Text != textBox2.Text)
            {
                publicVar.encryptionKey.Set(textBox2.Text);
                publicVar.keyChanged = true;
                textBox1.Text = "";
                textBox2.Text = "";
                statusLabel.Text = "Key was successfully changed";
                statusLabel.Visible = true;
                button1.Enabled = false;
                await Task.Delay(2000);
                statusLabel.Text = "";
                //this.Close();
                return;
            }

            if (textBox1.Text != publicVar.encryptionKey.Get())
            {
                SystemSounds.Beep.Play();
                statusLabel.Text = "Invalid old key";
                statusLabel.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            if (textBox1.Text == textBox2.Text)
            {
                SystemSounds.Beep.Play();
                statusLabel.Text = "New key is the same as old";
                statusLabel.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";
                return;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.eye;
                return;
            }

            if (!textBox2.UseSystemPasswordChar)
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.eye_half;
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 & textBox2.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

    }
}
