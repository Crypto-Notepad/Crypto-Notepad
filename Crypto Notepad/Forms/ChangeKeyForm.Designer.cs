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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeKeyForm));
            this.acceptButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lockPictureBox = new System.Windows.Forms.PictureBox();
            this.showNewKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.showOldKeyPictureBox = new System.Windows.Forms.PictureBox();
            this.oldKeyTextBox = new System.Windows.Forms.PlaceholderTextBox();
            this.newKeyTextBox = new System.Windows.Forms.PlaceholderTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.changeKeyFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordGeneratorButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNewKeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showOldKeyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.Enabled = false;
            this.acceptButton.Location = new System.Drawing.Point(211, 80);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(53, 25);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lockPictureBox);
            this.mainPanel.Controls.Add(this.showNewKeyPictureBox);
            this.mainPanel.Controls.Add(this.showOldKeyPictureBox);
            this.mainPanel.Controls.Add(this.oldKeyTextBox);
            this.mainPanel.Controls.Add(this.newKeyTextBox);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(295, 75);
            this.mainPanel.TabIndex = 6;
            // 
            // lockPictureBox
            // 
            this.lockPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lockPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lockPictureBox.Image = global::Crypto_Notepad.Properties.Resources.gnupg_keys;
            this.lockPictureBox.Location = new System.Drawing.Point(8, 14);
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
            this.showNewKeyPictureBox.Location = new System.Drawing.Point(269, 39);
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
            this.showOldKeyPictureBox.Location = new System.Drawing.Point(269, 14);
            this.showOldKeyPictureBox.Name = "showOldKeyPictureBox";
            this.showOldKeyPictureBox.Size = new System.Drawing.Size(18, 22);
            this.showOldKeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.showOldKeyPictureBox.TabIndex = 5;
            this.showOldKeyPictureBox.TabStop = false;
            this.showOldKeyPictureBox.Click += new System.EventHandler(this.ShowOldKeyPictureBox_Click);
            // 
            // oldKeyTextBox
            // 
            this.oldKeyTextBox.Location = new System.Drawing.Point(64, 14);
            this.oldKeyTextBox.Name = "oldKeyTextBox";
            this.oldKeyTextBox.Placeholder = "Old password";
            this.oldKeyTextBox.PlaceholderActiveForeColor = System.Drawing.Color.DarkGray;
            this.oldKeyTextBox.PlaceholderFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.oldKeyTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.oldKeyTextBox.Size = new System.Drawing.Size(206, 22);
            this.oldKeyTextBox.TabIndex = 0;
            this.oldKeyTextBox.UseSystemPasswordChar = true;
            this.oldKeyTextBox.TextChanged += new System.EventHandler(this.OldKeyTextBox_TextChanged);
            this.oldKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OldKeyTextBox_KeyDown);
            // 
            // newKeyTextBox
            // 
            this.newKeyTextBox.Location = new System.Drawing.Point(64, 39);
            this.newKeyTextBox.Name = "newKeyTextBox";
            this.newKeyTextBox.Placeholder = "New password";
            this.newKeyTextBox.PlaceholderActiveForeColor = System.Drawing.Color.DarkGray;
            this.newKeyTextBox.PlaceholderFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.newKeyTextBox.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.newKeyTextBox.Size = new System.Drawing.Size(206, 22);
            this.newKeyTextBox.TabIndex = 1;
            this.newKeyTextBox.UseSystemPasswordChar = true;
            this.newKeyTextBox.TextChanged += new System.EventHandler(this.NewKeyTextBox_TextChanged);
            this.newKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewKeyTextBox_KeyDown);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(2, 85);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 15);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "status";
            // 
            // passwordGeneratorButton
            // 
            this.passwordGeneratorButton.Image = global::Crypto_Notepad.Properties.Resources.key_plus;
            this.passwordGeneratorButton.Location = new System.Drawing.Point(266, 80);
            this.passwordGeneratorButton.Name = "passwordGeneratorButton";
            this.passwordGeneratorButton.Size = new System.Drawing.Size(25, 25);
            this.passwordGeneratorButton.TabIndex = 9;
            this.changeKeyFormToolTip.SetToolTip(this.passwordGeneratorButton, "Password Generator");
            this.passwordGeneratorButton.UseVisualStyleBackColor = true;
            this.passwordGeneratorButton.Click += new System.EventHandler(this.PasswordGeneratorButton_Click);
            // 
            // ChangeKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 110);
            this.Controls.Add(this.passwordGeneratorButton);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeKeyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Password";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNewKeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showOldKeyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PlaceholderTextBox oldKeyTextBox;
        private System.Windows.Forms.PlaceholderTextBox newKeyTextBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.PictureBox showOldKeyPictureBox;
        private System.Windows.Forms.PictureBox showNewKeyPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox lockPictureBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolTip changeKeyFormToolTip;
        private System.Windows.Forms.Button passwordGeneratorButton;
    }
}