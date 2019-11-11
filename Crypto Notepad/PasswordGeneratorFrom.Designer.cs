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
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordsList = new System.Windows.Forms.TextBox();
            this.clearPasswordsListButton = new System.Windows.Forms.Button();
            this.includeLowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.includeUppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.includeNumericCheckBox = new System.Windows.Forms.CheckBox();
            this.includeSpecialCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordLengthTextBox = new System.Windows.Forms.PlaceholderTextBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(303, 127);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(79, 23);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // passwordsList
            // 
            this.passwordsList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordsList.Location = new System.Drawing.Point(7, 7);
            this.passwordsList.Multiline = true;
            this.passwordsList.Name = "passwordsList";
            this.passwordsList.ReadOnly = true;
            this.passwordsList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passwordsList.Size = new System.Drawing.Size(290, 172);
            this.passwordsList.TabIndex = 2;
            this.passwordsList.WordWrap = false;
            // 
            // clearPasswordsListButton
            // 
            this.clearPasswordsListButton.Location = new System.Drawing.Point(303, 156);
            this.clearPasswordsListButton.Name = "clearPasswordsListButton";
            this.clearPasswordsListButton.Size = new System.Drawing.Size(79, 23);
            this.clearPasswordsListButton.TabIndex = 3;
            this.clearPasswordsListButton.Text = "Clear";
            this.clearPasswordsListButton.UseVisualStyleBackColor = true;
            this.clearPasswordsListButton.Click += new System.EventHandler(this.ClearPasswordsListButton_Click);
            // 
            // includeLowercaseCheckBox
            // 
            this.includeLowercaseCheckBox.AutoSize = true;
            this.includeLowercaseCheckBox.Checked = true;
            this.includeLowercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeLowercaseCheckBox.Location = new System.Drawing.Point(303, 7);
            this.includeLowercaseCheckBox.Name = "includeLowercaseCheckBox";
            this.includeLowercaseCheckBox.Size = new System.Drawing.Size(79, 17);
            this.includeLowercaseCheckBox.TabIndex = 4;
            this.includeLowercaseCheckBox.Text = "Lowercase";
            this.includeLowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeUppercaseCheckBox
            // 
            this.includeUppercaseCheckBox.AutoSize = true;
            this.includeUppercaseCheckBox.Checked = true;
            this.includeUppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeUppercaseCheckBox.Location = new System.Drawing.Point(303, 30);
            this.includeUppercaseCheckBox.Name = "includeUppercaseCheckBox";
            this.includeUppercaseCheckBox.Size = new System.Drawing.Size(80, 17);
            this.includeUppercaseCheckBox.TabIndex = 5;
            this.includeUppercaseCheckBox.Text = "Uppercase";
            this.includeUppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeNumericCheckBox
            // 
            this.includeNumericCheckBox.AutoSize = true;
            this.includeNumericCheckBox.Checked = true;
            this.includeNumericCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeNumericCheckBox.Location = new System.Drawing.Point(303, 53);
            this.includeNumericCheckBox.Name = "includeNumericCheckBox";
            this.includeNumericCheckBox.Size = new System.Drawing.Size(68, 17);
            this.includeNumericCheckBox.TabIndex = 6;
            this.includeNumericCheckBox.Text = "Numeric";
            this.includeNumericCheckBox.UseVisualStyleBackColor = true;
            // 
            // includeSpecialCheckBox
            // 
            this.includeSpecialCheckBox.AutoSize = true;
            this.includeSpecialCheckBox.Checked = true;
            this.includeSpecialCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeSpecialCheckBox.Location = new System.Drawing.Point(303, 76);
            this.includeSpecialCheckBox.Name = "includeSpecialCheckBox";
            this.includeSpecialCheckBox.Size = new System.Drawing.Size(62, 17);
            this.includeSpecialCheckBox.TabIndex = 7;
            this.includeSpecialCheckBox.Text = "Special";
            this.includeSpecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordLengthTextBox
            // 
            this.passwordLengthTextBox.Location = new System.Drawing.Point(303, 99);
            this.passwordLengthTextBox.Name = "passwordLengthTextBox";
            this.passwordLengthTextBox.Placeholder = "Length";
            this.passwordLengthTextBox.PlaceholderActiveForeColor = System.Drawing.Color.Gray;
            this.passwordLengthTextBox.PlaceholderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLengthTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordLengthTextBox.Size = new System.Drawing.Size(79, 22);
            this.passwordLengthTextBox.TabIndex = 8;
            this.passwordLengthTextBox.Text = "32";
            this.passwordLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLengthTextBox_KeyPress);
            // 
            // PasswordGeneratorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 186);
            this.Controls.Add(this.passwordLengthTextBox);
            this.Controls.Add(this.includeSpecialCheckBox);
            this.Controls.Add(this.includeNumericCheckBox);
            this.Controls.Add(this.includeUppercaseCheckBox);
            this.Controls.Add(this.includeLowercaseCheckBox);
            this.Controls.Add(this.clearPasswordsListButton);
            this.Controls.Add(this.passwordsList);
            this.Controls.Add(this.generateButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorFrom";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Password Generator";
            this.Shown += new System.EventHandler(this.PasswordGeneratorFrom_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordsList;
        private System.Windows.Forms.Button clearPasswordsListButton;
        private System.Windows.Forms.CheckBox includeLowercaseCheckBox;
        private System.Windows.Forms.CheckBox includeUppercaseCheckBox;
        private System.Windows.Forms.CheckBox includeNumericCheckBox;
        private System.Windows.Forms.CheckBox includeSpecialCheckBox;
        private System.Windows.Forms.PlaceholderTextBox passwordLengthTextBox;
    }
}