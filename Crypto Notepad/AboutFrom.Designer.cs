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
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.thirdPartyDevLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.LinkLabel();
            this.licenseLabel = new System.Windows.Forms.LinkLabel();
            this.githubLabel = new System.Windows.Forms.LinkLabel();
            this.contributorsLabel = new System.Windows.Forms.Label();
            this.contributorsList = new Crypto_Notepad.ExRichTextBox();
            this.thirdPartyDevList = new Crypto_Notepad.ExRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
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
            // appLogo
            // 
            this.appLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appLogo.Image = ((System.Drawing.Image)(resources.GetObject("appLogo.Image")));
            this.appLogo.Location = new System.Drawing.Point(341, 2);
            this.appLogo.Name = "appLogo";
            this.appLogo.Size = new System.Drawing.Size(77, 68);
            this.appLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appLogo.TabIndex = 1;
            this.appLogo.TabStop = false;
            this.appLogo.Click += new System.EventHandler(this.AppLogo_Click);
            // 
            // thirdPartyDevLabel
            // 
            this.thirdPartyDevLabel.AutoSize = true;
            this.thirdPartyDevLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdPartyDevLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.thirdPartyDevLabel.Location = new System.Drawing.Point(5, 158);
            this.thirdPartyDevLabel.Name = "thirdPartyDevLabel";
            this.thirdPartyDevLabel.Size = new System.Drawing.Size(200, 18);
            this.thirdPartyDevLabel.TabIndex = 4;
            this.thirdPartyDevLabel.Text = "Third-party developments";
            // 
            // authorLabel
            // 
            this.authorLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.authorLabel.AutoSize = true;
            this.authorLabel.DisabledLinkColor = System.Drawing.Color.White;
            this.authorLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.authorLabel.LinkArea = new System.Windows.Forms.LinkArea(38, 8);
            this.authorLabel.LinkColor = System.Drawing.Color.White;
            this.authorLabel.Location = new System.Drawing.Point(8, 38);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(317, 19);
            this.authorLabel.TabIndex = 9;
            this.authorLabel.TabStop = true;
            this.authorLabel.Text = "This is an open-source app created by Sigmanor";
            this.authorLabel.UseCompatibleTextRendering = true;
            this.authorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AuthorLabel_LinkClicked);
            // 
            // licenseLabel
            // 
            this.licenseLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.DisabledLinkColor = System.Drawing.Color.White;
            this.licenseLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.licenseLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.licenseLabel.LinkArea = new System.Windows.Forms.LinkArea(18, 3);
            this.licenseLabel.LinkColor = System.Drawing.Color.White;
            this.licenseLabel.Location = new System.Drawing.Point(8, 57);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(202, 19);
            this.licenseLabel.TabIndex = 9;
            this.licenseLabel.TabStop = true;
            this.licenseLabel.Text = "Distributed under MIT license";
            this.licenseLabel.UseCompatibleTextRendering = true;
            this.licenseLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LicenseLabel_LinkClicked);
            // 
            // githubLabel
            // 
            this.githubLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.githubLabel.AutoSize = true;
            this.githubLabel.DisabledLinkColor = System.Drawing.Color.White;
            this.githubLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.githubLabel.LinkArea = new System.Windows.Forms.LinkArea(52, 6);
            this.githubLabel.LinkColor = System.Drawing.Color.White;
            this.githubLabel.Location = new System.Drawing.Point(8, 75);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(399, 19);
            this.githubLabel.TabIndex = 9;
            this.githubLabel.TabStop = true;
            this.githubLabel.Text = "The source code, issues and documentation posted on GitHub";
            this.githubLabel.UseCompatibleTextRendering = true;
            this.githubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLabel_LinkClicked);
            // 
            // contributorsLabel
            // 
            this.contributorsLabel.AutoSize = true;
            this.contributorsLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contributorsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.contributorsLabel.Location = new System.Drawing.Point(5, 105);
            this.contributorsLabel.Name = "contributorsLabel";
            this.contributorsLabel.Size = new System.Drawing.Size(104, 18);
            this.contributorsLabel.TabIndex = 4;
            this.contributorsLabel.Text = "Contributors";
            // 
            // contributorsList
            // 
            this.contributorsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.contributorsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contributorsList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contributorsList.ForeColor = System.Drawing.SystemColors.Control;
            this.contributorsList.Location = new System.Drawing.Point(-1, 126);
            this.contributorsList.Name = "contributorsList";
            this.contributorsList.ReadOnly = true;
            this.contributorsList.RightMargin = 700;
            this.contributorsList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.contributorsList.ShowSelectionMargin = true;
            this.contributorsList.Size = new System.Drawing.Size(414, 20);
            this.contributorsList.TabIndex = 11;
            this.contributorsList.Text = "h5p9sl https://github.com/h5p9sl";
            this.contributorsList.WordWrap = false;
            this.contributorsList.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ContributorsList_LinkClicked);
            // 
            // thirdPartyDevList
            // 
            this.thirdPartyDevList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.thirdPartyDevList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdPartyDevList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdPartyDevList.ForeColor = System.Drawing.SystemColors.Control;
            this.thirdPartyDevList.Location = new System.Drawing.Point(-1, 179);
            this.thirdPartyDevList.Name = "thirdPartyDevList";
            this.thirdPartyDevList.ReadOnly = true;
            this.thirdPartyDevList.RightMargin = 700;
            this.thirdPartyDevList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.thirdPartyDevList.ShowSelectionMargin = true;
            this.thirdPartyDevList.Size = new System.Drawing.Size(414, 101);
            this.thirdPartyDevList.TabIndex = 10;
            this.thirdPartyDevList.Text = resources.GetString("thirdPartyDevList.Text");
            this.thirdPartyDevList.WordWrap = false;
            this.thirdPartyDevList.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.ThirdPartyDevList_LinkClicked);
            // 
            // AboutFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(411, 280);
            this.Controls.Add(this.contributorsList);
            this.Controls.Add(this.thirdPartyDevList);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.appLogo);
            this.Controls.Add(this.appVersionLabel);
            this.Controls.Add(this.contributorsLabel);
            this.Controls.Add(this.thirdPartyDevLabel);
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
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appVersionLabel;
        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label thirdPartyDevLabel;
        private System.Windows.Forms.LinkLabel authorLabel;
        private System.Windows.Forms.LinkLabel licenseLabel;
        private System.Windows.Forms.LinkLabel githubLabel;
        private System.Windows.Forms.Label contributorsLabel;
        private ExRichTextBox thirdPartyDevList;
        private ExRichTextBox contributorsList;
    }
}