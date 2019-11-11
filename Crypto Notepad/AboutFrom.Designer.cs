namespace Crypto_Notepad
{
    partial class AboutFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutFrom));
            this.appVersionLabel = new System.Windows.Forms.Label();
            this.appLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdPartyDevLabel = new System.Windows.Forms.Label();
            this.appInfoLabel1 = new System.Windows.Forms.LinkLabel();
            this.appInfoLabel2 = new System.Windows.Forms.LinkLabel();
            this.appInfoLabel3 = new System.Windows.Forms.LinkLabel();
            this.contributorsLabel = new System.Windows.Forms.Label();
            this.contributorsRichTextBox = new Crypto_Notepad.ExRichTextBox();
            this.thirdPartyDevRichTextBox = new Crypto_Notepad.ExRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // appVersionLabel
            // 
            this.appVersionLabel.AutoSize = true;
            this.appVersionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appVersionLabel.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appVersionLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.appVersionLabel.Location = new System.Drawing.Point(5, 9);
            this.appVersionLabel.Name = "appVersionLabel";
            this.appVersionLabel.Size = new System.Drawing.Size(220, 22);
            this.appVersionLabel.TabIndex = 0;
            this.appVersionLabel.Text = "Crypto Notepad v1.0.0";
            this.appVersionLabel.Click += new System.EventHandler(this.AppVersionLabel_Click);
            // 
            // appLogoPictureBox
            // 
            this.appLogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("appLogoPictureBox.Image")));
            this.appLogoPictureBox.Location = new System.Drawing.Point(341, 2);
            this.appLogoPictureBox.Name = "appLogoPictureBox";
            this.appLogoPictureBox.Size = new System.Drawing.Size(77, 68);
            this.appLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogoPictureBox.TabIndex = 1;
            this.appLogoPictureBox.TabStop = false;
            this.appLogoPictureBox.Click += new System.EventHandler(this.AppLogoPictureBox_Click);
            // 
            // thirdPartyDevLabel
            // 
            this.thirdPartyDevLabel.AutoSize = true;
            this.thirdPartyDevLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdPartyDevLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.thirdPartyDevLabel.Location = new System.Drawing.Point(5, 173);
            this.thirdPartyDevLabel.Name = "thirdPartyDevLabel";
            this.thirdPartyDevLabel.Size = new System.Drawing.Size(200, 18);
            this.thirdPartyDevLabel.TabIndex = 4;
            this.thirdPartyDevLabel.Text = "Third-party developments";
            // 
            // appInfoLabel1
            // 
            this.appInfoLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.appInfoLabel1.AutoSize = true;
            this.appInfoLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.appInfoLabel1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appInfoLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.appInfoLabel1.LinkArea = new System.Windows.Forms.LinkArea(38, 8);
            this.appInfoLabel1.LinkColor = System.Drawing.Color.White;
            this.appInfoLabel1.Location = new System.Drawing.Point(8, 38);
            this.appInfoLabel1.Name = "appInfoLabel1";
            this.appInfoLabel1.Size = new System.Drawing.Size(317, 19);
            this.appInfoLabel1.TabIndex = 9;
            this.appInfoLabel1.TabStop = true;
            this.appInfoLabel1.Text = "This is an open-source app created by Sigmanor";
            this.appInfoLabel1.UseCompatibleTextRendering = true;
            this.appInfoLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppInfoLabel1_LinkClicked);
            // 
            // appInfoLabel2
            // 
            this.appInfoLabel2.ActiveLinkColor = System.Drawing.Color.White;
            this.appInfoLabel2.AutoSize = true;
            this.appInfoLabel2.DisabledLinkColor = System.Drawing.Color.White;
            this.appInfoLabel2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appInfoLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.appInfoLabel2.LinkArea = new System.Windows.Forms.LinkArea(18, 3);
            this.appInfoLabel2.LinkColor = System.Drawing.Color.White;
            this.appInfoLabel2.Location = new System.Drawing.Point(8, 57);
            this.appInfoLabel2.Name = "appInfoLabel2";
            this.appInfoLabel2.Size = new System.Drawing.Size(202, 19);
            this.appInfoLabel2.TabIndex = 9;
            this.appInfoLabel2.TabStop = true;
            this.appInfoLabel2.Text = "Distributed under MIT license";
            this.appInfoLabel2.UseCompatibleTextRendering = true;
            this.appInfoLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppInfoLabel1_LinkClicked);
            // 
            // appInfoLabel3
            // 
            this.appInfoLabel3.ActiveLinkColor = System.Drawing.Color.White;
            this.appInfoLabel3.AutoSize = true;
            this.appInfoLabel3.DisabledLinkColor = System.Drawing.Color.White;
            this.appInfoLabel3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appInfoLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.appInfoLabel3.LinkArea = new System.Windows.Forms.LinkArea(52, 6);
            this.appInfoLabel3.LinkColor = System.Drawing.Color.White;
            this.appInfoLabel3.Location = new System.Drawing.Point(8, 75);
            this.appInfoLabel3.Name = "appInfoLabel3";
            this.appInfoLabel3.Size = new System.Drawing.Size(399, 19);
            this.appInfoLabel3.TabIndex = 9;
            this.appInfoLabel3.TabStop = true;
            this.appInfoLabel3.Text = "The source code, issues and documentation posted on GitHub";
            this.appInfoLabel3.UseCompatibleTextRendering = true;
            this.appInfoLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AppInfoLabel3_LinkClicked);
            // 
            // contributorsLabel
            // 
            this.contributorsLabel.AutoSize = true;
            this.contributorsLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contributorsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.contributorsLabel.Location = new System.Drawing.Point(5, 105);
            this.contributorsLabel.Name = "contributorsLabel";
            this.contributorsLabel.Size = new System.Drawing.Size(168, 18);
            this.contributorsLabel.TabIndex = 4;
            this.contributorsLabel.Text = "Contributors/testers";
            // 
            // contributorsRichTextBox
            // 
            this.contributorsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.contributorsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contributorsRichTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contributorsRichTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.contributorsRichTextBox.Location = new System.Drawing.Point(-1, 126);
            this.contributorsRichTextBox.Name = "contributorsRichTextBox";
            this.contributorsRichTextBox.ReadOnly = true;
            this.contributorsRichTextBox.RightMargin = 700;
            this.contributorsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.contributorsRichTextBox.ShowSelectionMargin = true;
            this.contributorsRichTextBox.Size = new System.Drawing.Size(414, 40);
            this.contributorsRichTextBox.TabIndex = 11;
            this.contributorsRichTextBox.Text = "h5p9sl https://github.com/h5p9sl\nsmaragdus https://github.com/smaragdus";
            this.contributorsRichTextBox.WordWrap = false;
            this.contributorsRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ContributorsRichTextBox_LinkClicked);
            // 
            // thirdPartyDevRichTextBox
            // 
            this.thirdPartyDevRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.thirdPartyDevRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdPartyDevRichTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdPartyDevRichTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.thirdPartyDevRichTextBox.Location = new System.Drawing.Point(-1, 194);
            this.thirdPartyDevRichTextBox.Name = "thirdPartyDevRichTextBox";
            this.thirdPartyDevRichTextBox.ReadOnly = true;
            this.thirdPartyDevRichTextBox.RightMargin = 700;
            this.thirdPartyDevRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.thirdPartyDevRichTextBox.ShowSelectionMargin = true;
            this.thirdPartyDevRichTextBox.Size = new System.Drawing.Size(414, 141);
            this.thirdPartyDevRichTextBox.TabIndex = 10;
            this.thirdPartyDevRichTextBox.Text = resources.GetString("thirdPartyDevRichTextBox.Text");
            this.thirdPartyDevRichTextBox.WordWrap = false;
            this.thirdPartyDevRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ThirdPartyDevRichTextBox_LinkClicked);
            // 
            // AboutFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(411, 335);
            this.Controls.Add(this.contributorsRichTextBox);
            this.Controls.Add(this.thirdPartyDevRichTextBox);
            this.Controls.Add(this.appInfoLabel3);
            this.Controls.Add(this.appInfoLabel2);
            this.Controls.Add(this.appInfoLabel1);
            this.Controls.Add(this.appLogoPictureBox);
            this.Controls.Add(this.appVersionLabel);
            this.Controls.Add(this.contributorsLabel);
            this.Controls.Add(this.thirdPartyDevLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutFrom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.Click += new System.EventHandler(this.AboutFrom_Click);
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appVersionLabel;
        private System.Windows.Forms.PictureBox appLogoPictureBox;
        private System.Windows.Forms.Label thirdPartyDevLabel;
        private System.Windows.Forms.LinkLabel appInfoLabel1;
        private System.Windows.Forms.LinkLabel appInfoLabel2;
        private System.Windows.Forms.LinkLabel appInfoLabel3;
        private System.Windows.Forms.Label contributorsLabel;
        private ExRichTextBox thirdPartyDevRichTextBox;
        private ExRichTextBox contributorsRichTextBox;
    }
}