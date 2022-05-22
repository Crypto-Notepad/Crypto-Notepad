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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGeneratorFrom));
            this.generateButton = new System.Windows.Forms.Button();
            this.passwordsListTextBox = new System.Windows.Forms.TextBox();
            this.clearPasswordsListButton = new System.Windows.Forms.Button();
            this.lowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.uppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.numericCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.numberOfStringsLabel = new System.Windows.Forms.Label();
            this.passwordLengthTextBox = new System.Windows.Forms.TextBox();
            this.numberOfStringsTextBox = new System.Windows.Forms.TextBox();
            this.copyAllButton = new System.Windows.Forms.Button();
            this.copyLastButton = new System.Windows.Forms.Button();
            this.passwordGeneratorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.specialCheckBox = new System.Windows.Forms.CheckBox();
            this.additionalCheckBox = new System.Windows.Forms.CheckBox();
            this.bracketsCheckBox = new System.Windows.Forms.CheckBox();
            this.specialGroupBox = new System.Windows.Forms.GroupBox();
            this.specialGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.AutoSize = true;
            this.generateButton.Location = new System.Drawing.Point(9, 132);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(66, 23);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // passwordsListTextBox
            // 
            this.passwordsListTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordsListTextBox.Location = new System.Drawing.Point(9, 161);
            this.passwordsListTextBox.Multiline = true;
            this.passwordsListTextBox.Name = "passwordsListTextBox";
            this.passwordsListTextBox.ReadOnly = true;
            this.passwordsListTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.passwordsListTextBox.Size = new System.Drawing.Size(282, 174);
            this.passwordsListTextBox.TabIndex = 11;
            this.passwordsListTextBox.WordWrap = false;
            this.passwordsListTextBox.TextChanged += new System.EventHandler(this.PasswordsListTextBox_TextChanged);
            // 
            // clearPasswordsListButton
            // 
            this.clearPasswordsListButton.AutoSize = true;
            this.clearPasswordsListButton.Location = new System.Drawing.Point(81, 132);
            this.clearPasswordsListButton.Name = "clearPasswordsListButton";
            this.clearPasswordsListButton.Size = new System.Drawing.Size(66, 23);
            this.clearPasswordsListButton.TabIndex = 4;
            this.clearPasswordsListButton.Text = "Clear";
            this.clearPasswordsListButton.UseVisualStyleBackColor = true;
            this.clearPasswordsListButton.Click += new System.EventHandler(this.ClearPasswordsListButton_Click);
            // 
            // lowercaseCheckBox
            // 
            this.lowercaseCheckBox.AutoSize = true;
            this.lowercaseCheckBox.Checked = true;
            this.lowercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowercaseCheckBox.Location = new System.Drawing.Point(55, 21);
            this.lowercaseCheckBox.Name = "lowercaseCheckBox";
            this.lowercaseCheckBox.Size = new System.Drawing.Size(41, 17);
            this.lowercaseCheckBox.TabIndex = 7;
            this.lowercaseCheckBox.Text = "a-z";
            this.lowercaseCheckBox.UseVisualStyleBackColor = true;
            this.lowercaseCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.lowercaseCheckBox.Click += new System.EventHandler(this.LowercaseCheckBox_Click);
            // 
            // uppercaseCheckBox
            // 
            this.uppercaseCheckBox.AutoSize = true;
            this.uppercaseCheckBox.Checked = true;
            this.uppercaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uppercaseCheckBox.Location = new System.Drawing.Point(6, 21);
            this.uppercaseCheckBox.Name = "uppercaseCheckBox";
            this.uppercaseCheckBox.Size = new System.Drawing.Size(43, 17);
            this.uppercaseCheckBox.TabIndex = 8;
            this.uppercaseCheckBox.Text = "A-Z";
            this.uppercaseCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.uppercaseCheckBox.Click += new System.EventHandler(this.UppercaseCheckBox_Click);
            // 
            // numericCheckBox
            // 
            this.numericCheckBox.AutoSize = true;
            this.numericCheckBox.Checked = true;
            this.numericCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.numericCheckBox.Location = new System.Drawing.Point(102, 21);
            this.numericCheckBox.Name = "numericCheckBox";
            this.numericCheckBox.Size = new System.Drawing.Size(42, 17);
            this.numericCheckBox.TabIndex = 9;
            this.numericCheckBox.Text = "0-9";
            this.numericCheckBox.UseVisualStyleBackColor = true;
            this.numericCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.numericCheckBox.Click += new System.EventHandler(this.NumericCheckBox_Click);
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Location = new System.Drawing.Point(6, 9);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(130, 13);
            this.passwordLengthLabel.TabIndex = 8;
            this.passwordLengthLabel.Text = "Password length [4-256]";
            // 
            // numberOfStringsLabel
            // 
            this.numberOfStringsLabel.AutoSize = true;
            this.numberOfStringsLabel.Location = new System.Drawing.Point(6, 37);
            this.numberOfStringsLabel.Name = "numberOfStringsLabel";
            this.numberOfStringsLabel.Size = new System.Drawing.Size(143, 13);
            this.numberOfStringsLabel.TabIndex = 9;
            this.numberOfStringsLabel.Text = "Number of strings [1-1000]";
            // 
            // passwordLengthTextBox
            // 
            this.passwordLengthTextBox.Location = new System.Drawing.Point(166, 6);
            this.passwordLengthTextBox.Name = "passwordLengthTextBox";
            this.passwordLengthTextBox.Size = new System.Drawing.Size(125, 22);
            this.passwordLengthTextBox.TabIndex = 5;
            this.passwordLengthTextBox.Text = "40";
            this.passwordLengthTextBox.TextChanged += new System.EventHandler(this.PasswordValidation);
            this.passwordLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLengthTextBox_KeyPress);
            // 
            // numberOfStringsTextBox
            // 
            this.numberOfStringsTextBox.Location = new System.Drawing.Point(166, 34);
            this.numberOfStringsTextBox.Name = "numberOfStringsTextBox";
            this.numberOfStringsTextBox.Size = new System.Drawing.Size(125, 22);
            this.numberOfStringsTextBox.TabIndex = 6;
            this.numberOfStringsTextBox.Text = "10";
            this.numberOfStringsTextBox.TextChanged += new System.EventHandler(this.PasswordValidation);
            this.numberOfStringsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordLengthTextBox_KeyPress);
            // 
            // copyAllButton
            // 
            this.copyAllButton.AutoSize = true;
            this.copyAllButton.Location = new System.Drawing.Point(225, 132);
            this.copyAllButton.Name = "copyAllButton";
            this.copyAllButton.Size = new System.Drawing.Size(66, 23);
            this.copyAllButton.TabIndex = 3;
            this.copyAllButton.Text = "Copy all";
            this.copyAllButton.UseVisualStyleBackColor = true;
            this.copyAllButton.Click += new System.EventHandler(this.CopyAllButton_Click);
            this.copyAllButton.MouseEnter += new System.EventHandler(this.CopyAllButton_MouseEnter);
            // 
            // copyLastButton
            // 
            this.copyLastButton.AutoSize = true;
            this.copyLastButton.Location = new System.Drawing.Point(153, 132);
            this.copyLastButton.Name = "copyLastButton";
            this.copyLastButton.Size = new System.Drawing.Size(66, 23);
            this.copyLastButton.TabIndex = 2;
            this.copyLastButton.Text = "Copy last";
            this.copyLastButton.UseVisualStyleBackColor = true;
            this.copyLastButton.Click += new System.EventHandler(this.CopyLastButton_Click);
            this.copyLastButton.MouseEnter += new System.EventHandler(this.CopyLastButton_MouseEnter);
            // 
            // passwordGeneratorToolTip
            // 
            this.passwordGeneratorToolTip.AutoPopDelay = 1000;
            this.passwordGeneratorToolTip.InitialDelay = 1;
            this.passwordGeneratorToolTip.ReshowDelay = 100;
            // 
            // specialCheckBox
            // 
            this.specialCheckBox.AutoSize = true;
            this.specialCheckBox.Location = new System.Drawing.Point(150, 21);
            this.specialCheckBox.Name = "specialCheckBox";
            this.specialCheckBox.Size = new System.Drawing.Size(117, 17);
            this.specialCheckBox.TabIndex = 13;
            this.specialCheckBox.Text = "Special characters";
            this.passwordGeneratorToolTip.SetToolTip(this.specialCheckBox, "/ \\ ! ? @ # & $ % №");
            this.specialCheckBox.UseVisualStyleBackColor = true;
            this.specialCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.specialCheckBox.Click += new System.EventHandler(this.SpecialCheckBox_Click);
            this.specialCheckBox.MouseEnter += new System.EventHandler(this.SpecialCheckBox_MouseEnter);
            // 
            // additionalCheckBox
            // 
            this.additionalCheckBox.AutoSize = true;
            this.additionalCheckBox.Location = new System.Drawing.Point(80, 41);
            this.additionalCheckBox.Name = "additionalCheckBox";
            this.additionalCheckBox.Size = new System.Drawing.Size(80, 17);
            this.additionalCheckBox.TabIndex = 13;
            this.additionalCheckBox.Text = "Additional";
            this.passwordGeneratorToolTip.SetToolTip(this.additionalCheckBox, "\" ; _ - . = * + : ^ , | \'");
            this.additionalCheckBox.UseVisualStyleBackColor = true;
            this.additionalCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.additionalCheckBox.Click += new System.EventHandler(this.additionalCheckBox_Click);
            this.additionalCheckBox.MouseEnter += new System.EventHandler(this.SpecialCheckBox_MouseEnter);
            // 
            // bracketsCheckBox
            // 
            this.bracketsCheckBox.AutoSize = true;
            this.bracketsCheckBox.Location = new System.Drawing.Point(6, 41);
            this.bracketsCheckBox.Name = "bracketsCheckBox";
            this.bracketsCheckBox.Size = new System.Drawing.Size(68, 17);
            this.bracketsCheckBox.TabIndex = 13;
            this.bracketsCheckBox.Text = "Brackets";
            this.passwordGeneratorToolTip.SetToolTip(this.bracketsCheckBox, "( ) { } [ ] < >");
            this.bracketsCheckBox.UseVisualStyleBackColor = true;
            this.bracketsCheckBox.CheckedChanged += new System.EventHandler(this.PasswordValidation);
            this.bracketsCheckBox.Click += new System.EventHandler(this.BracketsCheckBox_Click);
            this.bracketsCheckBox.MouseEnter += new System.EventHandler(this.SpecialCheckBox_MouseEnter);
            // 
            // specialGroupBox
            // 
            this.specialGroupBox.Controls.Add(this.bracketsCheckBox);
            this.specialGroupBox.Controls.Add(this.additionalCheckBox);
            this.specialGroupBox.Controls.Add(this.uppercaseCheckBox);
            this.specialGroupBox.Controls.Add(this.lowercaseCheckBox);
            this.specialGroupBox.Controls.Add(this.numericCheckBox);
            this.specialGroupBox.Controls.Add(this.specialCheckBox);
            this.specialGroupBox.Location = new System.Drawing.Point(9, 62);
            this.specialGroupBox.Name = "specialGroupBox";
            this.specialGroupBox.Size = new System.Drawing.Size(282, 64);
            this.specialGroupBox.TabIndex = 12;
            this.specialGroupBox.TabStop = false;
            this.specialGroupBox.Text = "Use characters";
            // 
            // PasswordGeneratorFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 344);
            this.Controls.Add(this.specialGroupBox);
            this.Controls.Add(this.copyLastButton);
            this.Controls.Add(this.copyAllButton);
            this.Controls.Add(this.numberOfStringsTextBox);
            this.Controls.Add(this.passwordLengthTextBox);
            this.Controls.Add(this.numberOfStringsLabel);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.clearPasswordsListButton);
            this.Controls.Add(this.passwordsListTextBox);
            this.Controls.Add(this.generateButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordGeneratorFrom";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Password Generator";
            this.Deactivate += new System.EventHandler(this.PasswordGeneratorFrom_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordGeneratorFrom_FormClosing);
            this.Load += new System.EventHandler(this.PasswordGeneratorFrom_Load);
            this.specialGroupBox.ResumeLayout(false);
            this.specialGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox passwordsListTextBox;
        private System.Windows.Forms.Button clearPasswordsListButton;
        private System.Windows.Forms.CheckBox lowercaseCheckBox;
        private System.Windows.Forms.CheckBox uppercaseCheckBox;
        private System.Windows.Forms.CheckBox numericCheckBox;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.Label numberOfStringsLabel;
        private System.Windows.Forms.TextBox passwordLengthTextBox;
        private System.Windows.Forms.TextBox numberOfStringsTextBox;
        private System.Windows.Forms.Button copyAllButton;
        private System.Windows.Forms.Button copyLastButton;
        private System.Windows.Forms.ToolTip passwordGeneratorToolTip;
        private System.Windows.Forms.GroupBox specialGroupBox;
        private System.Windows.Forms.CheckBox specialCheckBox;
        private System.Windows.Forms.CheckBox additionalCheckBox;
        private System.Windows.Forms.CheckBox bracketsCheckBox;
    }
}