namespace PGPFileTool
{
    partial class KeyGen
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
            this.metroButtonGenerate = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxStrength = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCertainty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPathToSave = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonPathSelect = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroButtonGenerate
            // 
            this.metroButtonGenerate.Location = new System.Drawing.Point(209, 169);
            this.metroButtonGenerate.Name = "metroButtonGenerate";
            this.metroButtonGenerate.Size = new System.Drawing.Size(155, 51);
            this.metroButtonGenerate.TabIndex = 0;
            this.metroButtonGenerate.Text = "Generate";
            this.metroButtonGenerate.UseSelectable = true;
            this.metroButtonGenerate.Click += new System.EventHandler(this.metroButtonGenerate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username:";
            // 
            // metroTextBoxUsername
            // 
            // 
            // 
            // 
            this.metroTextBoxUsername.CustomButton.Image = null;
            this.metroTextBoxUsername.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.metroTextBoxUsername.CustomButton.Name = "";
            this.metroTextBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxUsername.CustomButton.Visible = false;
            this.metroTextBoxUsername.Lines = new string[0];
            this.metroTextBoxUsername.Location = new System.Drawing.Point(101, 64);
            this.metroTextBoxUsername.MaxLength = 32767;
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.PasswordChar = '\0';
            this.metroTextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsername.SelectedText = "";
            this.metroTextBoxUsername.SelectionLength = 0;
            this.metroTextBoxUsername.SelectionStart = 0;
            this.metroTextBoxUsername.ShortcutsEnabled = true;
            this.metroTextBoxUsername.Size = new System.Drawing.Size(84, 23);
            this.metroTextBoxUsername.TabIndex = 2;
            this.metroTextBoxUsername.UseSelectable = true;
            this.metroTextBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 93);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password:";
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(101, 93);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(84, 23);
            this.metroTextBoxPassword.TabIndex = 4;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(209, 64);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Strength:";
            // 
            // metroTextBoxStrength
            // 
            // 
            // 
            // 
            this.metroTextBoxStrength.CustomButton.Image = null;
            this.metroTextBoxStrength.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.metroTextBoxStrength.CustomButton.Name = "";
            this.metroTextBoxStrength.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxStrength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxStrength.CustomButton.TabIndex = 1;
            this.metroTextBoxStrength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxStrength.CustomButton.UseSelectable = true;
            this.metroTextBoxStrength.CustomButton.Visible = false;
            this.metroTextBoxStrength.Lines = new string[0];
            this.metroTextBoxStrength.Location = new System.Drawing.Point(276, 64);
            this.metroTextBoxStrength.MaxLength = 32767;
            this.metroTextBoxStrength.Name = "metroTextBoxStrength";
            this.metroTextBoxStrength.PasswordChar = '\0';
            this.metroTextBoxStrength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxStrength.SelectedText = "";
            this.metroTextBoxStrength.SelectionLength = 0;
            this.metroTextBoxStrength.SelectionStart = 0;
            this.metroTextBoxStrength.ShortcutsEnabled = true;
            this.metroTextBoxStrength.Size = new System.Drawing.Size(84, 23);
            this.metroTextBoxStrength.TabIndex = 6;
            this.metroTextBoxStrength.UseSelectable = true;
            this.metroTextBoxStrength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxStrength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxStrength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxStrength_KeyPress);
            // 
            // metroTextBoxCertainty
            // 
            // 
            // 
            // 
            this.metroTextBoxCertainty.CustomButton.Image = null;
            this.metroTextBoxCertainty.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.metroTextBoxCertainty.CustomButton.Name = "";
            this.metroTextBoxCertainty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCertainty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCertainty.CustomButton.TabIndex = 1;
            this.metroTextBoxCertainty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCertainty.CustomButton.UseSelectable = true;
            this.metroTextBoxCertainty.CustomButton.Visible = false;
            this.metroTextBoxCertainty.Lines = new string[0];
            this.metroTextBoxCertainty.Location = new System.Drawing.Point(276, 93);
            this.metroTextBoxCertainty.MaxLength = 32767;
            this.metroTextBoxCertainty.Name = "metroTextBoxCertainty";
            this.metroTextBoxCertainty.PasswordChar = '\0';
            this.metroTextBoxCertainty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCertainty.SelectedText = "";
            this.metroTextBoxCertainty.SelectionLength = 0;
            this.metroTextBoxCertainty.SelectionStart = 0;
            this.metroTextBoxCertainty.ShortcutsEnabled = true;
            this.metroTextBoxCertainty.Size = new System.Drawing.Size(84, 23);
            this.metroTextBoxCertainty.TabIndex = 7;
            this.metroTextBoxCertainty.UseSelectable = true;
            this.metroTextBoxCertainty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCertainty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCertainty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBoxCertainty_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(209, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Certainty:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 122);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(105, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Path to save key:";
            // 
            // metroTextBoxPathToSave
            // 
            // 
            // 
            // 
            this.metroTextBoxPathToSave.CustomButton.Image = null;
            this.metroTextBoxPathToSave.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.metroTextBoxPathToSave.CustomButton.Name = "";
            this.metroTextBoxPathToSave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPathToSave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPathToSave.CustomButton.TabIndex = 1;
            this.metroTextBoxPathToSave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPathToSave.CustomButton.UseSelectable = true;
            this.metroTextBoxPathToSave.CustomButton.Visible = false;
            this.metroTextBoxPathToSave.Lines = new string[0];
            this.metroTextBoxPathToSave.Location = new System.Drawing.Point(135, 122);
            this.metroTextBoxPathToSave.MaxLength = 32767;
            this.metroTextBoxPathToSave.Name = "metroTextBoxPathToSave";
            this.metroTextBoxPathToSave.PasswordChar = '\0';
            this.metroTextBoxPathToSave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPathToSave.SelectedText = "";
            this.metroTextBoxPathToSave.SelectionLength = 0;
            this.metroTextBoxPathToSave.SelectionStart = 0;
            this.metroTextBoxPathToSave.ShortcutsEnabled = true;
            this.metroTextBoxPathToSave.Size = new System.Drawing.Size(176, 23);
            this.metroTextBoxPathToSave.TabIndex = 11;
            this.metroTextBoxPathToSave.UseSelectable = true;
            this.metroTextBoxPathToSave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPathToSave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonPathSelect
            // 
            this.metroButtonPathSelect.Location = new System.Drawing.Point(317, 122);
            this.metroButtonPathSelect.Name = "metroButtonPathSelect";
            this.metroButtonPathSelect.Size = new System.Drawing.Size(43, 23);
            this.metroButtonPathSelect.TabIndex = 12;
            this.metroButtonPathSelect.Text = "...";
            this.metroButtonPathSelect.UseSelectable = true;
            this.metroButtonPathSelect.Click += new System.EventHandler(this.metroButtonPathSelect_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(23, 169);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(155, 51);
            this.metroButtonClear.TabIndex = 15;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "© maksim789456, 2018\r\n";
            // 
            // KeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButtonClear);
            this.Controls.Add(this.metroButtonPathSelect);
            this.Controls.Add(this.metroTextBoxPathToSave);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxCertainty);
            this.Controls.Add(this.metroTextBoxStrength);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxUsername);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonGenerate);
            this.MaximizeBox = false;
            this.Name = "KeyGen";
            this.Resizable = false;
            this.Text = "Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonGenerate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxStrength;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCertainty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPathToSave;
        private MetroFramework.Controls.MetroButton metroButtonPathSelect;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
    }
}