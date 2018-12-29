namespace Crypto_Notepad
{
    partial class ChangeKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OldKeyTextBox = new System.Windows.Forms.TextBox();
            this.NewKeyTextBox = new System.Windows.Forms.TextBox();
            this.OldKeyLabel = new System.Windows.Forms.Label();
            this.NewKeyLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.KeysPictureBox = new System.Windows.Forms.PictureBox();
            this.EyePictureBox2 = new System.Windows.Forms.PictureBox();
            this.EyePictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeysPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OldKeyTextBox
            // 
            this.OldKeyTextBox.Location = new System.Drawing.Point(120, 9);
            this.OldKeyTextBox.Name = "OldKeyTextBox";
            this.OldKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.OldKeyTextBox.TabIndex = 0;
            this.OldKeyTextBox.UseSystemPasswordChar = true;
            this.OldKeyTextBox.TextChanged += new System.EventHandler(this.OldKeyTextBox_TextChanged);
            // 
            // NewKeyTextBox
            // 
            this.NewKeyTextBox.Location = new System.Drawing.Point(120, 43);
            this.NewKeyTextBox.Name = "NewKeyTextBox";
            this.NewKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.NewKeyTextBox.TabIndex = 1;
            this.NewKeyTextBox.UseSystemPasswordChar = true;
            this.NewKeyTextBox.TextChanged += new System.EventHandler(this.NewKeyTextBox_TextChanged);
            // 
            // OldKeyLabel
            // 
            this.OldKeyLabel.AutoSize = true;
            this.OldKeyLabel.Location = new System.Drawing.Point(61, 12);
            this.OldKeyLabel.Name = "OldKeyLabel";
            this.OldKeyLabel.Size = new System.Drawing.Size(47, 13);
            this.OldKeyLabel.TabIndex = 2;
            this.OldKeyLabel.Text = "Old Key:";
            // 
            // NewKeyLabel
            // 
            this.NewKeyLabel.AutoSize = true;
            this.NewKeyLabel.Location = new System.Drawing.Point(61, 46);
            this.NewKeyLabel.Name = "NewKeyLabel";
            this.NewKeyLabel.Size = new System.Drawing.Size(53, 13);
            this.NewKeyLabel.TabIndex = 3;
            this.NewKeyLabel.Text = "New Key:";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Enabled = false;
            this.AcceptButton.Location = new System.Drawing.Point(206, 82);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(53, 23);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.KeysPictureBox);
            this.panel1.Controls.Add(this.EyePictureBox2);
            this.panel1.Controls.Add(this.OldKeyLabel);
            this.panel1.Controls.Add(this.EyePictureBox1);
            this.panel1.Controls.Add(this.OldKeyTextBox);
            this.panel1.Controls.Add(this.NewKeyTextBox);
            this.panel1.Controls.Add(this.NewKeyLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 75);
            this.panel1.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusLabel.Location = new System.Drawing.Point(5, 87);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(43, 16);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "status";
            this.StatusLabel.Visible = false;
            // 
            // KeysPictureBox
            // 
            this.KeysPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeysPictureBox.Image = global::Crypto_Notepad.Properties.Resources.big_lock;
            this.KeysPictureBox.Location = new System.Drawing.Point(8, 12);
            this.KeysPictureBox.Name = "KeysPictureBox";
            this.KeysPictureBox.Size = new System.Drawing.Size(47, 47);
            this.KeysPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.KeysPictureBox.TabIndex = 7;
            this.KeysPictureBox.TabStop = false;
            // 
            // EyePictureBox2
            // 
            this.EyePictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EyePictureBox2.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.EyePictureBox2.Location = new System.Drawing.Point(219, 43);
            this.EyePictureBox2.Name = "EyePictureBox2";
            this.EyePictureBox2.Size = new System.Drawing.Size(32, 20);
            this.EyePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EyePictureBox2.TabIndex = 5;
            this.EyePictureBox2.TabStop = false;
            this.EyePictureBox2.Click += new System.EventHandler(this.EyePictureBox2_Click);
            // 
            // EyePictureBox1
            // 
            this.EyePictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EyePictureBox1.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.EyePictureBox1.Location = new System.Drawing.Point(219, 9);
            this.EyePictureBox1.Name = "EyePictureBox1";
            this.EyePictureBox1.Size = new System.Drawing.Size(32, 20);
            this.EyePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EyePictureBox1.TabIndex = 5;
            this.EyePictureBox1.TabStop = false;
            this.EyePictureBox1.Click += new System.EventHandler(this.EyePictureBox1_Click);
            // 
            // ChangeKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 111);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AcceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Key";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeysPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldKeyTextBox;
        private System.Windows.Forms.TextBox NewKeyTextBox;
        private System.Windows.Forms.Label OldKeyLabel;
        private System.Windows.Forms.Label NewKeyLabel;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.PictureBox EyePictureBox1;
        private System.Windows.Forms.PictureBox EyePictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox KeysPictureBox;
        private System.Windows.Forms.Label StatusLabel;
    }
}