namespace NewUI
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
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroTextBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.metroTextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metroTextBoxStrength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.metroTextBoxCertainty = new System.Windows.Forms.TextBox();
            this.metroTextBoxPathToSave = new System.Windows.Forms.TextBox();
            this.metroButtonPathSelect = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButtonGenerate
            // 
            this.metroButtonGenerate.Location = new System.Drawing.Point(231, 367);
            this.metroButtonGenerate.Name = "metroButtonGenerate";
            this.metroButtonGenerate.Size = new System.Drawing.Size(129, 31);
            this.metroButtonGenerate.TabIndex = 0;
            this.metroButtonGenerate.Text = "Generate";
            this.metroButtonGenerate.UseSelectable = true;
            this.metroButtonGenerate.Click += new System.EventHandler(this.metroButtonGenerate_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(125, 367);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(100, 31);
            this.metroButtonClear.TabIndex = 15;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "© maksim789456, С# code and Old UI Design, 2018\r\n© thecrazywolf, New UI Design, 2" +
    "018\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.metroTextBoxPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.metroTextBoxUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 161);
            this.panel1.TabIndex = 34;
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroTextBoxPassword.Location = new System.Drawing.Point(104, 108);
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.Size = new System.Drawing.Size(126, 25);
            this.metroTextBoxPassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroTextBoxUsername.Location = new System.Drawing.Point(104, 76);
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.Size = new System.Drawing.Size(126, 25);
            this.metroTextBoxUsername.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key Generator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Strength:";
            // 
            // metroTextBoxStrength
            // 
            this.metroTextBoxStrength.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroTextBoxStrength.Location = new System.Drawing.Point(104, 187);
            this.metroTextBoxStrength.Name = "metroTextBoxStrength";
            this.metroTextBoxStrength.Size = new System.Drawing.Size(126, 25);
            this.metroTextBoxStrength.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Certainty:";
            // 
            // metroTextBoxCertainty
            // 
            this.metroTextBoxCertainty.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroTextBoxCertainty.Location = new System.Drawing.Point(104, 219);
            this.metroTextBoxCertainty.Name = "metroTextBoxCertainty";
            this.metroTextBoxCertainty.Size = new System.Drawing.Size(126, 25);
            this.metroTextBoxCertainty.TabIndex = 38;
            // 
            // metroTextBoxPathToSave
            // 
            this.metroTextBoxPathToSave.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroTextBoxPathToSave.Location = new System.Drawing.Point(12, 28);
            this.metroTextBoxPathToSave.Name = "metroTextBoxPathToSave";
            this.metroTextBoxPathToSave.Size = new System.Drawing.Size(277, 25);
            this.metroTextBoxPathToSave.TabIndex = 39;
            // 
            // metroButtonPathSelect
            // 
            this.metroButtonPathSelect.Location = new System.Drawing.Point(295, 28);
            this.metroButtonPathSelect.Name = "metroButtonPathSelect";
            this.metroButtonPathSelect.Size = new System.Drawing.Size(43, 25);
            this.metroButtonPathSelect.TabIndex = 40;
            this.metroButtonPathSelect.Text = "...";
            this.metroButtonPathSelect.UseSelectable = true;
            this.metroButtonPathSelect.Click += new System.EventHandler(this.metroButtonPathSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroButtonPathSelect);
            this.groupBox1.Controls.Add(this.metroTextBoxPathToSave);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.groupBox1.Location = new System.Drawing.Point(22, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 70);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path to save key:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 367);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(96, 31);
            this.metroButton1.TabIndex = 40;
            this.metroButton1.Text = "Exit";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // KeyGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 453);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroTextBoxCertainty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.metroTextBoxStrength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButtonClear);
            this.Controls.Add(this.metroButtonGenerate);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "KeyGen";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Key Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonGenerate;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metroTextBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox metroTextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox metroTextBoxStrength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox metroTextBoxCertainty;
        private System.Windows.Forms.TextBox metroTextBoxPathToSave;
        private MetroFramework.Controls.MetroButton metroButtonPathSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}