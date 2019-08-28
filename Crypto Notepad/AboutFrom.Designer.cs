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
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.AppLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.TPDLabel = new System.Windows.Forms.Label();
            this.AuthorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GithubLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ContributorsLabel = new System.Windows.Forms.Label();
            this.ContributorsRichTextBox = new Crypto_Notepad.ExRichTextBox();
            this.TPDRichTextBox = new Crypto_Notepad.ExRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppVersionLabel.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppVersionLabel.ForeColor = System.Drawing.Color.White;
            this.AppVersionLabel.Location = new System.Drawing.Point(5, 6);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(220, 22);
            this.AppVersionLabel.TabIndex = 0;
            this.AppVersionLabel.Text = "Crypto Notepad v1.0.0";
            this.AppVersionLabel.Click += new System.EventHandler(this.AppVersionLabel_Click);
            // 
            // AppLogoPictureBox
            // 
            this.AppLogoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AppLogoPictureBox.Image")));
            this.AppLogoPictureBox.Location = new System.Drawing.Point(320, 2);
            this.AppLogoPictureBox.Name = "AppLogoPictureBox";
            this.AppLogoPictureBox.Size = new System.Drawing.Size(77, 68);
            this.AppLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppLogoPictureBox.TabIndex = 1;
            this.AppLogoPictureBox.TabStop = false;
            this.AppLogoPictureBox.Click += new System.EventHandler(this.AppLogoPictureBox_Click);
            // 
            // TPDLabel
            // 
            this.TPDLabel.AutoSize = true;
            this.TPDLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPDLabel.ForeColor = System.Drawing.Color.White;
            this.TPDLabel.Location = new System.Drawing.Point(6, 160);
            this.TPDLabel.Name = "TPDLabel";
            this.TPDLabel.Size = new System.Drawing.Size(182, 15);
            this.TPDLabel.TabIndex = 4;
            this.TPDLabel.Text = "Third-party developments:";
            // 
            // AuthorLinkLabel
            // 
            this.AuthorLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.AuthorLinkLabel.AutoSize = true;
            this.AuthorLinkLabel.DisabledLinkColor = System.Drawing.Color.White;
            this.AuthorLinkLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLinkLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(38, 8);
            this.AuthorLinkLabel.LinkColor = System.Drawing.Color.White;
            this.AuthorLinkLabel.Location = new System.Drawing.Point(9, 39);
            this.AuthorLinkLabel.Name = "AuthorLinkLabel";
            this.AuthorLinkLabel.Size = new System.Drawing.Size(291, 18);
            this.AuthorLinkLabel.TabIndex = 9;
            this.AuthorLinkLabel.TabStop = true;
            this.AuthorLinkLabel.Text = "This is an open-source app created by Sigmanor";
            this.AuthorLinkLabel.UseCompatibleTextRendering = true;
            this.AuthorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLinkLabel_LinkClicked);
            // 
            // LicenseLinkLabel
            // 
            this.LicenseLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.LicenseLinkLabel.AutoSize = true;
            this.LicenseLinkLabel.DisabledLinkColor = System.Drawing.Color.White;
            this.LicenseLinkLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseLinkLabel.ForeColor = System.Drawing.Color.White;
            this.LicenseLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(18, 3);
            this.LicenseLinkLabel.LinkColor = System.Drawing.Color.White;
            this.LicenseLinkLabel.Location = new System.Drawing.Point(9, 57);
            this.LicenseLinkLabel.Name = "LicenseLinkLabel";
            this.LicenseLinkLabel.Size = new System.Drawing.Size(185, 18);
            this.LicenseLinkLabel.TabIndex = 9;
            this.LicenseLinkLabel.TabStop = true;
            this.LicenseLinkLabel.Text = "Distributed under MIT license";
            this.LicenseLinkLabel.UseCompatibleTextRendering = true;
            this.LicenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LicenseLinkLabel_LinkClicked);
            // 
            // GithubLinkLabel
            // 
            this.GithubLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.GithubLinkLabel.AutoSize = true;
            this.GithubLinkLabel.DisabledLinkColor = System.Drawing.Color.White;
            this.GithubLinkLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GithubLinkLabel.ForeColor = System.Drawing.Color.White;
            this.GithubLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(52, 6);
            this.GithubLinkLabel.LinkColor = System.Drawing.Color.White;
            this.GithubLinkLabel.Location = new System.Drawing.Point(9, 75);
            this.GithubLinkLabel.Name = "GithubLinkLabel";
            this.GithubLinkLabel.Size = new System.Drawing.Size(366, 18);
            this.GithubLinkLabel.TabIndex = 9;
            this.GithubLinkLabel.TabStop = true;
            this.GithubLinkLabel.Text = "The source code, issues and documentation posted on GitHub";
            this.GithubLinkLabel.UseCompatibleTextRendering = true;
            this.GithubLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLabel_LinkClicked);
            // 
            // ContributorsLabel
            // 
            this.ContributorsLabel.AutoSize = true;
            this.ContributorsLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContributorsLabel.ForeColor = System.Drawing.Color.White;
            this.ContributorsLabel.Location = new System.Drawing.Point(6, 105);
            this.ContributorsLabel.Name = "ContributorsLabel";
            this.ContributorsLabel.Size = new System.Drawing.Size(98, 15);
            this.ContributorsLabel.TabIndex = 4;
            this.ContributorsLabel.Text = "Contributors:";
            // 
            // ContributorsRichTextBox
            // 
            this.ContributorsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ContributorsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContributorsRichTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContributorsRichTextBox.ForeColor = System.Drawing.Color.White;
            this.ContributorsRichTextBox.Location = new System.Drawing.Point(0, 125);
            this.ContributorsRichTextBox.Name = "ContributorsRichTextBox";
            this.ContributorsRichTextBox.ReadOnly = true;
            this.ContributorsRichTextBox.RightMargin = 700;
            this.ContributorsRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ContributorsRichTextBox.ShowSelectionMargin = true;
            this.ContributorsRichTextBox.Size = new System.Drawing.Size(397, 18);
            this.ContributorsRichTextBox.TabIndex = 11;
            this.ContributorsRichTextBox.Text = "h5p9sl https://github.com/h5p9sl";
            this.ContributorsRichTextBox.WordWrap = false;
            this.ContributorsRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ContributorsRichTextBox_LinkClicked);
            // 
            // TPDRichTextBox
            // 
            this.TPDRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.TPDRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TPDRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TPDRichTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TPDRichTextBox.ForeColor = System.Drawing.Color.White;
            this.TPDRichTextBox.Location = new System.Drawing.Point(0, 184);
            this.TPDRichTextBox.Name = "TPDRichTextBox";
            this.TPDRichTextBox.ReadOnly = true;
            this.TPDRichTextBox.RightMargin = 700;
            this.TPDRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.TPDRichTextBox.ShowSelectionMargin = true;
            this.TPDRichTextBox.Size = new System.Drawing.Size(397, 100);
            this.TPDRichTextBox.TabIndex = 10;
            this.TPDRichTextBox.Text = resources.GetString("TPDRichTextBox.Text");
            this.TPDRichTextBox.WordWrap = false;
            this.TPDRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.TPDRichTextBox_LinkClicked);
            // 
            // AboutFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(397, 284);
            this.Controls.Add(this.ContributorsRichTextBox);
            this.Controls.Add(this.TPDRichTextBox);
            this.Controls.Add(this.GithubLinkLabel);
            this.Controls.Add(this.LicenseLinkLabel);
            this.Controls.Add(this.AuthorLinkLabel);
            this.Controls.Add(this.AppLogoPictureBox);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.ContributorsLabel);
            this.Controls.Add(this.TPDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutWindow_Load);
            this.Click += new System.EventHandler(this.AboutFrom_Click);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppVersionLabel;
        private System.Windows.Forms.PictureBox AppLogoPictureBox;
        private System.Windows.Forms.Label TPDLabel;
        private System.Windows.Forms.LinkLabel AuthorLinkLabel;
        private System.Windows.Forms.LinkLabel LicenseLinkLabel;
        private System.Windows.Forms.LinkLabel GithubLinkLabel;
        private System.Windows.Forms.Label ContributorsLabel;
        private ExRichTextBox TPDRichTextBox;
        private ExRichTextBox ContributorsRichTextBox;
    }
}