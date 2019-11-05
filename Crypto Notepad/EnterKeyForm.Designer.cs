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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterKeyForm));
            this.okButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.showKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.keyTextBox = new System.Windows.Forms.PlaceholderTextBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showKeyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(190, 80);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lockPictureBox);
            this.mainPanel.Controls.Add(this.fileNameLabel);
            this.mainPanel.Controls.Add(this.keyTextBox);
            this.mainPanel.Controls.Add(this.showKeyPictureBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(269, 75);
            this.mainPanel.TabIndex = 5;
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockPictureBox.Image = global::Crypto_Notepad.Properties.Resources.key_solid;
            this.lockPictureBox.Location = new System.Drawing.Point(8, 12);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(47, 47);
            this.lockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lockPictureBox.TabIndex = 6;
            this.lockPictureBox.TabStop = false;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoEllipsis = true;
            this.fileNameLabel.Location = new System.Drawing.Point(61, 12);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(196, 13);
            this.fileNameLabel.TabIndex = 6;
            this.fileNameLabel.Text = "File name";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // showKeyPictureBox
            // 
            this.showKeyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showKeyPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showKeyPictureBox.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.showKeyPictureBox.InitialImage = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.showKeyPictureBox.Location = new System.Drawing.Point(240, 37);
            this.showKeyPictureBox.Name = "showKeyPictureBox";
            this.showKeyPictureBox.Size = new System.Drawing.Size(18, 22);
            this.showKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showKeyPictureBox.TabIndex = 3;
            this.showKeyPictureBox.TabStop = false;
            this.showKeyPictureBox.Click += new System.EventHandler(this.ShowKeyPictureBox_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(64, 37);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(177, 22);
            this.keyTextBox.TabIndex = 0;
            this.keyTextBox.UseSystemPasswordChar = true;
            this.keyTextBox.Placeholder = "Encryption key";
            this.keyTextBox.PlaceholderActiveForeColor = System.Drawing.Color.DarkGray;
            this.keyTextBox.PlaceholderFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.keyTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.keyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyTextBox_KeyDown);
            // 
            // EnterKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 106);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crypto Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.EnterKeyForm_Load);
            this.Shown += new System.EventHandler(this.EnterKeyForm_Shown);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showKeyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.PictureBox showKeyPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.PictureBox lockPictureBox;
        public System.Windows.Forms.PlaceholderTextBox keyTextBox;
    }
}