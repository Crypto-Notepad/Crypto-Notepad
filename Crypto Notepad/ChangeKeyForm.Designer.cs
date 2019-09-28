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
            this.oldKeyLabel = new System.Windows.Forms.Label();
            this.newKeyLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lockIcon = new System.Windows.Forms.PictureBox();
            this.newKeyEyeIcon = new System.Windows.Forms.PictureBox();
            this.oldKeyEyeIcon = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newKeyEyeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldKeyEyeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // oldKeyTextBox
            // 
            this.oldKeyTextBox.Location = new System.Drawing.Point(120, 9);
            this.oldKeyTextBox.Name = "oldKeyTextBox";
            this.oldKeyTextBox.Size = new System.Drawing.Size(121, 20);
            this.oldKeyTextBox.TabIndex = 0;
            this.oldKeyTextBox.UseSystemPasswordChar = true;
            this.oldKeyTextBox.TextChanged += new System.EventHandler(this.OldKeyTextBox_TextChanged);
            // 
            // newKeyTextBox
            // 
            this.newKeyTextBox.Location = new System.Drawing.Point(120, 43);
            this.newKeyTextBox.Name = "newKeyTextBox";
            this.newKeyTextBox.Size = new System.Drawing.Size(121, 20);
            this.newKeyTextBox.TabIndex = 1;
            this.newKeyTextBox.UseSystemPasswordChar = true;
            this.newKeyTextBox.TextChanged += new System.EventHandler(this.NewKeyTextBox_TextChanged);
            // 
            // oldKeyLabel
            // 
            this.oldKeyLabel.AutoSize = true;
            this.oldKeyLabel.Location = new System.Drawing.Point(61, 12);
            this.oldKeyLabel.Name = "oldKeyLabel";
            this.oldKeyLabel.Size = new System.Drawing.Size(47, 13);
            this.oldKeyLabel.TabIndex = 2;
            this.oldKeyLabel.Text = "Old Key:";
            // 
            // newKeyLabel
            // 
            this.newKeyLabel.AutoSize = true;
            this.newKeyLabel.Location = new System.Drawing.Point(61, 46);
            this.newKeyLabel.Name = "newKeyLabel";
            this.newKeyLabel.Size = new System.Drawing.Size(53, 13);
            this.newKeyLabel.TabIndex = 3;
            this.newKeyLabel.Text = "New Key:";
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(212, 81);
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
            this.mainPanel.Controls.Add(this.lockIcon);
            this.mainPanel.Controls.Add(this.newKeyEyeIcon);
            this.mainPanel.Controls.Add(this.oldKeyLabel);
            this.mainPanel.Controls.Add(this.oldKeyEyeIcon);
            this.mainPanel.Controls.Add(this.oldKeyTextBox);
            this.mainPanel.Controls.Add(this.newKeyTextBox);
            this.mainPanel.Controls.Add(this.newKeyLabel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(268, 75);
            this.mainPanel.TabIndex = 6;
            // 
            // lockIcon
            // 
            this.lockIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockIcon.Image = global::Crypto_Notepad.Properties.Resources.big_lock;
            this.lockIcon.Location = new System.Drawing.Point(8, 12);
            this.lockIcon.Name = "lockIcon";
            this.lockIcon.Size = new System.Drawing.Size(47, 47);
            this.lockIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lockIcon.TabIndex = 7;
            this.lockIcon.TabStop = false;
            // 
            // newKeyEyeIcon
            // 
            this.newKeyEyeIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newKeyEyeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newKeyEyeIcon.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.newKeyEyeIcon.Location = new System.Drawing.Point(247, 43);
            this.newKeyEyeIcon.Name = "newKeyEyeIcon";
            this.newKeyEyeIcon.Size = new System.Drawing.Size(18, 20);
            this.newKeyEyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.newKeyEyeIcon.TabIndex = 5;
            this.newKeyEyeIcon.TabStop = false;
            this.newKeyEyeIcon.Click += new System.EventHandler(this.NewKeyEyeIcon_Click);
            // 
            // oldKeyEyeIcon
            // 
            this.oldKeyEyeIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldKeyEyeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oldKeyEyeIcon.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.oldKeyEyeIcon.Location = new System.Drawing.Point(247, 9);
            this.oldKeyEyeIcon.Name = "oldKeyEyeIcon";
            this.oldKeyEyeIcon.Size = new System.Drawing.Size(18, 20);
            this.oldKeyEyeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.oldKeyEyeIcon.TabIndex = 5;
            this.oldKeyEyeIcon.TabStop = false;
            this.oldKeyEyeIcon.Click += new System.EventHandler(this.OldKeyEyeIcon_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(5, 87);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 16);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "status";
            this.statusLabel.Visible = false;
            // 
            // ChangeKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 111);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.acceptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeKeyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Key";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newKeyEyeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldKeyEyeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldKeyTextBox;
        private System.Windows.Forms.TextBox newKeyTextBox;
        private System.Windows.Forms.Label oldKeyLabel;
        private System.Windows.Forms.Label newKeyLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.PictureBox oldKeyEyeIcon;
        private System.Windows.Forms.PictureBox newKeyEyeIcon;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox lockIcon;
        private System.Windows.Forms.Label statusLabel;
    }
}