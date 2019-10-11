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
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblThirdPartyDev = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblLicense = new System.Windows.Forms.LinkLabel();
            this.lblGithub = new System.Windows.Forms.LinkLabel();
            this.lblContributors = new System.Windows.Forms.Label();
            this.rtbContributors = new Crypto_Notepad.ExRichTextBox();
            this.rtbThirdPartyDev = new Crypto_Notepad.ExRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAppVersion.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAppVersion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblAppVersion.Location = new System.Drawing.Point(5, 9);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(220, 22);
            this.lblAppVersion.TabIndex = 0;
            this.lblAppVersion.Text = "Crypto Notepad v1.0.0";
            this.lblAppVersion.Click += new System.EventHandler(this.LblAppVersion_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(341, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(77, 68);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // lblThirdPartyDev
            // 
            this.lblThirdPartyDev.AutoSize = true;
            this.lblThirdPartyDev.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblThirdPartyDev.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblThirdPartyDev.Location = new System.Drawing.Point(5, 158);
            this.lblThirdPartyDev.Name = "lblThirdPartyDev";
            this.lblThirdPartyDev.Size = new System.Drawing.Size(200, 18);
            this.lblThirdPartyDev.TabIndex = 4;
            this.lblThirdPartyDev.Text = "Third-party developments";
            // 
            // lblAuthor
            // 
            this.lblAuthor.ActiveLinkColor = System.Drawing.Color.White;
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.DisabledLinkColor = System.Drawing.Color.White;
            this.lblAuthor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAuthor.LinkArea = new System.Windows.Forms.LinkArea(38, 8);
            this.lblAuthor.LinkColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(8, 38);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(317, 19);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.TabStop = true;
            this.lblAuthor.Text = "This is an open-source app created by Sigmanor";
            this.lblAuthor.UseCompatibleTextRendering = true;
            this.lblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblAuthor_LinkClicked);
            // 
            // lblLicense
            // 
            this.lblLicense.ActiveLinkColor = System.Drawing.Color.White;
            this.lblLicense.AutoSize = true;
            this.lblLicense.DisabledLinkColor = System.Drawing.Color.White;
            this.lblLicense.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLicense.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLicense.LinkArea = new System.Windows.Forms.LinkArea(18, 3);
            this.lblLicense.LinkColor = System.Drawing.Color.White;
            this.lblLicense.Location = new System.Drawing.Point(8, 57);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(202, 19);
            this.lblLicense.TabIndex = 9;
            this.lblLicense.TabStop = true;
            this.lblLicense.Text = "Distributed under MIT license";
            this.lblLicense.UseCompatibleTextRendering = true;
            this.lblLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLicense_LinkClicked);
            // 
            // lblGithub
            // 
            this.lblGithub.ActiveLinkColor = System.Drawing.Color.White;
            this.lblGithub.AutoSize = true;
            this.lblGithub.DisabledLinkColor = System.Drawing.Color.White;
            this.lblGithub.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGithub.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGithub.LinkArea = new System.Windows.Forms.LinkArea(52, 6);
            this.lblGithub.LinkColor = System.Drawing.Color.White;
            this.lblGithub.Location = new System.Drawing.Point(8, 75);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(399, 19);
            this.lblGithub.TabIndex = 9;
            this.lblGithub.TabStop = true;
            this.lblGithub.Text = "The source code, issues and documentation posted on GitHub";
            this.lblGithub.UseCompatibleTextRendering = true;
            this.lblGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblGithub_LinkClicked);
            // 
            // lblContributors
            // 
            this.lblContributors.AutoSize = true;
            this.lblContributors.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContributors.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblContributors.Location = new System.Drawing.Point(5, 105);
            this.lblContributors.Name = "lblContributors";
            this.lblContributors.Size = new System.Drawing.Size(104, 18);
            this.lblContributors.TabIndex = 4;
            this.lblContributors.Text = "Contributors";
            // 
            // rtbContributors
            // 
            this.rtbContributors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.rtbContributors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContributors.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbContributors.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbContributors.Location = new System.Drawing.Point(-1, 126);
            this.rtbContributors.Name = "rtbContributors";
            this.rtbContributors.ReadOnly = true;
            this.rtbContributors.RightMargin = 700;
            this.rtbContributors.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbContributors.ShowSelectionMargin = true;
            this.rtbContributors.Size = new System.Drawing.Size(414, 20);
            this.rtbContributors.TabIndex = 11;
            this.rtbContributors.Text = "h5p9sl https://github.com/h5p9sl";
            this.rtbContributors.WordWrap = false;
            this.rtbContributors.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RtbContributors_LinkClicked);
            // 
            // rtbThirdPartyDev
            // 
            this.rtbThirdPartyDev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.rtbThirdPartyDev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbThirdPartyDev.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbThirdPartyDev.ForeColor = System.Drawing.SystemColors.Control;
            this.rtbThirdPartyDev.Location = new System.Drawing.Point(-1, 179);
            this.rtbThirdPartyDev.Name = "rtbThirdPartyDev";
            this.rtbThirdPartyDev.ReadOnly = true;
            this.rtbThirdPartyDev.RightMargin = 700;
            this.rtbThirdPartyDev.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.rtbThirdPartyDev.ShowSelectionMargin = true;
            this.rtbThirdPartyDev.Size = new System.Drawing.Size(414, 101);
            this.rtbThirdPartyDev.TabIndex = 10;
            this.rtbThirdPartyDev.Text = resources.GetString("rtbThirdPartyDev.Text");
            this.rtbThirdPartyDev.WordWrap = false;
            this.rtbThirdPartyDev.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.RtbThirdPartyDev_LinkClicked);
            // 
            // AboutFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(411, 280);
            this.Controls.Add(this.rtbContributors);
            this.Controls.Add(this.rtbThirdPartyDev);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblContributors);
            this.Controls.Add(this.lblThirdPartyDev);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblThirdPartyDev;
        private System.Windows.Forms.LinkLabel lblAuthor;
        private System.Windows.Forms.LinkLabel lblLicense;
        private System.Windows.Forms.LinkLabel lblGithub;
        private System.Windows.Forms.Label lblContributors;
        private ExRichTextBox rtbThirdPartyDev;
        private ExRichTextBox rtbContributors;
    }
}