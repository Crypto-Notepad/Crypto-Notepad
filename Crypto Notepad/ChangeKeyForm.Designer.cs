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
            this.txtOldKey = new System.Windows.Forms.TextBox();
            this.txtNewKey = new System.Windows.Forms.TextBox();
            this.lblOldKey = new System.Windows.Forms.Label();
            this.lblNewKey = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.picNewKey = new System.Windows.Forms.PictureBox();
            this.picOldKey = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOldKey)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOldKey
            // 
            this.txtOldKey.Location = new System.Drawing.Point(120, 9);
            this.txtOldKey.Name = "txtOldKey";
            this.txtOldKey.Size = new System.Drawing.Size(121, 20);
            this.txtOldKey.TabIndex = 0;
            this.txtOldKey.UseSystemPasswordChar = true;
            this.txtOldKey.TextChanged += new System.EventHandler(this.TxtOldKey_TextChanged);
            // 
            // txtNewKey
            // 
            this.txtNewKey.Location = new System.Drawing.Point(120, 43);
            this.txtNewKey.Name = "txtNewKey";
            this.txtNewKey.Size = new System.Drawing.Size(121, 20);
            this.txtNewKey.TabIndex = 1;
            this.txtNewKey.UseSystemPasswordChar = true;
            this.txtNewKey.TextChanged += new System.EventHandler(this.TxtNewKey_TextChanged);
            // 
            // lblOldKey
            // 
            this.lblOldKey.AutoSize = true;
            this.lblOldKey.Location = new System.Drawing.Point(61, 12);
            this.lblOldKey.Name = "lblOldKey";
            this.lblOldKey.Size = new System.Drawing.Size(47, 13);
            this.lblOldKey.TabIndex = 2;
            this.lblOldKey.Text = "Old Key:";
            // 
            // lblNewKey
            // 
            this.lblNewKey.AutoSize = true;
            this.lblNewKey.Location = new System.Drawing.Point(61, 46);
            this.lblNewKey.Name = "lblNewKey";
            this.lblNewKey.Size = new System.Drawing.Size(53, 13);
            this.lblNewKey.TabIndex = 3;
            this.lblNewKey.Text = "New Key:";
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(212, 81);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(53, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.picLock);
            this.pnlMain.Controls.Add(this.picNewKey);
            this.pnlMain.Controls.Add(this.lblOldKey);
            this.pnlMain.Controls.Add(this.picOldKey);
            this.pnlMain.Controls.Add(this.txtOldKey);
            this.pnlMain.Controls.Add(this.txtNewKey);
            this.pnlMain.Controls.Add(this.lblNewKey);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(268, 75);
            this.pnlMain.TabIndex = 6;
            // 
            // picLock
            // 
            this.picLock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLock.Image = global::Crypto_Notepad.Properties.Resources.big_lock;
            this.picLock.Location = new System.Drawing.Point(8, 12);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(47, 47);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLock.TabIndex = 7;
            this.picLock.TabStop = false;
            // 
            // picNewKey
            // 
            this.picNewKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNewKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNewKey.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.picNewKey.Location = new System.Drawing.Point(247, 43);
            this.picNewKey.Name = "picNewKey";
            this.picNewKey.Size = new System.Drawing.Size(18, 20);
            this.picNewKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNewKey.TabIndex = 5;
            this.picNewKey.TabStop = false;
            this.picNewKey.Click += new System.EventHandler(this.PicNewKeyEyeIcon_Click);
            // 
            // picOldKey
            // 
            this.picOldKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOldKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOldKey.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.picOldKey.Location = new System.Drawing.Point(247, 9);
            this.picOldKey.Name = "picOldKey";
            this.picOldKey.Size = new System.Drawing.Size(18, 20);
            this.picOldKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picOldKey.TabIndex = 5;
            this.picOldKey.TabStop = false;
            this.picOldKey.Click += new System.EventHandler(this.PicOldKeyEyeIcon_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(5, 87);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "status";
            this.lblStatus.Visible = false;
            // 
            // ChangeKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 111);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeKeyForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Key";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOldKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldKey;
        private System.Windows.Forms.TextBox txtNewKey;
        private System.Windows.Forms.Label lblOldKey;
        private System.Windows.Forms.Label lblNewKey;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.PictureBox picOldKey;
        private System.Windows.Forms.PictureBox picNewKey;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.Label lblStatus;
    }
}