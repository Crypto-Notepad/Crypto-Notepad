namespace Crypto_Notepad
{
    partial class EnterKeyForm
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
            this.components = new System.ComponentModel.Container();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EyePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeyPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(64, 39);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.KeyTextBox.TabIndex = 0;
            this.KeyTextBox.UseSystemPasswordChar = true;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            this.KeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyDown);
            // 
            // OkButton
            // 
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(112, 79);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // EyePictureBox
            // 
            this.EyePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EyePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EyePictureBox.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.EyePictureBox.InitialImage = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.EyePictureBox.Location = new System.Drawing.Point(163, 39);
            this.EyePictureBox.Name = "EyePictureBox";
            this.EyePictureBox.Size = new System.Drawing.Size(18, 20);
            this.EyePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyePictureBox.TabIndex = 3;
            this.EyePictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.EyePictureBox, "Show key");
            this.EyePictureBox.Click += new System.EventHandler(this.EyePictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.KeyPictureBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.KeyTextBox);
            this.panel1.Controls.Add(this.EyePictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 73);
            this.panel1.TabIndex = 5;
            // 
            // KeyPictureBox
            // 
            this.KeyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyPictureBox.Image = global::Crypto_Notepad.Properties.Resources.key_solid;
            this.KeyPictureBox.Location = new System.Drawing.Point(8, 12);
            this.KeyPictureBox.Name = "KeyPictureBox";
            this.KeyPictureBox.Size = new System.Drawing.Size(47, 47);
            this.KeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.KeyPictureBox.TabIndex = 6;
            this.KeyPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter the encryption key:";
            // 
            // EnterKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 107);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crypto Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.EnterKeyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EyePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox EyePictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox KeyPictureBox;
        public System.Windows.Forms.TextBox KeyTextBox;
    }
}