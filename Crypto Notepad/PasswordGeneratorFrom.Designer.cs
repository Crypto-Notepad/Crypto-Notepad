namespace Crypto_Notepad
{
    partial class PasswordGeneratorFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeneratorFrom));
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordsList = new System.Windows.Forms.TextBox();
            this.clearPasswordsListButton = new System.Windows.Forms.Button();
            this.lowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numericCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordLengthTextBox = new System.Windows.Forms.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(303, 127);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(79, 23);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // passwordsList
            // 
            this.passwordsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordsList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordsList.Location = new System.Drawing.Point(7, 7);
            this.passwordsList.Multiline = true;
            this.passwordsList.Name = "passwordsList";
            this.passwordsList.ReadOnly = true;
            this.passwordsList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passwordsList.Size = new System.Drawing.Size(290, 172);
            this.passwordsList.TabIndex = 7;
            this.passwordsList.WordWrap = false;
            // 
            // clearPasswordsListButton
            // 
            this.clearPasswordsListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearPasswordsListButton.Location = new System.Drawing.Point(303, 156);
            this.clearPasswordsListButton.Name = "clearPasswordsListButton";
            this.clearPasswordsListButton.Size = new System.Drawing.Size(79, 23);
            this.clearPasswordsListButton.TabIndex = 6;
            this.clearPasswordsListButton.Text = "Clear";
            this.clearPasswordsListButton.UseVisualStyleBackColor = true;
            this.clearPasswordsListButton.Click += new System.EventHandler(this.ClearPasswordsListButton_Click);
            // 
            // lowercaseCheckBox
            // 
            this.lowercaseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lowercaseCheckBox.AutoSize = true;
            this.lowercaseCheckBox.Checked = true;
            this.lowercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseCheckBox.Location = new System.Drawing.Point(303, 7);
            this.lowercaseCheckBox.Name = "lowercaseCheckBox";
            this.lowercaseCheckBox.Size = new System.Drawing.Size(79, 17);
            this.lowercaseCheckBox.TabIndex = 0;
            this.lowercaseCheckBox.Text = "Lowercase";
            this.lowercaseCheckBox.UseVisualStyleBackColor = true;
            this.lowercaseCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.lowercaseCheckBox.Click += new System.EventHandler(this.LowercaseCheckBox_Click);
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Checked = true;
            this.uppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(303, 30);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(80, 17);
            this.uppercaseCheckBox.TabIndex = 1;
            this.uppercaseCheckBox.Text = "Uppercase";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.uppercaseCheckBox.Click += new System.EventHandler(this.UppercaseCheckBox_Click);
            // 
            // numericCheckBox
            // 
            this.numericCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericCheckBox.AutoSize = true;
            this.numericCheckBox.Checked = true;
            this.numericCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numericCheckBox.Location = new System.Drawing.Point(303, 53);
            this.numericCheckBox.Name = "numericCheckBox";
            this.numericCheckBox.Size = new System.Drawing.Size(68, 17);
            this.numericCheckBox.TabIndex = 2;
            this.numericCheckBox.Text = "Numeric";
            this.numericCheckBox.UseVisualStyleBackColor = true;
            this.numericCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.numericCheckBox.Click += new System.EventHandler(this.NumericCheckBox_Click);
            // 
            // specialCheckBox
            // 
            this.specialCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.specialCheckBox.AutoSize = true;
            this.specialCheckBox.Checked = true;
            this.specialCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.specialCheckBox.Location = new System.Drawing.Point(303, 76);
            this.specialCheckBox.Name = "specialCheckBox";
            this.specialCheckBox.Size = new System.Drawing.Size(62, 17);
            this.specialCheckBox.TabIndex = 3;
            this.specialCheckBox.Text = "Special";
            this.specialCheckBox.UseVisualStyleBackColor = true;
            this.specialCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.specialCheckBox.Click += new System.EventHandler(this.SpecialCheckBox_Click);
            // 
            // passwordLengthTextBox
            // 
            this.passwordLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLengthTextBox.Location = new System.Drawing.Point(303, 99);
            this.passwordLengthTextBox.Name = "passwordLengthTextBox";
            this.passwordLengthTextBox.Placeholder = "Length";
            this.passwordLengthTextBox.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.passwordLengthTextBox.PlaceholderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLengthTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordLengthTextBox.Size = new System.Drawing.Size(79, 22);
            this.passwordLengthTextBox.TabIndex = 4;
            this.passwordLengthTextBox.Text = "40";
            this.passwordLengthTextBox.TextChanged += new System.EventHandler(this.PasswordValidation);
            this.passwordLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLengthTextBox_KeyPress);
            // 
            // PasswordGeneratorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 186);
            this.Controls.Add(this.passwordLengthTextBox);
            this.Controls.Add(this.specialCheckBox);
            this.Controls.Add(this.numericCheckBox);
            this.Controls.Add(this.uppercaseCheckBox);
            this.Controls.Add(this.lowercaseCheckBox);
            this.Controls.Add(this.clearPasswordsListButton);
            this.Controls.Add(this.passwordsList);
            this.Controls.Add(this.generateButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(404, 225);
            this.Name = "PasswordGeneratorFrom";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Password Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordGeneratorFrom_FormClosing);
            this.Load += new System.EventHandler(this.PasswordGeneratorFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordsList;
        private System.Windows.Forms.Button clearPasswordsListButton;
        private System.Windows.Forms.CheckBox lowercaseCheckBox;
        private System.Windows.Forms.CheckBox uppercaseCheckBox;
        private System.Windows.Forms.CheckBox numericCheckBox;
        private System.Windows.Forms.CheckBox specialCheckBox;
        private System.Windows.Forms.PlaceholderTextBox passwordLengthTextBox;
    }
}