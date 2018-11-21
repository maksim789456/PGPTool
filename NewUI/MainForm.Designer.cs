namespace NewUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogInputFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogPublicKey = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogPrivateKey = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroCheckBoxIntegrityCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroCheckBoxArmor = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new NewUI.CustomGroupBox();
            this.metroTextBoxPasswordPGP = new System.Windows.Forms.TextBox();
            this.groupBox5 = new NewUI.CustomGroupBox();
            this.metroTextBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.metroButtonPrivateKeyOpen = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new NewUI.CustomGroupBox();
            this.metroTextBoxPublicKey = new System.Windows.Forms.TextBox();
            this.metroButtonPublicKeyOpen = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new NewUI.CustomGroupBox();
            this.metroTextBoxInputFilePath = new System.Windows.Forms.TextBox();
            this.metroButtonInputFileOpen = new MetroFramework.Controls.MetroButton();
            this.groupBox3 = new NewUI.CustomGroupBox();
            this.metroTextBoxOutputFilePath = new System.Windows.Forms.TextBox();
            this.metroButtonOutputFileSelect = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new NewUI.CustomGroupBox();
            this.metroRadioButtonDecrypt = new System.Windows.Forms.RadioButton();
            this.metroRadioButtonEncrypt = new System.Windows.Forms.RadioButton();
            this.metroButtonKeyGenerator = new MetroFramework.Controls.MetroButton();
            this.metroButtonWork = new MetroFramework.Controls.MetroButton();
            this.metroButtonClear = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogInputFile
            // 
            this.openFileDialogInputFile.Filter = "All Files|*.*";
            // 
            // saveFileDialogOutputFile
            // 
            this.saveFileDialogOutputFile.Filter = "PGP File|*.PGP";
            // 
            // openFileDialogPublicKey
            // 
            this.openFileDialogPublicKey.FileName = "pub.key";
            this.openFileDialogPublicKey.Filter = "Public PGP Key|*.key;*.asc";
            // 
            // openFileDialogPrivateKey
            // 
            this.openFileDialogPrivateKey.FileName = "pri.key";
            this.openFileDialogPrivateKey.Filter = "Private PGP Key|*.key;*.asc";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(103)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.metroCheckBoxIntegrityCheck);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroCheckBoxArmor);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.metroButtonKeyGenerator);
            this.panel1.Controls.Add(this.metroButtonWork);
            this.panel1.Controls.Add(this.metroButtonClear);
            this.panel1.Location = new System.Drawing.Point(0, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 399);
            this.panel1.TabIndex = 38;
            // 
            // metroCheckBoxIntegrityCheck
            // 
            this.metroCheckBoxIntegrityCheck.AutoSize = true;
            this.metroCheckBoxIntegrityCheck.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.metroCheckBoxIntegrityCheck.ForeColor = System.Drawing.Color.White;
            this.metroCheckBoxIntegrityCheck.Location = new System.Drawing.Point(91, 434);
            this.metroCheckBoxIntegrityCheck.Name = "metroCheckBoxIntegrityCheck";
            this.metroCheckBoxIntegrityCheck.Size = new System.Drawing.Size(311, 21);
            this.metroCheckBoxIntegrityCheck.TabIndex = 76;
            this.metroCheckBoxIntegrityCheck.Text = "Сheck the integrity of the package on the input file";
            this.metroCheckBoxIntegrityCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "© maksim789456, С# code and Old UI Design, 2018\r\n© thecrazywolf, New UI Design, 2" +
    "018\r\n";
            // 
            // metroCheckBoxArmor
            // 
            this.metroCheckBoxArmor.AutoSize = true;
            this.metroCheckBoxArmor.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.metroCheckBoxArmor.ForeColor = System.Drawing.Color.White;
            this.metroCheckBoxArmor.Location = new System.Drawing.Point(150, 416);
            this.metroCheckBoxArmor.Name = "metroCheckBoxArmor";
            this.metroCheckBoxArmor.Size = new System.Drawing.Size(215, 21);
            this.metroCheckBoxArmor.TabIndex = 75;
            this.metroCheckBoxArmor.Text = "Binary representation as ASCII text";
            this.metroCheckBoxArmor.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.metroTextBoxPasswordPGP);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(23, 349);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(432, 63);
            this.groupBox6.TabIndex = 73;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Password to PGP";
            // 
            // metroTextBoxPasswordPGP
            // 
            this.metroTextBoxPasswordPGP.Location = new System.Drawing.Point(17, 24);
            this.metroTextBoxPasswordPGP.Name = "metroTextBoxPasswordPGP";
            this.metroTextBoxPasswordPGP.PasswordChar = '*';
            this.metroTextBoxPasswordPGP.Size = new System.Drawing.Size(405, 25);
            this.metroTextBoxPasswordPGP.TabIndex = 48;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.metroTextBoxPrivateKey);
            this.groupBox5.Controls.Add(this.metroButtonPrivateKeyOpen);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(23, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 63);
            this.groupBox5.TabIndex = 72;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Private Key Path:";
            // 
            // metroTextBoxPrivateKey
            // 
            this.metroTextBoxPrivateKey.Location = new System.Drawing.Point(17, 24);
            this.metroTextBoxPrivateKey.Name = "metroTextBoxPrivateKey";
            this.metroTextBoxPrivateKey.Size = new System.Drawing.Size(362, 25);
            this.metroTextBoxPrivateKey.TabIndex = 48;
            // 
            // metroButtonPrivateKeyOpen
            // 
            this.metroButtonPrivateKeyOpen.Location = new System.Drawing.Point(381, 24);
            this.metroButtonPrivateKeyOpen.Name = "metroButtonPrivateKeyOpen";
            this.metroButtonPrivateKeyOpen.Size = new System.Drawing.Size(41, 25);
            this.metroButtonPrivateKeyOpen.TabIndex = 46;
            this.metroButtonPrivateKeyOpen.Text = "...";
            this.metroButtonPrivateKeyOpen.UseSelectable = true;
            this.metroButtonPrivateKeyOpen.Click += new System.EventHandler(this.metroButtonPrivateKeyOpen_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroTextBoxPublicKey);
            this.groupBox4.Controls.Add(this.metroButtonPublicKeyOpen);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(23, 211);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 63);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Public Key Path:";
            // 
            // metroTextBoxPublicKey
            // 
            this.metroTextBoxPublicKey.Location = new System.Drawing.Point(17, 24);
            this.metroTextBoxPublicKey.Name = "metroTextBoxPublicKey";
            this.metroTextBoxPublicKey.Size = new System.Drawing.Size(362, 25);
            this.metroTextBoxPublicKey.TabIndex = 48;
            // 
            // metroButtonPublicKeyOpen
            // 
            this.metroButtonPublicKeyOpen.Location = new System.Drawing.Point(381, 24);
            this.metroButtonPublicKeyOpen.Name = "metroButtonPublicKeyOpen";
            this.metroButtonPublicKeyOpen.Size = new System.Drawing.Size(41, 25);
            this.metroButtonPublicKeyOpen.TabIndex = 46;
            this.metroButtonPublicKeyOpen.Text = "...";
            this.metroButtonPublicKeyOpen.UseSelectable = true;
            this.metroButtonPublicKeyOpen.Click += new System.EventHandler(this.metroButtonPublicKeyOpen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTextBoxInputFilePath);
            this.groupBox2.Controls.Add(this.metroButtonInputFileOpen);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 63);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input File Path:";
            // 
            // metroTextBoxInputFilePath
            // 
            this.metroTextBoxInputFilePath.Location = new System.Drawing.Point(17, 24);
            this.metroTextBoxInputFilePath.Name = "metroTextBoxInputFilePath";
            this.metroTextBoxInputFilePath.Size = new System.Drawing.Size(362, 25);
            this.metroTextBoxInputFilePath.TabIndex = 48;
            // 
            // metroButtonInputFileOpen
            // 
            this.metroButtonInputFileOpen.Location = new System.Drawing.Point(381, 24);
            this.metroButtonInputFileOpen.Name = "metroButtonInputFileOpen";
            this.metroButtonInputFileOpen.Size = new System.Drawing.Size(41, 25);
            this.metroButtonInputFileOpen.TabIndex = 46;
            this.metroButtonInputFileOpen.Text = "...";
            this.metroButtonInputFileOpen.UseSelectable = true;
            this.metroButtonInputFileOpen.Click += new System.EventHandler(this.metroButtonInputFileOpen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroTextBoxOutputFilePath);
            this.groupBox3.Controls.Add(this.metroButtonOutputFileSelect);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(23, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 63);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output File Path:";
            // 
            // metroTextBoxOutputFilePath
            // 
            this.metroTextBoxOutputFilePath.Location = new System.Drawing.Point(17, 24);
            this.metroTextBoxOutputFilePath.Name = "metroTextBoxOutputFilePath";
            this.metroTextBoxOutputFilePath.Size = new System.Drawing.Size(358, 25);
            this.metroTextBoxOutputFilePath.TabIndex = 51;
            // 
            // metroButtonOutputFileSelect
            // 
            this.metroButtonOutputFileSelect.Location = new System.Drawing.Point(381, 24);
            this.metroButtonOutputFileSelect.Name = "metroButtonOutputFileSelect";
            this.metroButtonOutputFileSelect.Size = new System.Drawing.Size(41, 25);
            this.metroButtonOutputFileSelect.TabIndex = 49;
            this.metroButtonOutputFileSelect.Text = "...";
            this.metroButtonOutputFileSelect.UseSelectable = true;
            this.metroButtonOutputFileSelect.Click += new System.EventHandler(this.metroButtonOutputFileSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroRadioButtonDecrypt);
            this.groupBox1.Controls.Add(this.metroRadioButtonEncrypt);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 58);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Mode";
            // 
            // metroRadioButtonDecrypt
            // 
            this.metroRadioButtonDecrypt.AutoSize = true;
            this.metroRadioButtonDecrypt.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroRadioButtonDecrypt.ForeColor = System.Drawing.Color.White;
            this.metroRadioButtonDecrypt.Location = new System.Drawing.Point(233, 24);
            this.metroRadioButtonDecrypt.Name = "metroRadioButtonDecrypt";
            this.metroRadioButtonDecrypt.Size = new System.Drawing.Size(73, 23);
            this.metroRadioButtonDecrypt.TabIndex = 64;
            this.metroRadioButtonDecrypt.TabStop = true;
            this.metroRadioButtonDecrypt.Text = "Decrypt";
            this.metroRadioButtonDecrypt.UseVisualStyleBackColor = true;
            this.metroRadioButtonDecrypt.CheckedChanged += new System.EventHandler(this.metroRadioButton_CheckedChanged);
            // 
            // metroRadioButtonEncrypt
            // 
            this.metroRadioButtonEncrypt.AutoSize = true;
            this.metroRadioButtonEncrypt.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.metroRadioButtonEncrypt.ForeColor = System.Drawing.Color.White;
            this.metroRadioButtonEncrypt.Location = new System.Drawing.Point(127, 24);
            this.metroRadioButtonEncrypt.Name = "metroRadioButtonEncrypt";
            this.metroRadioButtonEncrypt.Size = new System.Drawing.Size(71, 23);
            this.metroRadioButtonEncrypt.TabIndex = 63;
            this.metroRadioButtonEncrypt.TabStop = true;
            this.metroRadioButtonEncrypt.Text = "Encrypt";
            this.metroRadioButtonEncrypt.UseVisualStyleBackColor = true;
            this.metroRadioButtonEncrypt.CheckedChanged += new System.EventHandler(this.metroRadioButton_CheckedChanged);
            // 
            // metroButtonKeyGenerator
            // 
            this.metroButtonKeyGenerator.Location = new System.Drawing.Point(131, 462);
            this.metroButtonKeyGenerator.Name = "metroButtonKeyGenerator";
            this.metroButtonKeyGenerator.Size = new System.Drawing.Size(157, 29);
            this.metroButtonKeyGenerator.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonKeyGenerator.TabIndex = 42;
            this.metroButtonKeyGenerator.Text = "Key Generator";
            this.metroButtonKeyGenerator.UseSelectable = true;
            this.metroButtonKeyGenerator.Click += new System.EventHandler(this.metroButtonKeyGenerator_Click);
            // 
            // metroButtonWork
            // 
            this.metroButtonWork.Enabled = false;
            this.metroButtonWork.Location = new System.Drawing.Point(294, 462);
            this.metroButtonWork.Name = "metroButtonWork";
            this.metroButtonWork.Size = new System.Drawing.Size(161, 29);
            this.metroButtonWork.TabIndex = 40;
            this.metroButtonWork.Text = "Select work mode";
            this.metroButtonWork.UseSelectable = true;
            this.metroButtonWork.Click += new System.EventHandler(this.metroButtonWork_Click);
            // 
            // metroButtonClear
            // 
            this.metroButtonClear.Location = new System.Drawing.Point(23, 462);
            this.metroButtonClear.Name = "metroButtonClear";
            this.metroButtonClear.Size = new System.Drawing.Size(102, 29);
            this.metroButtonClear.TabIndex = 39;
            this.metroButtonClear.Text = "Clear";
            this.metroButtonClear.UseSelectable = true;
            this.metroButtonClear.Click += new System.EventHandler(this.metroButtonClear_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(150, 52);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(179, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Encrypt and Decrypt file easy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NewUI.Properties.Resources.User_Authentication;
            this.pictureBox1.Location = new System.Drawing.Point(-127, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "PGP File Tool";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogInputFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogOutputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogPublicKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogPrivateKey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButtonKeyGenerator;
        private MetroFramework.Controls.MetroButton metroButtonWork;
        private MetroFramework.Controls.MetroButton metroButtonClear;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomGroupBox groupBox1;
        private System.Windows.Forms.RadioButton metroRadioButtonDecrypt;
        private System.Windows.Forms.RadioButton metroRadioButtonEncrypt;
        private CustomGroupBox groupBox2;
        private System.Windows.Forms.TextBox metroTextBoxInputFilePath;
        private MetroFramework.Controls.MetroButton metroButtonInputFileOpen;
        private CustomGroupBox groupBox3;
        private System.Windows.Forms.TextBox metroTextBoxOutputFilePath;
        private MetroFramework.Controls.MetroButton metroButtonOutputFileSelect;
        private CustomGroupBox groupBox5;
        private System.Windows.Forms.TextBox metroTextBoxPrivateKey;
        private MetroFramework.Controls.MetroButton metroButtonPrivateKeyOpen;
        private CustomGroupBox groupBox4;
        private System.Windows.Forms.TextBox metroTextBoxPublicKey;
        private MetroFramework.Controls.MetroButton metroButtonPublicKeyOpen;
        private CustomGroupBox groupBox6;
        private System.Windows.Forms.TextBox metroTextBoxPasswordPGP;
        private System.Windows.Forms.CheckBox metroCheckBoxIntegrityCheck;
        private System.Windows.Forms.CheckBox metroCheckBoxArmor;
    }
}

