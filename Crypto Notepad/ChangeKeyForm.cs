﻿using System;
using System.Windows.Forms;

namespace Crypto_Notepad
{
    public partial class ChangeKeyForm : Form
    {
        public ChangeKeyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == MainWindow.key & textBox1.Text != textBox2.Text)
            {
                MainWindow.key = textBox2.Text;
                MainWindow.keyChanged = true;
                this.Close();
            }

            if (textBox1.Text != MainWindow.key)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Invalid old key!", "Change Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            if (textBox1.Text == textBox2.Text)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("New key the same as old!", "Change Key", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBox1.Text = "";
                textBox2.Text = "";
                return;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.eye_half;
                return;
            }

            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.eye;
                return;
            }
        }

        private void ChangeKeyForm_Load(object sender, EventArgs e)
        {

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
