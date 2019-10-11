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
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.picShowKey = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShowKey)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(64, 39);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(177, 20);
            this.txtKey.TabIndex = 0;
            this.txtKey.UseSystemPasswordChar = true;
            this.txtKey.TextChanged += new System.EventHandler(this.TxtKey_TextChanged);
            this.txtKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtKey_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(190, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // picShowKey
            // 
            this.picShowKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShowKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowKey.Image = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.picShowKey.InitialImage = global::Crypto_Notepad.Properties.Resources.eye_half;
            this.picShowKey.Location = new System.Drawing.Point(247, 39);
            this.picShowKey.Name = "picShowKey";
            this.picShowKey.Size = new System.Drawing.Size(18, 20);
            this.picShowKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picShowKey.TabIndex = 3;
            this.picShowKey.TabStop = false;
            this.picShowKey.Click += new System.EventHandler(this.KeyEyeIcon_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.picLock);
            this.pnlMain.Controls.Add(this.lblFileName);
            this.pnlMain.Controls.Add(this.txtKey);
            this.pnlMain.Controls.Add(this.picShowKey);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(269, 73);
            this.pnlMain.TabIndex = 5;
            // 
            // picLock
            // 
            this.picLock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLock.Image = global::Crypto_Notepad.Properties.Resources.big_lock;
            this.picLock.Location = new System.Drawing.Point(8, 12);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(47, 47);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLock.TabIndex = 6;
            this.picLock.TabStop = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoEllipsis = true;
            this.lblFileName.Location = new System.Drawing.Point(61, 12);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(196, 13);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "Enter the encryption key:";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnterKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 107);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crypto Notepad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterKeyForm_FormClosed);
            this.Load += new System.EventHandler(this.EnterKeyForm_Load);
            this.Shown += new System.EventHandler(this.EnterKeyForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picShowKey)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox picShowKey;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.PictureBox picLock;
        public System.Windows.Forms.TextBox txtKey;
    }
}