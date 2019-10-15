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
            this.oldKeyTextBox = new System.Windows.Forms.TextBox();
            this.newKeyTextBox = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.oldKeyPlaceholder = new System.Windows.Forms.Label();
            this.newKeyPlaceholder = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.showNewKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.showOldKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNewKeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showOldKeyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // oldKeyTextBox
            // 
            this.oldKeyTextBox.Location = new System.Drawing.Point(63, 12);
            this.oldKeyTextBox.Name = "oldKeyTextBox";
            this.oldKeyTextBox.Size = new System.Drawing.Size(177, 22);
            this.oldKeyTextBox.TabIndex = 0;
            this.oldKeyTextBox.UseSystemPasswordChar = true;
            this.oldKeyTextBox.TextChanged += new System.EventHandler(this.OldKeyTextBox_TextChanged);
            this.oldKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OldKeyTextBox_KeyDown);
            // 
            // newKeyTextBox
            // 
            this.newKeyTextBox.Location = new System.Drawing.Point(63, 37);
            this.newKeyTextBox.Name = "newKeyTextBox";
            this.newKeyTextBox.Size = new System.Drawing.Size(177, 22);
            this.newKeyTextBox.TabIndex = 1;
            this.newKeyTextBox.UseSystemPasswordChar = true;
            this.newKeyTextBox.TextChanged += new System.EventHandler(this.NewKeyTextBox_TextChanged);
            this.newKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewKeyTextBox_KeyDown);
            this.newKeyTextBox.Leave += new System.EventHandler(this.NewKeyTextBox_Leave);
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(212, 79);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(53, 23);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.oldKeyPlaceholder);
            this.mainPanel.Controls.Add(this.newKeyPlaceholder);
            this.mainPanel.Controls.Add(this.lockPictureBox);
            this.mainPanel.Controls.Add(this.showNewKeyPictureBox);
            this.mainPanel.Controls.Add(this.showOldKeyPictureBox);
            this.mainPanel.Controls.Add(this.oldKeyTextBox);
            this.mainPanel.Controls.Add(this.newKeyTextBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(269, 75);
            this.mainPanel.TabIndex = 6;
            // 
            // oldKeyPlaceholder
            // 
            this.oldKeyPlaceholder.AutoSize = true;
            this.oldKeyPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldKeyPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.oldKeyPlaceholder.Location = new System.Drawing.Point(67, 16);
            this.oldKeyPlaceholder.Name = "oldKeyPlaceholder";
            this.oldKeyPlaceholder.Size = new System.Drawing.Size(46, 13);
            this.oldKeyPlaceholder.TabIndex = 8;
            this.oldKeyPlaceholder.Text = "Old key";
            this.oldKeyPlaceholder.Click += new System.EventHandler(this.OldKeyPlaceholder_Click);
            // 
            // newKeyPlaceholder
            // 
            this.newKeyPlaceholder.AutoSize = true;
            this.newKeyPlaceholder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newKeyPlaceholder.ForeColor = System.Drawing.Color.DarkGray;
            this.newKeyPlaceholder.Location = new System.Drawing.Point(67, 41);
            this.newKeyPlaceholder.Name = "newKeyPlaceholder";
            this.newKeyPlaceholder.Size = new System.Drawing.Size(50, 13);
            this.newKeyPlaceholder.TabIndex = 2;
            this.newKeyPlaceholder.Text = "New key";
            this.newKeyPlaceholder.Click += new System.EventHandler(this.NewKeyPlaceholder_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(5, 81);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 17);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "status";
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockPictureBox.Image = global::Crypto_Notepad.Properties.Resources.gnupg_keys;
            this.lockPictureBox.Location = new System.Drawing.Point(8, 12);
            this.lockPictureBox.Name = "lockPictureBox";
            this.lockPictureBox.Size = new System.Drawing.Size(47, 47);
            this.lockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lockPictureBox.TabIndex = 7;
            this.lockPictureBox.TabStop = false;
            // 
            // showNewKeyPictureBox
            // 
            this.showNewKeyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showNewKeyPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showNewKeyPictureBox.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.showNewKeyPictureBox.Location = new System.Drawing.Point(239, 37);
            this.showNewKeyPictureBox.Name = "showNewKeyPictureBox";
            this.showNewKeyPictureBox.Size = new System.Drawing.Size(18, 22);
            this.showNewKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showNewKeyPictureBox.TabIndex = 5;
            this.showNewKeyPictureBox.TabStop = false;
            this.showNewKeyPictureBox.Click += new System.EventHandler(this.ShowNewKeyPictureBox_Click);
            // 
            // showOldKeyPictureBox
            // 
            this.showOldKeyPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showOldKeyPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showOldKeyPictureBox.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.showOldKeyPictureBox.Location = new System.Drawing.Point(239, 12);
            this.showOldKeyPictureBox.Name = "showOldKeyPictureBox";
            this.showOldKeyPictureBox.Size = new System.Drawing.Size(18, 22);
            this.showOldKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showOldKeyPictureBox.TabIndex = 5;
            this.showOldKeyPictureBox.TabStop = false;
            this.showOldKeyPictureBox.Click += new System.EventHandler(this.ShowOldKeyPictureBox_Click);
            // 
            // ChangeKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 106);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.acceptButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeKeyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Key";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNewKeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showOldKeyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldKeyTextBox;
        private System.Windows.Forms.TextBox newKeyTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.PictureBox showOldKeyPictureBox;
        private System.Windows.Forms.PictureBox showNewKeyPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox lockPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label newKeyPlaceholder;
        private System.Windows.Forms.Label oldKeyPlaceholder;
    }
}